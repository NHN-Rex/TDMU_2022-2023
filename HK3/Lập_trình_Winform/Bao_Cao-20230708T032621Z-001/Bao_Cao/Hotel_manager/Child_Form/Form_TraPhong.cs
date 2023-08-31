using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_manager.Child_Form
{
    public partial class Form_TraPhong : Form
    {
        private ConnectDatabase conn = new ConnectDatabase();
        private DataSet ds = new DataSet();
        public Form_TraPhong()
        {
            InitializeComponent();
        }
        private void loaddata()
        {
            var con = conn.connect();
            string sql = "select tblThuePhong.ID as 'Mã', TenLoaiPhong as 'Tên Loại Phòng', TenPhong as 'Tên Phòng', HoTen as 'Họ và Tên', " +
                "tblKhachHang.CCCD as 'CCCD/CMND', DienThoai as 'Số Điện Thoại', Convert(varchar, NgayThue, 103) as 'Ngày Thuê', " +
                "Convert(varchar, NgayTra,103) as 'Ngày Trả', GiaPhong as 'Giá Thuê', TienDatCoc as 'Tiền Đặt Cọc', tblThuePhong.TrangThai as 'Trạng Thái' " +
                "from tblLoaiPhong, tblPhong, tblKhachHang, tblThuePhong " +
                "where tblLoaiPhong.ID = tblPhong.IDLoaiPhong and tblPhong.ID = tblThuePhong.IDPhong " +
                "and tblThuePhong.CCCD = tblKhachHang.CCCD";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            grvThuephong.DataSource = dt;
        }

        private void Form_TraPhong_Load(object sender, EventArgs e)
        {
            loaddata();
            grvThuephong.Hide();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void grvThuephong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                lbHovaten1.Text = grvThuephong.Rows[e.RowIndex].Cells[0].ToString();
            }
        }
    }
}
