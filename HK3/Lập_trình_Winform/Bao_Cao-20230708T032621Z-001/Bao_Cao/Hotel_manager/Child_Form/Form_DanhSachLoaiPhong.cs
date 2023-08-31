using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_manager.Child_Form
{
    public partial class Form_DanhSachLoaiPhong : Form
    {
        private ConnectDatabase conn = new ConnectDatabase();
        private int kt;

        public Form_DanhSachLoaiPhong()
        {
            InitializeComponent();
        }
        private void back()
        {
            txtTenloaiphong.Text = string.Empty;
            txtKichthuoc.Text = string.Empty;
            txtMaloaiphong.Text = string.Empty;
            txtDongia.Text = "0";
            txtMaloaiphong.Focus();
        }

        private void enablecommand(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnCapnhat.Enabled = kt;
            btnThem.Enabled = kt;
            btnXoa.Enabled = kt;
            grvLoaiPhong.ReadOnly = kt;
            //Form_LoaiPhong.ac
        }

        private void load_LoaiPhong()
        {

            var con = conn.connect();
            string sql = "Select ID as 'Mã Loại Phòng', TenLoaiPhong as 'Tên Loại Phòng', KichThuoc as" +
                "'Kích Thước (người)', DonGia as 'Đơn Giá'  from tblLoaiPhong";
            SqlCommand com = new SqlCommand(sql, con);
            com.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            con.Close();
            grvLoaiPhong.DataSource = dt;
        }

        private void Form_LoaiPhong_Load(object sender, EventArgs e)
        {
            load_LoaiPhong();
            grvLoaiPhong.Columns["Đơn Giá"].DefaultCellStyle.Format = "N0";
        }

        private bool themphong()
        {
            if (string.IsNullOrEmpty(txtMaloaiphong.Text))
            {
                MessageBox.Show("Vui lòng nhập mã loại phòng!",
                    "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (int.Parse(txtDongia.Text) < 500000)
            {
                MessageBox.Show("Đơn giá thấp nhất là 500,000",
                    "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            var con = conn.connect();
            string Check_exist_query = "SELECT ID FROM tblLoaiPhong WHERE ID = '" + txtMaloaiphong.Text + "'";
            string Insert_query = "insert into tblLoaiPhong values" +
                "(N'" + txtMaloaiphong.Text + "',N'" + txtTenloaiphong.Text + "',N'" + txtKichthuoc.Text + "', N'" + txtDongia.Text + "')";
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

        private void tbnThem_Click(object sender, EventArgs e)
        {
            back();
            enablecommand(false);
            kt = 1;

        }

        private bool xoaloaiphong()
        {
            var con = conn.connect();
            string Check_exist_query = "SELECT ID FROM tblLoaiPhong WHERE ID = '" + txtMaloaiphong.Text + "'";
            string Delete_query = "DELETE FROM tblLoaiPhong WHERE ID = '" + txtMaloaiphong.Text + "'";
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
            MessageBox.Show("Mã loại phòng không tồn tại", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            con.Close();
            return false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            binding();
            if (MessageBox.Show("Bạn thực sự muốn xóa loại phòng có mã '" +
                txtMaloaiphong.Text + "' không???", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                if (xoaloaiphong())
                    MessageBox.Show("Xoá loại phòng thành công", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            load_LoaiPhong();
            back();
        }

        private void binding()
        {
            txtMaloaiphong.DataBindings.Clear();
            txtMaloaiphong.DataBindings.Add("Text", grvLoaiPhong.DataSource, "Mã Loại Phòng");
            txtTenloaiphong.DataBindings.Clear();
            txtTenloaiphong.DataBindings.Add("Text", grvLoaiPhong.DataSource, "Tên Loại Phòng");
            txtKichthuoc.DataBindings.Clear();
            txtKichthuoc.DataBindings.Add("Text", grvLoaiPhong.DataSource, "Kích Thước (người)");
            txtDongia.DataBindings.Clear();
            txtDongia.DataBindings.Add("Text", grvLoaiPhong.DataSource, "Đơn Giá");
            txtMaloaiphong.Focus();
        }

        private bool capnhat()
        {
            var con = conn.connect();
            string Update_query = "UPDATE tblLoaiPhong SET ID = '" + txtMaloaiphong.Text +
                "', TenLoaiPhong = N'" + txtTenloaiphong.Text + "', KichThuoc = '" +
                txtKichthuoc.Text + "', DonGia = '" + txtDongia.Text + "'" +
                "WHERE ID = '" + txtMaloaiphong.Text + "'";
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
            grvLoaiPhong.Enabled = false;
            txtMaloaiphong.ReadOnly = true;
            enablecommand(false);
            kt = 2;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (kt == 1)
            {
                if (themphong())
                {
                    MessageBox.Show("Thêm phòng thành công", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    enablecommand(true);
                    load_LoaiPhong();
                    back();
                }
                else if (MessageBox.Show("Bạn muốn dừng thêm???", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    enablecommand(true);
            }
            else if (kt == 2)
            {
                if (capnhat())
                {
                    MessageBox.Show("Cập nhật phòng thành công", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    enablecommand(true);
                    txtMaloaiphong.ReadOnly = false;
                    load_LoaiPhong();
                    grvLoaiPhong.Enabled = true;
                    back();
                }
            }
        }

        private void grvLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            back();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaloaiphong.Text) && string.IsNullOrEmpty(txtTenloaiphong.Text))
            {
                MessageBox.Show("Vui lòng nhập mã loại phòng hoặc tên loại phòng!",
                    "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var con = conn.connect();
            string sql = "Select ID as 'Mã Loại Phòng', TenLoaiPhong as 'Tên Loại Phòng'" +
                "FROM tblLoaiPhong where ID = '" + txtMaloaiphong.Text + "' or TenLoaiPhong = N'" + txtTenloaiphong.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            grvLoaiPhong.DataSource = dt;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
