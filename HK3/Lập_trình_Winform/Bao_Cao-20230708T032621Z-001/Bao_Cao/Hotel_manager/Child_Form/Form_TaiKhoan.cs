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
    public partial class Form_TaiKhoan : Form
    {
        private ConnectDatabase conn = new ConnectDatabase();
        private int kt;

        private void back()
        {
            txtTendangnhap.Text = string.Empty;
            txtMatkhau.Text = string.Empty;
            cbbVitri.Text = string.Empty;
            txtTendangnhap.Focus();
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
            Int32 i = Convert.ToInt32(grvTaikhoan.CurrentRow.Index);
            txtTendangnhap.DataBindings.Clear();
            txtTendangnhap.DataBindings.Add("Text", grvTaikhoan.DataSource, "Tên Đăng Nhập");

            cbbVitri.Text = grvTaikhoan.Rows[i].Cells["Vị Trí"].Value.ToString();

            txtMatkhau.DataBindings.Clear();
            txtMatkhau.DataBindings.Add("Text", grvTaikhoan.DataSource, "Mật Khẩu");
            txtIDtaikhoan.DataBindings.Clear();
            txtIDtaikhoan.DataBindings.Add("Text", grvTaikhoan.DataSource, "Mã Tài Khoản");
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
            string sql = "select tblTaiKhoan.ID as 'Mã Tài Khoản',TenNhanVien as 'Tên Nhân Viên', TaiKhoan as 'Tên Đăng Nhập', " +
                "CONVERT(VARCHAR(10), HashBytes('MD5', MatKhau)) as 'Mật Khẩu', TenViTri as 'Vị Trí' " +
                "from tblTaiKhoan, tblViTri, tblNhanVien " +
                "where tblViTri.ID = tblTaiKhoan.IDViTri and tblNhanVien.ID = tblTaiKhoan.IDNV " +
                "order by tblTaiKhoan.ID DESC";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            grvTaikhoan.DataSource = dt;
        }

        private bool themtaikhoan()
        {
            if (string.IsNullOrEmpty(txtTendangnhap.Text) || string.IsNullOrEmpty(txtMatkhau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản!", "Lưu Ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            var con = conn.connect();
            string Check_exist_query = "SELECT TaiKhoan FROM tblTaiKhoan WHERE TaiKhoan = '" + txtTendangnhap.Text + "'";
            string Insert_query = "insert into tblTaiKhoan values(" + int.Parse(txtIDtaikhoan.Text) + ",'" + txtTendangnhap.Text + "', '" + txtMatkhau.Text + "', " + int.Parse(cbbVitri.SelectedValue.ToString()) + ")";
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
            MessageBox.Show("Tên tài khoản đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            addcbbVitri();
            back();
            Int32 i;
            if (grvTaikhoan.RowCount == 1)
            {
                txtIDtaikhoan.Text = "1";
                Const.idtaikhoan = 1;
            }
            else
            {
                txtIDtaikhoan.Text = (int.Parse(grvTaikhoan.Rows[0].Cells[0].Value.ToString()) + 1).ToString();
                Const.idtaikhoan = (int.Parse(grvTaikhoan.Rows[0].Cells[0].Value.ToString()) + 1);
            }
            int id = int.Parse(grvTaikhoan.RowCount.ToString());
            txtIDtaikhoan.Text = id.ToString();
            enablecommand(false);
            kt = 1;
            var f = new Form_ThemTaiKhoan();
            f.ShowDialog();
        }

        private bool xoataikhoan()
        {
            var con = conn.connect();
            string Delete_query = "Delete FROM tblTaiKhoan WHERE ID = " + int.Parse(txtIDtaikhoan.Text);
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
            if (MessageBox.Show("Bạn thực sự muốn xóa tài khoản có mã '" +
                txtIDtaikhoan.Text + "' không???", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                if (xoataikhoan())
                {
                    MessageBox.Show("Xoá tài khoản có mã '" + txtIDtaikhoan.Text + "' thành công", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            loaddata();
            back();
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            if (kt == 1)
            {
                if (themtaikhoan())
                {
                    MessageBox.Show("Thêm tài khoản thành công", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    enablecommand(true);
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
                    MessageBox.Show("Cập nhật thông tin tài khoản thành công", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    enablecommand(true);
                    back();
                    txtIDtaikhoan.Enabled = txtTendangnhap.Enabled = true;
                }
            }
        }

        private bool capnhat()
        {
            var con = conn.connect();
            string update_query = "update tblTaiKhoan set IDViTri = '" + int.Parse(cbbVitri.SelectedValue.ToString()) + "', MatKhau = '" + txtMatkhau.Text + "'" +
                "where ID = " + int.Parse(txtIDtaikhoan.Text);
            SqlCommand cmd = new SqlCommand(update_query, con);
            if (cmd.ExecuteNonQuery() > 0)
            {
                con.Close();
                Int32 i = Convert.ToInt32(grvTaikhoan.CurrentRow.Index);
                loaddata();
                grvTaikhoan.Rows[i].Selected = true;
                return true;
            }
            return false;
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            txtIDtaikhoan.Enabled = txtTendangnhap.Enabled = false;
            addcbbVitri();
            binding();
            enablecommand(false);
            kt = 2;
        }
        public Form_TaiKhoan()
        {
            InitializeComponent();
        }

        private void Form_TaiKhoan_Load(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}
