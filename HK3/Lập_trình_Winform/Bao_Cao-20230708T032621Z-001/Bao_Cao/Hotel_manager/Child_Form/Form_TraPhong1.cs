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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;


namespace Hotel_manager.Child_Form
{
    public partial class Form_TraPhong1 : Form
    {

        private ConnectDatabase conn = new ConnectDatabase();
        private DataSet ds = new DataSet();
        private int kt;
        public Form_TraPhong1()
        {
            InitializeComponent();
        }
        private void binding()
        {
            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", grvThuephong.DataSource, "Mã");
            txtKhachhang.DataBindings.Clear();
            txtKhachhang.DataBindings.Add("Text", grvThuephong.DataSource, "Họ và Tên");
            txtTenphong.DataBindings.Clear();
            txtTenphong.DataBindings.Add("Text", grvThuephong.DataSource, "Phòng");
            txtTenloaiphong.DataBindings.Clear();
            txtTenloaiphong.DataBindings.Add("Text", grvThuephong.DataSource, "Tên Loại Phòng");
            txtNgaythue.DataBindings.Clear();
            txtNgaythue.DataBindings.Add("Text", grvThuephong.DataSource, "Giờ Thuê");
            txtNgaytra.DataBindings.Clear();
            txtNgaytra.DataBindings.Add("Text", grvThuephong.DataSource, "Giờ Trả");
            Int32 i = Convert.ToInt32(grvThuephong.CurrentRow.Index);
            if (grvThuephong.Rows[i].Cells["Trạng Thái"].Value.ToString() == "Đã thanh toán")
            {
                ckbTrangthai.Checked = true;
            }
            else
            {
                ckbTrangthai.Checked = false;
            }
            txtSotienthanhtoan.DataBindings.Clear();
            txtSotienthanhtoan.DataBindings.Add("Text", grvThuephong.DataSource, "Cần Thanh Toán");


        }

        private void loaddata()
        {
            var con = conn.connect();
            string sql = "select tblThuePhong.ID as 'Mã', TenLoaiPhong as 'Tên Loại Phòng', concat_ws(' - ', IDPhong, TenPhong) as 'Phòng', HoTen as 'Họ và Tên', " +
                "tblKhachHang.CCCD as 'CCCD/CMND', DienThoai as 'Số Điện Thoại', Format(cast(GioThue as datetime),'M/dd/yyy HH:mm') as 'Giờ Thuê', " +
                "Format(cast(GioTra as datetime),'M/dd/yyy HH:mm') as 'Giờ Trả', GiaPhong as 'Cần Thanh Toán', tblThuePhong.TrangThai as 'Trạng Thái' " +
                "from tblLoaiPhong, tblPhong, tblKhachHang, tblThuePhong " +
                "where tblLoaiPhong.ID = tblPhong.IDLoaiPhong and tblPhong.ID = tblThuePhong.IDPhong and tblThuePhong.CCCD = tblKhachHang.CCCD ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            grvThuephong.DataSource = dt;
        }

        private void Format_Gridview()
        {
            grvThuephong.Columns["Mã"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvThuephong.Columns["Mã"].Width = 25;
            grvThuephong.Columns["Cần Thanh Toán"].DefaultCellStyle.Format = "N0";
            grvThuephong.Columns["Cần Thanh Toán"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvThuephong.Columns["CCCD/CMND"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvThuephong.Columns["Giờ Thuê"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvThuephong.Columns["Giờ Thuê"].DefaultCellStyle.Format = "M/dd/yyy HH:mm tt";
            grvThuephong.Columns["Giờ Trả"].DefaultCellStyle.Format = "M/dd/yyy HH:mm tt";
            grvThuephong.Columns["Giờ Trả"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvThuephong.Columns["Số Điện Thoại"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void Form_TraPhong1_Load(object sender, EventArgs e)
        {
            loaddata();
            Format_Gridview();
        }
        private void enablecommand(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnTraphong.Enabled = kt;
            //Form_LoaiPhong.ac
        }

        private bool check_traphong()
        {
            Int32 i = Convert.ToInt32(grvThuephong.CurrentRow.Index);
            if (grvThuephong.Rows[i].Cells["Trạng Thái"].Value.ToString() == "Chưa thanh toán")
            {
                return false;
            }
            return true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (kt == 1)
            {
                if (MessageBox.Show("Bạn thực sự muốn trả phòng có tên là '" + txtTenphong.Text + "' không???", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (check_traphong())
                    {
                        MessageBox.Show("Trả phòng hoàng tất!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        xoathuephong();
                        Form_TraPhong1_Load(sender, e);
                        enablecommand(true);
                    }
                }
            }
        }

        private void btnTraphong_Click(object sender, EventArgs e)
        {
            /*binding();
            kt = 1;*/

            binding();
            if (!check_traphong())
            {
                Const.tenkhachhang = txtKhachhang.Text;
                Const.tenphong = txtTenphong.Text;
                Const.sotiencanthanhtoan = txtSotienthanhtoan.Text;
                Const.ngaythanhtoan = txtNgaytra.Text;
                var f = new Form_ThanhToan();
                f.ShowDialog();
                if (Const.check)
                {
                    thanhtoan();
                    Const.check = false;
                }
                Format_Gridview();
            }
            if (Const.tatnutluu)
                enablecommand(false);
            kt = 1;
        }
        private void chuyentrangthaiphong()
        {
            string[] tt = txtTenphong.Text.Split(" - ");
            int idphong = int.Parse(tt[0]);
            var con = conn.connect();
            string check = "Còn trống";
            string check_query1 = "select IDPhong from tblThuePhong where IDPhong = " + idphong;
            SqlCommand cmd = new SqlCommand(check_query1, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Close();
                check = "Đang thuê";
                string update_query = "update tblPhong set tblPhong.TrangThai = N'" + check + "' from tblPhong where tblPhong.ID = " + idphong;
                SqlCommand cmd1 = new SqlCommand(update_query, con);
                cmd1.ExecuteNonQuery();
            }
            else
            {
                dr.Close();
                string update_query = "update tblPhong set tblPhong.TrangThai = N'" + check + "' from tblPhong where tblPhong.ID = " + idphong;
                SqlCommand cmd1 = new SqlCommand(update_query, con);
                cmd1.ExecuteNonQuery();
            }
        }
        private void xoathuephong()
        {
            var con = conn.connect();

            string into_query = "insert into tblHoaDon " +
                "select * from tblThuePhong " +
                "where tblThuePhong.TrangThai = N'Đã thanh toán' and tblThuePhong.ID = " + int.Parse(txtID.Text);
            SqlCommand cmd = new SqlCommand(into_query, con); cmd.ExecuteNonQuery();
            string delete_query = "Delete from tblThuePhong where TrangThai = N'Đã thanh toán' and ID = '" + txtID.Text + "'";
            SqlCommand cmd1 = new SqlCommand(delete_query, con);
            if (cmd1.ExecuteNonQuery() >= 0)
            {
                chuyentrangthaiphong();
            }
        }

        private void thanhtoan()
        {
            if (MessageBox.Show("Bạn muốn thanh toán phòng có tên là '" + txtTenphong.Text.Split(" - ")[1] + "'?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var con = conn.connect();
                string check = "Chưa thanh toán";
                Int32 i = Convert.ToInt32(grvThuephong.CurrentRow.Index);
                if (grvThuephong.Rows[i].Cells["Trạng Thái"].Value.ToString() == "Chưa thanh toán")
                {
                    check = "Đã thanh toán";
                    string update_query = "update tblThuePhong set TrangThai = N'" + check + "' where ID = '" + txtID.Text + "'";
                    SqlCommand cmd1 = new SqlCommand(update_query, con);
                    cmd1.ExecuteNonQuery();
                }
                loaddata();
                grvThuephong.Rows[i].Cells["Trạng Thái"].Selected = true;
                binding();
            }

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text) && string.IsNullOrEmpty(txtKhachhang.Text))
            {
                MessageBox.Show("Vui lòng nhập mã thuê phòng hoặc tên khách hàng!",
                    "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var con = conn.connect();
            string find_sql = "select tblThuePhong.ID as 'Mã', TenLoaiPhong as 'Tên Loại Phòng', TenPhong as 'Tên Phòng', HoTen as 'Họ và Tên', " +
                "tblKhachHang.CCCD as 'CCCD/CMND', DienThoai as 'Số Điện Thoại', Convert(varchar, GioThue, 103) as 'Giờ Thuê', " +
                "Convert(varchar, GioTra,103) as 'Giờ Trả', GiaPhong as 'Giá Thuê', tblThuePhong.TrangThai as 'Trạng Thái' " +
                "from tblLoaiPhong, tblPhong, tblKhachHang, tblThuePhong " +
                "where tblLoaiPhong.ID = tblPhong.IDLoaiPhong and tblPhong.ID = tblThuePhong.IDPhong " +
                "and tblThuePhong.CCCD = tblKhachHang.CCCD and (tblThuePhong.ID = '" + txtID.Text + "' or tblKhachHang.HoTen = N'" + txtKhachhang.Text + "')";
            SqlCommand cmd = new SqlCommand(find_sql, con);
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            grvThuephong.DataSource = dt;
        }
    }
}
