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
    public partial class Form_DanhSachKhachThuePhong : Form
    {
        private ConnectDatabase conn = new ConnectDatabase();
        private DataSet ds = new DataSet();
        private int kt;
        private void back()
        {
            txtHovaten.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtCCCD.Text = string.Empty;
            txtQueQuan.Text = string.Empty;
            txtHKTT.Text = string.Empty;
            txtHovaten.Focus();
        }

        private void enablecommand(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnCapnhat.Enabled = kt;
            btnThem.Enabled = kt;
            btnXoa.Enabled = kt;
            grvKhachthuephong.ReadOnly = kt;
            //Form_LoaiPhong.ac
        }

        private void loaddata()
        {
            var con = conn.connect();
            string sql = "Select HoTen as 'Họ và Tên', CCCD as 'CCCD/CMND', DienThoai as 'Số Điện Thoại'" +
                ", QueQuan as 'Quê Quán', HKTT as 'Hộ Khẩu Thường Trú'" +
                "FROM tblKhachHang";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            grvKhachthuephong.DataSource = dt;
        }

        private void binding()
        {
            txtHovaten.DataBindings.Clear();
            txtHovaten.DataBindings.Add("Text", grvKhachthuephong.DataSource, "Họ và Tên");
            txtCCCD.DataBindings.Clear();
            txtCCCD.DataBindings.Add("Text", grvKhachthuephong.DataSource, "CCCD/CMND");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", grvKhachthuephong.DataSource, "Số Điện Thoại");
            txtQueQuan.DataBindings.Clear();
            txtQueQuan.DataBindings.Add("Text", grvKhachthuephong.DataSource, "Quê Quán");
            txtHKTT.DataBindings.Clear();
            txtHKTT.DataBindings.Add("Text", grvKhachthuephong.DataSource, "Hộ Khẩu Thường Trú");
        }

        private bool themkhachhang()
        {
            if (string.IsNullOrEmpty(txtHovaten.Text))
            {
                MessageBox.Show("Vui lòng nhập họ khách hàng!",
                    "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            var con = conn.connect();
            //MessageBox.Show(cbbLoaiphong.SelectedValue.ToString());
            string Check_exist_query = "SELECT CCCD FROM tblKhachHang WHERE CCCD = " + txtCCCD.Text;
            string Insert_query = "insert into tblKhachHang values" +
                "(N'" + txtHovaten.Text + "', '" + txtCCCD.Text + "', '" + txtSDT.Text + "', N'" + txtQueQuan.Text + "', N'" + txtHKTT.Text + "')";
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
            MessageBox.Show("CCCD/CMND bị trùng!", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            back();
            enablecommand(false);
            kt = 1;
        }

        private bool xoakhachhang()
        {
            if (string.IsNullOrEmpty(txtCCCD.Text))
            {
                MessageBox.Show("Vui lòng nhập CCCD/CMND khách hàng!",
                    "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            var con = conn.connect();
            string Check_exist_query = "SELECT CCCD FROM tblKhachHang WHERE CCCD = '" + txtCCCD.Text + "'";
            string Delete_query = "Delete from tblKhachHang where CCCD = '" + txtCCCD.Text + "'";
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
            MessageBox.Show("CCCD/CMND không tồn tại!", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            binding();
            if (MessageBox.Show("Bạn thực sự muốn xóa khách hàng có CCCD/CMND là '" +
                txtCCCD.Text + "' không???", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                if (xoakhachhang())
                {
                    MessageBox.Show("Xoá khách hàng công", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            loaddata();
            back();
        }

        private bool capnhat()
        {
            txtHovaten.Enabled = false;
            var con = conn.connect();
            string Update_query = "UPDATE tblKhachHang SET DienThoai = N'" + txtSDT.Text + "', QueQuan = N'" + txtQueQuan.Text + "',HKTT = N'" + txtHKTT.Text + "' WHERE CCCD = '" + txtCCCD.Text + "'";
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
            grvKhachthuephong.Enabled = false;
            txtCCCD.ReadOnly = true;
            enablecommand(false);
            kt = 2;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (kt == 1)
            {
                if (themkhachhang())
                {
                    MessageBox.Show("Thêm khách hàng thành công", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("Cập nhật khách hàng thành công", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    enablecommand(true);
                    txtCCCD.ReadOnly = false;
                    loaddata();
                    grvKhachthuephong.Enabled = true;
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
            if (string.IsNullOrEmpty(txtCCCD.Text))
            {
                MessageBox.Show("Vui lòng nhập CCCD/CMND khách hàng!",
                    "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var con = conn.connect();
            string sql = "Select HoTen as 'Họ và Tên', CCCD as 'CCCD/CMND', DienThoai as 'Số Điện Thoại', QueQuan as 'Quê Quán', HKTT as 'Hộ Khẩu Thường Trú' FROM tblKhachHang where CCCD = '" + txtCCCD.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            grvKhachthuephong.DataSource = dt;
        }
        public Form_DanhSachKhachThuePhong()
        {
            InitializeComponent();
        }

        private void Form_KhachThuePhong_Load(object sender, EventArgs e)
        {
            loaddata();
            back();
        }
    }
}
