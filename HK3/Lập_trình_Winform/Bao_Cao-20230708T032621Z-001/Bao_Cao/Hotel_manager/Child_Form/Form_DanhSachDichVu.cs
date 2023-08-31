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
    public partial class Form_DanhSachDichVu : Form
    {
        private ConnectDatabase conn = new ConnectDatabase();
        private DataSet ds = new DataSet();
        private int kt;
        public Form_DanhSachDichVu()
        {
            InitializeComponent();
        }
        private void back()
        {
            txtTendichvu.Text = string.Empty;
            txtMadichvu.Text = string.Empty;
            txtMadichvu.Focus();
        }

        private void enablecommand(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnCapnhat.Enabled = kt;
            btnThem.Enabled = kt;
            btnXoa.Enabled = kt;
            grvDichvu.ReadOnly = kt;
            //Form_LoaiPhong.ac
        }

        private void loaddata()
        {
            var con = conn.connect();
            string sql = "Select ID as 'Mã Dịch Vụ', TenDichVu as 'Tên Dịch Vụ', DonGia as 'Đơn Giá' " +
                "FROM tblDichVu";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            grvDichvu.DataSource = dt;
        }

        private void binding()
        {
            txtTendichvu.DataBindings.Clear();
            txtTendichvu.DataBindings.Add("Text", grvDichvu.DataSource, "Tên Dịch Vụ");
            txtMadichvu.DataBindings.Clear();
            txtMadichvu.DataBindings.Add("Text", grvDichvu.DataSource, "Mã Dịch Vụ");
        }

        private bool themdichvu()
        {
            
            if (string.IsNullOrEmpty(txtTendichvu.Text))
            {
                MessageBox.Show("Vui lòng nhập tên dịch vụ!",
                    "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            var con = conn.connect();
            //MessageBox.Show(cbbLoaiphong.SelectedValue.ToString());
            string Check_exist_query = "SELECT ID FROM tblDichVu WHERE ID = " + txtMadichvu.Text;
            string Insert_query = "insert into tblDichVu values" +
                "(" + txtMadichvu.Text + ", N'" + txtTendichvu.Text + "', "+txtDongia.Text+")";
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
            MessageBox.Show("ID đã tồn tại", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMadichvu.Enabled = false;
            back();
            txtMadichvu.Text = grvDichvu.RowCount.ToString();
            txtTendichvu.Focus();
            enablecommand(false);
            kt = 1;
        }

        private bool xoadichvu()
        {
            if (string.IsNullOrEmpty(txtMadichvu.Text))
            {
                MessageBox.Show("Vui lòng nhập mã dịch vụ!",
                    "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            var con = conn.connect();
            string Check_exist_query = "SELECT * FROM tblDichVu WHERE ID = " + txtMadichvu.Text;
            string Delete_query = "Delete from tblDichVu where ID = " + txtMadichvu.Text;
            SqlCommand cmd = new SqlCommand(Check_exist_query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Close();
                cmd = new SqlCommand(Delete_query, con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    con.Close();
                    return true;
                }
            }
            con.Close();
            MessageBox.Show("ID Không tồn tại!", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            binding();
            if (MessageBox.Show("Bạn thực sự muốn xóa dịch vụ có mã '" +
                txtMadichvu.Text + "' không???", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                if (xoadichvu())
                {
                    MessageBox.Show("Xoá dịch vụ thành công", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            loaddata();
            back();
        }

        private bool capnhat()
        {
            var con = conn.connect();
            string Update_query = "UPDATE tblDichVu SET ID = '" + txtMadichvu.Text +
                "', TenDichVu = N'" + txtTendichvu.Text + ", DonGia = " + txtDongia.Text+
                "' WHERE ID = " + txtMadichvu.Text;
            SqlCommand cmd = new SqlCommand(Update_query, con);
            if (cmd.ExecuteNonQuery() > 0)
            {
                con.Close();
                return true;
            }
            con.Close();
            return false;
        }
        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            binding();
            grvDichvu.Enabled = false;
            txtMadichvu.ReadOnly = true;
            enablecommand(false);
            kt = 2;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (kt == 1)
            {
                if (themdichvu())
                {
                    MessageBox.Show("Thêm phòng thành công", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    enablecommand(true);
                    loaddata();
                    back();
                }
                else if (MessageBox.Show("Bạn muốn dừng thêm???", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    enablecommand(true);
                    txtMadichvu.Enabled = true;
                    back();
                }
            }
            else if (kt == 2)
            {
                if (capnhat())
                {
                    MessageBox.Show("Cập nhật phòng thành công", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    enablecommand(true);
                    txtMadichvu.ReadOnly = false;
                    loaddata();
                    grvDichvu.Enabled = true;
                    back();
                }
            }
        }
        private void grvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            back();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMadichvu.Text) && string.IsNullOrEmpty(txtTendichvu.Text))
            {
                MessageBox.Show("Vui lòng nhập mã hoặc tên dịch vụ!",
                    "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMadichvu.Focus();
                return;
            }
            var con = conn.connect();
            string sql = "Select ID as 'Mã Dịch Vụ', TenDichVu as 'Tên Dịch Vụ', DonGia as 'Đơn Giá'" +
                "FROM tblDichVu where ID = '" + txtMadichvu.Text + "' or TenDichVu = N'" + txtTendichvu.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            grvDichvu.DataSource = dt;
        }


        private void Form_DichVu_Load(object sender, EventArgs e)
        {
            loaddata();
            grvDichvu.Columns["Đơn Giá"].DefaultCellStyle.Format = "N0";
            grvDichvu.Columns["Đơn Giá"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
