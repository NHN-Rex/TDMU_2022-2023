using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_manager.Child_Form
{
    public partial class Form_ViTri : Form
    {
        private ConnectDatabase conn = new ConnectDatabase();
        private int kt;
        public Form_ViTri()
        {
            InitializeComponent();
        }

        private void back()
        {
            txtMavitri.Text = string.Empty;
            txtTenvitri.Text = string.Empty;
            txtMavitri.Focus();
        }

        private void enablecommand(bool kt)
        {
            btnXacnhan.Enabled = !kt;
            btnThem.Enabled = kt;
            btnXoa.Enabled = kt;
        }

        private void binding()
        {
            Int32 i = Convert.ToInt32(grvVitri.CurrentRow.Index);

            txtMavitri.DataBindings.Clear();
            txtMavitri.DataBindings.Add("Text", grvVitri.DataSource, "Mã Vị Trí");
            txtTenvitri.DataBindings.Clear();
            txtTenvitri.DataBindings.Add("Text", grvVitri.DataSource, "Tên Vị Trí");
        }

        private void loaddata()
        {
            var con = conn.connect();
            string sql = "select ID as 'Mã Vị Trí', TenViTri as 'Tên Vị Trí' from tblViTri";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            grvVitri.DataSource = dt;
        }

        private bool themvitri()
        {
            if (string.IsNullOrEmpty(txtTenvitri.Text))
            {
                MessageBox.Show("Vui lòng nhập tên vị trí việc làm!", "Lưu Ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            var con = conn.connect();
            string Check_exist_query = "SELECT TenViTri FROM tblViTri WHERE TenViTri = '" + txtTenvitri.Text + "'";
            string Insert_query = "insert into tblViTri values("+int.Parse(txtMavitri.Text)+", N'"+txtTenvitri.Text+"')";
            SqlCommand cmd = new SqlCommand(Check_exist_query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (!dr.HasRows)
            {
                dr.Close();
                cmd = new SqlCommand(Insert_query, con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    con.Close();
                    return true;
                }
            }
            con.Close();
            MessageBox.Show("Vị trí này đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void Form_ViTri_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            back();
            txtMavitri.ReadOnly = true;
            Int32 i;
            if (grvVitri.Rows.Count >= 1)
            {
                i = 1;
            }
            else
            {
                i = Convert.ToInt32(grvVitri.CurrentRow.Index);
            }
            int id = int.Parse(grvVitri.RowCount.ToString());
            txtMavitri.Text = id.ToString();
            enablecommand(false);
            kt = 1;
        }

        private bool xoavitri()
        {
            var con = conn.connect();
            string Delete_query = "Delete FROM tblViTri WHERE ID = " + txtMavitri.Text;
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand(Delete_query, con);
            if (cmd.ExecuteNonQuery() > 0)
            {
                con.Close();
                return true;
            }
            con.Close();
            return false;
        }



        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            if (kt == 1)
            {
                if (themvitri())
                {
                    MessageBox.Show("Thêm nhân viên thành công", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    enablecommand(true);
                    txtMavitri.ReadOnly = false;
                    loaddata();
                    back();
                }
                else if (MessageBox.Show("Bạn muốn dừng thêm???", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    enablecommand(true);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            binding();
            if (MessageBox.Show("Bạn thực sự muốn xóa vị trí có tên là '" +
                txtTenvitri.Text + "' không???", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                if (xoavitri())
                {
                    MessageBox.Show("Xoá vị trí có mã '" + txtTenvitri.Text + "' thành công", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            loaddata();
            back();
        }
    }
}
