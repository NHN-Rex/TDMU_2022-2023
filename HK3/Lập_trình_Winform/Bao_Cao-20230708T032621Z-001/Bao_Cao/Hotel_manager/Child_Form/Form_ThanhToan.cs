using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_manager.Child_Form
{
    public partial class Form_ThanhToan : Form
    {
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
            if (MessageBox.Show("Bạn muốn dừng thanh toán?", "Chú Ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Const.tatnutluu = false;
                this.Dispose();

            }
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
        public Form_ThanhToan()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form_ThanhToan_Load(object sender, EventArgs e)
        {
            lbTenkhachhang.Text = Const.tenkhachhang;
            lbTenphong.Text = Const.tenphong;
            lbNgaythanhtoan.Text = Const.ngaythanhtoan;
            lbCanthanhtoan.Text = string.Format("{0:#,##0}", int.Parse(Const.sotiencanthanhtoan));
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void txtTienkhachdua_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void txtTienkhachdua_KeyUp(object sender, KeyEventArgs e)
        {
            lbTienthua.Text = string.Format("{0:#,##0}", (int.Parse(txtTienkhachdua.Text) - int.Parse(lbCanthanhtoan.Text.Replace(",", ""))));
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            if (int.Parse(lbTienthua.Text.Replace(",", "")) >= 0)
            {
                Const.tatnutluu = true;
                Const.check = true;
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Khách đưa chưa đủ tiền cần thanh toán!", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
