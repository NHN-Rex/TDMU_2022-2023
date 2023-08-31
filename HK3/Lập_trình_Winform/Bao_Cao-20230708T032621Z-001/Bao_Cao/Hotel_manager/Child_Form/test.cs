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

    public partial class test : Form
    {
        private ConnectDatabase conn = new ConnectDatabase();

        public test()
        {
            InitializeComponent();

        }
        private void loaddata()
        {
            var con = conn.connect();
            string sql = "select tblPhong.ID as 'Mã Phòng', TenLoaiPhong as 'Tên Loại Phòng', " +
                "TenPhong as 'Tên Phòng',  TrangThai as 'Trạng Thái' " +
                "from tblPhong, tblLoaiPhong" +
                " where tblPhong.IDLoaiPhong = tblLoaiPhong.ID " +
                "order by tblPhong.TrangThai ASC";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;

        }

        private void formatgrid()
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                string s = dataGridView1.Rows[i].Cells["Trạng Thái"].Value.ToString();
                if (s == "Còn trống")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
                else
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void test_Load(object sender, EventArgs e)
        {
            loaddata();
            formatgrid();
        }
    }
}
