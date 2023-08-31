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
    public partial class Form_ThongKe : Form
    {
        private ConnectDatabase conn = new ConnectDatabase();
        private int kt;
        #region GUI
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public bool isExit = true;
        public event EventHandler logout;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void ptbclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ptbminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ptbstate_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Maximized;

            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pntop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Cursor.Current = Cursors.SizeAll;
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion
        public Form_ThongKe()
        {
            InitializeComponent();
        }
        public readonly Color controng = Color.Green;


        private int count()
        {
            if (grvThongkephong.RowCount > 0)
            {
                int c = 0;
                for (int i = 0; i < grvThongkephong.RowCount - 1; i++)
                {
                    string s = grvThongkephong.Rows[i].Cells["Trạng Thái"].Value.ToString();
                    if (s == "Còn trống")
                    {
                        c++;
                    }
                }
                return c;
            }
            return -1;
        }

        private void formatgrid()
        {
            grvThongkephong.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvThongkephong.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            for (int i = 0; i < grvThongkephong.RowCount - 1; i++)
            {
                string s = grvThongkephong.Rows[i].Cells["Trạng Thái"].Value.ToString();
                if (s == "Còn trống")
                {
                    grvThongkephong.Rows[i].DefaultCellStyle.BackColor = controng;
                }
                else
                {
                    grvThongkephong.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void loaddata()
        {
            var con = conn.connect();
            string sql = "select tblPhong.ID as 'Mã Phòng', TenLoaiPhong as 'Tên Loại Phòng', TenPhong as 'Tên Phòng',  TrangThai as 'Trạng Thái' from tblPhong, tblLoaiPhong where tblPhong.IDLoaiPhong = tblLoaiPhong.ID order by tblPhong.TrangThai ASC";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            grvThongkephong.DataSource = dt;
        }
        private void Form_ThongKe_Load(object sender, EventArgs e)
        {
            loaddata();
            if (count() == -1)
            {
                lbSophongtrong.Text = "Không còn Phòng trống";
            }
            else
            {
                lbSophongtrong.Text = count().ToString();
            }
            formatgrid();
        }
    }
}
