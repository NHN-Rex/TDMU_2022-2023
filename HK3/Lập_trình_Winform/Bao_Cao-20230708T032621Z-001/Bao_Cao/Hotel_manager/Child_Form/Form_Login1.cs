using System;
using System.Collections;
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
    public partial class Form_Login1 : Form
    {

        #region GUI
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void ptbclose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát trương trình?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();

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
        private void pntop_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ptbstate_Click(null, null);
        }

        #endregion
        public Form_Login1()
        {
            InitializeComponent();
        }
        private ConnectDatabase conn = new ConnectDatabase();


        public bool Login()
        {
            string query = "SELECT * FROM tblTaiKhoan WHERE TaiKhoan = '" + txtTendangnhap.Text + "' AND MatKhau = '" + txtMatkhau.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn.connect());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Close();
                return true;
            }
            dr.Close();
            return false;

        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (Login())
            {
                DataSet ds = new DataSet();
                SqlCommand cmd1 = new SqlCommand();
                cmd1.CommandText = "Select TenViTri from tblTaiKhoan, tblViTri where tblTaiKhoan.IDViTri = tblViTri.ID and TaiKhoan = '" + txtTendangnhap.Text + "' and MatKhau = '" + txtMatkhau.Text + "'";
                cmd1.Connection = conn.connect();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd1;
                da.Fill(ds, "Vitri");
                Const.loaitaikhoan = ds.Tables["ViTri"].Rows[0][0].ToString();
                var f = new Form_Main();
                f.Show();
                this.Hide();
                f.logout += F_logout;
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Tên đăng nhập hoặc mật khẩu không đúng!!!", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void F_logout(object? sender, EventArgs e)
        {
            (sender as Form_Main).isExit = false;
            (sender as Form_Main).Close();
            this.Show();
        }

        private void Form_Login1_Load(object sender, EventArgs e)
        {
            txtTendangnhap.Focus();
            menuStrip1.Enabled = false;
        }

        private void Form_Login1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
