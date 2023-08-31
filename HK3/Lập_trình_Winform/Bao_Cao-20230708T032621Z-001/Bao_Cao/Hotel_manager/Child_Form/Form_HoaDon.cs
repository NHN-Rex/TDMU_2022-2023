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

namespace Hotel_manager.Child_Form
{
    public partial class Form_HoaDon : Form
    {
        private ConnectDatabase conn = new ConnectDatabase();
        public Form_HoaDon()
        {
            InitializeComponent();
        }

        private void loadalldata()
        {
            var con = conn.connect();
            string sql = "select tblHoaDon.ID as 'Mã', TenLoaiPhong as 'Tên Loại Phòng', TenPhong as 'Tên Phòng', HoTen as 'Họ và Tên', " +
                "tblKhachHang.CCCD as 'CCCD/CMND', DienThoai as 'Số Điện Thoại', GioThue as 'Giờ Thuê', " +
                "GioTra as 'Giờ Trả', DonGia as 'Đơn Giá', GiaPhong as 'Cần Thanh Toán', tblHoaDon.TrangThai as 'Trạng Thái' " +
                "from tblLoaiPhong, tblPhong, tblKhachHang, tblHoaDon " +
                "where tblLoaiPhong.ID = tblPhong.IDLoaiPhong and tblPhong.ID = tblHoaDon.IDPhong " +
                "and tblHoaDon.CCCD_KH = tblKhachHang.CCCD " +
                "order by tblHoaDon.ID DESC";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            grvHoaDon.DataSource = dt;
        }

        private void loadadata()
        {
            var con = conn.connect();
            string sql = "select tblHoaDon.ID as 'Mã', TenLoaiPhong as 'Tên Loại Phòng', TenPhong as 'Tên Phòng', HoTen as 'Họ và Tên', " +
                "tblKhachHang.CCCD as 'CCCD/CMND', DienThoai as 'Số Điện Thoại', Convert(nvarchar, GioThue, 101) as 'Giờ Thuê', " +
                "Convert(nvarchar, GioTra, 101) as 'Giờ Trả',CONVERT(nvarchar, tblHoaDon.GioThue, 101) as 'Ngày', DonGia as 'Đơn Giá', GiaPhong as 'Cần Thanh Toán', tblHoaDon.TrangThai as 'Trạng Thái' " +
                "from tblLoaiPhong, tblPhong, tblKhachHang, tblHoaDon " +
                "where tblLoaiPhong.ID = tblPhong.IDLoaiPhong and tblPhong.ID = tblHoaDon.IDPhong and tblHoaDon.CCCD_KH = tblKhachHang.CCCD " +
                "and tblHoaDon.CCCD_KH = tblKhachHang.CCCD " +
                "and SUBSTRING(GioThue, 1, 10) >= '" + dtpTuNgay.Value.ToString("MM/dd/yyyy") + "' " +
                "and SUBSTRING(GioTra, 1, 10) <= '" + dtpToingay.Value.ToString("MM/dd/yyyy") + "' " +
                "order by tblHoaDon.ID DESC";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            grvHoaDon.DataSource = dt;
        }

        private ulong tinhtongdoanhthu()
        {
            ulong s = 0;

            for (int i = 0; i < grvHoaDon.RowCount - 1; i++)
            {
                //MessageBox.Show(dtpTuNgay.Value.ToString().Split(" ")[0] + "\n"+grvHoaDon.Rows[i].Cells["Giờ Thuê"].Value.ToString().Split(" ")[0]);
                s += ulong.Parse(grvHoaDon.Rows[i].Cells["Cần Thanh Toán"].Value.ToString());
            }
            return s;
        }

        private void Form_HoaDon_Load(object sender, EventArgs e)
        {

            loadalldata();
            lbTongdoanhthu.Text = string.Format("{0:0,00}", tinhtongdoanhthu());
            grvHoaDon.Columns["Cần Thanh Toán"].DefaultCellStyle.Format = "N0";
            grvHoaDon.Columns["Cần Thanh Toán"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            loadadata();
            lbTongdoanhthu.Text = string.Format("{0:0,00}", tinhtongdoanhthu());
        }

        private void Form_HoaDon_Click(object sender, EventArgs e)
        {
            lbTongdoanhthu.Text = string.Format("{0:0,00}", tinhtongdoanhthu());
            loadalldata();
        }
    }
}
