using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Hotel_manager.Child_Form
{
    public partial class Form_DanhSachThuePhong : Form
    {
        private ConnectDatabase conn = new ConnectDatabase();
        private int kt;
        int current_price;
        int single_price;
        public Form_DanhSachThuePhong()
        {
            InitializeComponent();
        }

        private void back()
        {
            txtID.Text = string.Empty;
            cbbKhachhang.Text = string.Empty;
            cbbPhong.Text = string.Empty;
            txtThoigianthue.Text = string.Empty;
            dtpNgaythue.Text = string.Empty;
            txtID.Focus();
        }

        private void enablecommand(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnThem.Enabled = kt;
            grvThuephong.ReadOnly = kt;
            btnGiahan.Enabled = kt;
        }

        private void addcbbKhachhang()
        {
            DataSet dataSet = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select HoTen, CCCD from tblKhachHang";
            cmd.Connection = conn.connect();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dataSet, "KhachHang");
            cbbKhachhang.DataSource = dataSet.Tables["KhachHang"];
            cbbKhachhang.DisplayMember = "HoTen";
            cbbKhachhang.ValueMember = "CCCD";
        }

        private void addcbbPhong()
        {
            DataSet dataSet = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select tblPhong.ID, TenPhong, DonGia, IDLoaiPhong, TrangThai, " +
                "concat_ws(' - ', IDLoaiPhong, TenPhong, FORMAT(DonGia, '#,##.')) as 'Phòng' from tblPhong, tblLoaiPhong where tblLoaiPhong.ID = tblPhong.IDLoaiPhong and tblPhong.TrangThai = N'Còn trống'";
            cmd.Connection = conn.connect();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dataSet, "Phong");
            cbbPhong.DataSource = dataSet.Tables["Phong"];
            cbbPhong.DisplayMember = "Phòng";
            cbbPhong.ValueMember = "ID";
        }

        private void loaddata()
        {
            var con = conn.connect();
            string sql = "select tblThuePhong.ID as 'Mã', TenLoaiPhong as 'Tên Loại Phòng', TenPhong as 'Tên Phòng', HoTen as 'Họ và Tên', " +
                "tblKhachHang.CCCD as 'CCCD/CMND', DienThoai as 'Số Điện Thoại', GioThue as 'Giờ Thuê', " +
                "GioTra as 'Giờ Trả', DonGia as 'Đơn Giá', GiaPhong as 'Cần Thanh Toán', tblThuePhong.TrangThai as 'Trạng Thái' " +
                "from tblLoaiPhong, tblPhong, tblKhachHang, tblThuePhong " +
                "where tblLoaiPhong.ID = tblPhong.IDLoaiPhong and tblPhong.ID = tblThuePhong.IDPhong " +
                "and tblThuePhong.CCCD = tblKhachHang.CCCD " +
                "order by tblThuePhong.ID DESC";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            grvThuephong.DataSource = dt;
        }

        private bool themthuephong()
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Vui lòng nhập ID thuê phòng!",
                    "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            string check = "";
            if (ckbTrangthai.Checked)
            {
                check = "Đã thanh toán";
            }
            else
            {
                check = "Chưa thanh toán";
            }
            string[] text = cbbPhong.Text.Split(" - ");
            int price = int.Parse(text[text.Length - 1].Replace(",", ""));
            //TimeSpan timeSpan = dtpNgaytra.Value-dtpNgaythue.Value;
            if (txtThoigianthue.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thời gian thuê!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            var con = conn.connect();
            string Check_exist_query = "SELECT tblThuePhong.ID, tblPhong.TrangThai FROM tblThuePhong, tblPhong WHERE tblThuePhong.ID = " + txtID.Text + "and tblPhong.TrangThai = N'Đang Thuê'";
            string Insert_query = "insert into tblThuePhong values" +
                "(" + int.Parse(txtID.Text) + ", '" + cbbKhachhang.SelectedValue.ToString() + "', " + int.Parse(cbbPhong.SelectedValue.ToString()) + ",'" + int.Parse(txtThoigianthue.Text) * price + "', " +
                "'" + dtpNgaythue.Value.ToString("MM/dd/yyyy HH:mm") + "', '" + dtpNgaythue.Value.AddHours(int.Parse(txtThoigianthue.Text)).ToString("MM/dd/yyyy HH:mm") + "', N'" + check + "')";
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
            MessageBox.Show("ID đã tồn tại hoặc phòng đang có người thuê!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void chuyentrangthaiphong()
        {

            var con = conn.connect();
            string check = "Còn trống";
            string check_query1 = "select IDPhong from tblThuePhong where IDPhong = " + cbbPhong.SelectedValue;
            SqlCommand cmd = new SqlCommand(check_query1, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Close();
                check = "Đang thuê";
                string update_query = "update tblPhong set tblPhong.TrangThai = N'" + check + "' from tblPhong, tblThuePhong where tblThuePhong.IDPhong = '" + cbbPhong.SelectedValue + "' and tblPhong.ID = tblThuePhong.IDPhong";
                SqlCommand cmd1 = new SqlCommand(update_query, con);
                cmd1.ExecuteNonQuery();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            back();
            if (grvThuephong.RowCount == 1)
            {
                txtID.Text = "1";
            }
            else
            {
                txtID.Text = (int.Parse(grvThuephong.Rows[0].Cells[0].Value.ToString()) + 1).ToString();
            }
            addcbbKhachhang();
            addcbbPhong();

            enablecommand(false);
            kt = 1;
            txtThoigianthue.Focus();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            txtID.ReadOnly = false;
            if (string.IsNullOrEmpty(txtID.Text) && string.IsNullOrEmpty(cbbKhachhang.Text))
            {
                MessageBox.Show("Vui lòng nhập mã thuê phòng hoặc tên khách hàng!",
                    "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var con = conn.connect();
            string find_sql = "select tblThuePhong.ID as 'Mã', TenLoaiPhong as 'Tên Loại Phòng', TenPhong as 'Tên Phòng', HoTen as 'Họ và Tên', " +
                "tblKhachHang.CCCD as 'CCCD/CMND', DienThoai as 'Số Điện Thoại', Format(cast(GioThue as datetime),'M/dd/yyy HH:mm') as 'Giờ Thuê', " +
                "Format(cast(GioTra as datetime),'M/dd/yyy HH:mm') as 'Giờ Trả', GiaPhong as 'Cần Thanh Toán', tblThuePhong.TrangThai as 'Trạng Thái' " +
                "from tblLoaiPhong, tblPhong, tblKhachHang, tblThuePhong " +
                "where tblLoaiPhong.ID = tblPhong.IDLoaiPhong and tblPhong.ID = tblThuePhong.IDPhong " +
                "and tblThuePhong.CCCD = tblKhachHang.CCCD and (tblThuePhong.ID = '" + txtID.Text + "' or tblKhachHang.HoTen = N'" + cbbKhachhang.Text + "')";
            SqlCommand cmd = new SqlCommand(find_sql, con);
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            grvThuephong.DataSource = dt;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (kt == 1)
            {
                if (themthuephong())
                {
                    MessageBox.Show("Thêm tác vụ thuê phòng thành công", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    enablecommand(true);
                    chuyentrangthaiphong();
                    addcbbPhong();
                    loaddata();
                    back();
                }
                else if (MessageBox.Show("Bạn muốn dừng thêm???", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    enablecommand(true);
            }
            else if (kt == 2)
            {
                if (giahanphong())
                {
                    MessageBox.Show("Gia hạn tác vụ thuê phòng thành công", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    enablecommand(true);
                    txtID.ReadOnly = false;
                    back();
                }
            }
        }

        private void Format_Gridview()
        {
            grvThuephong.Columns["Mã"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvThuephong.Columns["Mã"].Width = 30;
            grvThuephong.Columns["Đơn Giá"].DefaultCellStyle.Format = "N0";
            grvThuephong.Columns["Đơn Giá"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvThuephong.Columns["Cần Thanh Toán"].DefaultCellStyle.Format = "N0";
            grvThuephong.Columns["Cần Thanh Toán"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvThuephong.Columns["CCCD/CMND"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvThuephong.Columns["Giờ Thuê"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvThuephong.Columns["Giờ Trả"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvThuephong.Columns["Số Điện Thoại"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvThuephong.Columns["Giờ Thuê"].DefaultCellStyle.Format = "M/dd/yyy HH:mm tt";
            grvThuephong.Columns["Giờ Trả"].DefaultCellStyle.Format = "M/dd/yyy HH:mm tt";
        }

        private void Form_DanhSachThuePhong_Load(object sender, EventArgs e)
        {
            grvThuephong.Enabled = true;
            loaddata();
            Format_Gridview();
            dtpNgaythue.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new Form_KhachHang_Dialog();
            f.ShowDialog();
        }

        private void binding()
        {
            Int32 i = Convert.ToInt32(grvThuephong.CurrentRow.Index);
            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", grvThuephong.DataSource, "Mã");
            cbbKhachhang.DataBindings.Clear();
            //cbbKhachhang.DataBindings.Add("DisplayMember", grvThuephong.DataSource, "Họ và Tên");

            cbbKhachhang.Text = grvThuephong.Rows[i].Cells["Họ và Tên"].Value.ToString();
            cbbPhong.DataBindings.Clear();
            cbbPhong.Text = grvThuephong.Rows[i].Cells["Tên Phòng"].Value.ToString() + " - " + grvThuephong.Rows[i].Cells["Tên Loại Phòng"].Value.ToString();
            dtpNgaythue.DataBindings.Clear();
            dtpNgaythue.Value = DateTime.Now;
            if (grvThuephong.Rows[i].Cells["Trạng Thái"].Value.ToString() == "Đã thanh toán")
            {
                ckbTrangthai.Checked = true;
            }
            else
            {
                ckbTrangthai.Checked = false;
            }
        }

        private bool checkthanhtoan()
        {

            current_price = 0;
            single_price = 0;
            Int32 i = Convert.ToInt32(grvThuephong.CurrentRow.Index);
            single_price += int.Parse(grvThuephong.Rows[i].Cells["Đơn Giá"].Value.ToString());
            if (grvThuephong.Rows[i].Cells["Trạng Thái"].Value.ToString() == "Chưa thanh toán")
            {
                MessageBox.Show("Chưa thanh toán đợt vừa rồi.!!!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                current_price += int.Parse(grvThuephong.Rows[i].Cells["Cần Thanh Toán"].Value.ToString());
                return true;
            }
            return false;
        }

        private bool giahanphong()
        {
            var con = conn.connect();
            if (checkthanhtoan())
            {
                int tt = current_price + (int.Parse(txtThoigianthue.Text) * single_price);
                string update_query = "update tblThuePhong set GioThue = '" + dtpNgaythue.Value.ToString() + "', GioTra = '" + dtpNgaythue.Value.AddHours(int.Parse(txtThoigianthue.Text)).ToString() + "'" +
                    ", GiaPhong = " + tt +
                    " where ID = '" + txtID.Text + "'";
                SqlCommand cmd = new SqlCommand(update_query, con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    con.Close();
                    Int32 i = Convert.ToInt32(grvThuephong.CurrentRow.Index);
                    loaddata();
                    grvThuephong.Rows[i].Selected = true;
                    return true;
                }
            }
            return false;
        }

        private void btnGiahan_Click(object sender, EventArgs e)
        {
            txtID.ReadOnly = true;

            enablecommand(false);
            binding();
            kt = 2;
        }

        private void dtpNgaythue_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
