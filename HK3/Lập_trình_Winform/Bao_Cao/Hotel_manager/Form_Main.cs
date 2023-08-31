using Hotel_manager.Child_Form;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Hotel_manager
{
    public partial class Form_Main : Form
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
        public Form_Main()
        {
            InitializeComponent();
        }

        private void ptbclose_Click(object sender, EventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Bạn muốn thoát trương trình?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Application.Exit();
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
        private void pntop_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ptbstate_Click(null, null);
        }
        #endregion
        private void Form_Main_Load(object sender, EventArgs e)
        {
            /*var f1 = new Form_Login1();
            //AddForm(f1);
            f1.ShowDialog();*/
            Phanquyen();
        }

        private void Phanquyen()
        {
            if (Const.loaitaikhoan == "Lễ Tân")
            {
                doanhThuToolStripMenuItem.Enabled = false;
                danhMụcToolStripMenuItem.Enabled = false;
                phòngĐangThuêToolStripMenuItem_Click(null, null);
            }
            else if (Const.loaitaikhoan == "Quản Lý")
            {
                tàiKhoảnToolStripMenuItem.Enabled = false;
                vịTríViệcLàmToolStripMenuItem.Enabled = false;
            }
            else if (Const.loaitaikhoan == "CSKH")
            {
                nhânViênToolStripMenuItem.Enabled = false;
                thốngKêToolStripMenuItem.Enabled = false;
                phòngToolStripMenuItem.Enabled = false;
                tàiKhoảnToolStripMenuItem.Enabled = false;
                vịTríViệcLàmToolStripMenuItem.Enabled = false;
                quảnLýKháchHàngToolStripMenuItem_Click(null, null);
            }
        }
        public void AddForm(Form f)
        {
            this.grbcontent.Controls.Clear();//xoa cac control hien co tren groupbox
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.Text = f.Text;
            this.grbcontent.Controls.Add(f);
            f.Show();
        }

        private void ThoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var f = new Form_DanhSachLoaiPhong();
            AddForm(f);
        }

        private void khoáMànHìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*var f = new Form_Login1();
            //AddForm(f);
            f.ShowDialog();*/
            logout(this, new EventArgs());
        }

        private void danhSáchPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Form_DanhSachPhong();
            AddForm(f);
        }

        private void grbcontent_Enter(object sender, EventArgs e)
        {

        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Form_DanhSachDichVu();
            AddForm(f);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Form_DanhSachKhachThuePhong();
            AddForm(f);
        }

        private void thuêPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Form_DanhSachThuePhong();
            AddForm(f);
        }

        private void trảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Form_TraPhong1();
            AddForm(f);
        }

        private void nhânViênToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var f = new Form_DanhSachNhanVien();
            AddForm(f);
        }

        private void tàiKhoảnToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var f = new Form_TaiKhoan();
            AddForm(f);
        }

        private void vịTríViệcLàmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Form_ViTri();
            AddForm(f);
        }

        private void phòngĐangThuêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Form_ThongKe();
            f.ShowDialog();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Form_HoaDon();
            AddForm(f);
        }

        private void pnright_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnbottom_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pnleft_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}