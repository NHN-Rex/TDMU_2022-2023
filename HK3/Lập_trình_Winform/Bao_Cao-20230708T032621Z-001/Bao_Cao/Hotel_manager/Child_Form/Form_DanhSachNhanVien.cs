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
    public partial class Form_DanhSachNhanVien : Form
    {
        private ConnectDatabase conn = new ConnectDatabase();
        private int kt;
        public Form_DanhSachNhanVien()
        {
            InitializeComponent();
        }

        private void back()
        {
            txtIDnhanvien.Text = string.Empty;
            txtTennhanvien.Text = string.Empty;
            cbbVitri.Text = string.Empty;
            txtDiachihientai.Text = string.Empty;
            txtCCCD.Text = string.Empty;
            txtTennhanvien.Focus();
        }

        private void enablecommand(bool kt)
        {
            btnXacnhan.Enabled = !kt;
            btnThem.Enabled = kt;
            btnCapnhat.Enabled = kt;
            btnXoa.Enabled = kt;
        }

        private void binding()
        {
            Int32 i = Convert.ToInt32(grvNhanvien.CurrentRow.Index);
            txtIDnhanvien.DataBindings.Clear();
            txtIDnhanvien.DataBindings.Add("Text", grvNhanvien.DataSource, "Mã Nhân Viên");

            cbbVitri.Text = grvNhanvien.Rows[i].Cells["Vị Trí"].Value.ToString();
            txtCCCD.DataBindings.Clear();
            txtCCCD.DataBindings.Add("Text", grvNhanvien.DataSource, "CCCD/CMND");
            txtTennhanvien.DataBindings.Clear();
            txtTennhanvien.DataBindings.Add("Text", grvNhanvien.DataSource, "Tên Nhân Viên");
            txtDiachihientai.DataBindings.Clear();
            txtDiachihientai.DataBindings.Add("Text", grvNhanvien.DataSource, "Địa Chỉ Hiện Tại");
        }

        private void addcbbVitri()
        {
            DataSet dataSet = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from tblViTri";
            cmd.Connection = conn.connect();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dataSet, "ViTri");
            cbbVitri.DataSource = dataSet.Tables["ViTri"];
            cbbVitri.DisplayMember = "TenViTri";
            cbbVitri.ValueMember = "ID";
        }

        private void loaddata()
        {
            var con = conn.connect();
            string sql = "select tblNhanVien.ID as 'Mã Nhân Viên', TenNhanVien as 'Tên Nhân Viên' , CCCD as 'CCCD/CMND', DiaChiHienTai as 'Địa Chỉ Hiện Tại', TenViTri as 'Vị Trí' from tblNhanVien, tblViTri where tblViTri.ID = tblNhanVien.IDViTri";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            grvNhanvien.DataSource = dt;
        }

        private bool themnhanvien()
        {
            if (string.IsNullOrEmpty(txtTennhanvien.Text) || string.IsNullOrEmpty(txtCCCD.Text) || string.IsNullOrEmpty(txtDiachihientai.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên!", "Lưu Ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            var con = conn.connect();
            string Check_exist_query = "SELECT CCCD FROM tblNhanVien WHERE CCCD = '" + txtIDnhanvien.Text + "'";
            string Insert_query = "insert into tblNhanVien values(" + int.Parse(txtIDnhanvien.Text) + ", '" + txtTennhanvien.Text + "', '" + txtCCCD.Text + "', '" + txtDiachihientai.Text + "', " + int.Parse(cbbVitri.SelectedValue.ToString()) + ")";
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
            MessageBox.Show("CCCD của bạn bị trùng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            back();   
            if (grvNhanvien.RowCount == 1)
            {
                txtIDnhanvien.Text = "1";
            }
            else
            {
                txtIDnhanvien.Text = (int.Parse(grvNhanvien.Rows[0].Cells[0].Value.ToString()) + 1).ToString();
            }
            addcbbVitri();
            enablecommand(false);
            kt = 1;
        }

        private bool xoanhanvien()
        {
            var con = conn.connect();
            string Delete_query = "Delete FROM tblNhanVien WHERE ID = " + txtIDnhanvien.Text;
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            binding();
            if (MessageBox.Show("Bạn thực sự muốn xóa nhân viên có mã '" +
                txtIDnhanvien.Text + "' không???", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                if (xoanhanvien())
                {
                    MessageBox.Show("Xoá nhân viên có mã '" + txtIDnhanvien.Text + "' thành công", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            loaddata();
            back();
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            if (kt == 1)
            {
                if (themnhanvien())
                {
                    MessageBox.Show("Thêm nhân viên thành công", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    enablecommand(true);
                    txtIDnhanvien.ReadOnly = false;
                    loaddata();
                    back();
                }
                else if (MessageBox.Show("Bạn muốn dừng thêm???", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    enablecommand(true);
            }
            else if (kt == 2)
            {
                if (capnhat())
                {
                    MessageBox.Show("Cập nhật thông tin nhân viên thành công", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    enablecommand(true);
                    back();
                    txtCCCD.Enabled = txtIDnhanvien.Enabled = txtTennhanvien.Enabled = true;
                }
            }
        }

        private bool capnhat()
        {
            var con = conn.connect();
            string update_query = "update tblNhanVien set IDViTri = '" + int.Parse(cbbVitri.SelectedValue.ToString()) + "', DiaChiHienTai = N'" + txtDiachihientai.Text + "'" +
                "where ID = " + int.Parse(txtIDnhanvien.Text);
            SqlCommand cmd = new SqlCommand(update_query, con);
            if (cmd.ExecuteNonQuery() > 0)
            {
                con.Close();
                Int32 i = Convert.ToInt32(grvNhanvien.CurrentRow.Index);
                loaddata();
                grvNhanvien.Rows[i].Selected = true;
                return true;
            }
            return false;
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            txtCCCD.Enabled = txtIDnhanvien.Enabled = txtTennhanvien.Enabled = false;
            addcbbVitri();
            binding();
            enablecommand(false);
            kt = 2;
        }

        private void Form_DanhSachNhanVien_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDnhanvien.Text) && string.IsNullOrEmpty(txtCCCD.Text) && string.IsNullOrEmpty(txtTennhanvien.Text))
            {
                MessageBox.Show("Vui lòng nhập Thông tin nhân viên!",
                    "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var con = conn.connect();
            string sql = "select tblNhanVien.ID as 'Mã Nhân Viên', TenNhanVien as 'Tên Nhân Viên', CCCD as 'CCCD/CMND', " +
                "DiaChiHienTai as 'Địa Chỉ Hiện Tại', TenViTri as 'Vị Trí' " +
                "from tblNhanVien, tblViTri " +
                "where tblViTri.ID = tblNhanVien.IDViTri and(tblNhanVien.ID = " + int.Parse(txtIDnhanvien.Text) + " or CCCD = N'" + txtCCCD.Text + "' or TenNhanVien = N'" + txtTennhanvien.Text + "')";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            grvNhanvien.DataSource = dt;
        }

        private void Form_DanhSachNhanVien_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
