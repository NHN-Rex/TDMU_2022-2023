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
    public partial class Form_ThemTaiKhoan : Form
    {
        private ConnectDatabase conn = new ConnectDatabase();
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
            if (MessageBox.Show("Bạn muốn dừng thêm tài khoản?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
        public Form_ThemTaiKhoan()
        {
            InitializeComponent();
        }

        private void addcbbVitri()
        {
            DataSet dataSet = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from tblViTri";
            cmd.Connection = conn.connect();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dataSet, "ViTri");
            cbbVitri.DataSource = dataSet.Tables["ViTri"];
            cbbVitri.DisplayMember = "TenViTri";
            cbbVitri.ValueMember = "ID";
        }

        private void addcbbNhanvien()
        {
            DataSet dataSet = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from tblNhanVien";
            cmd.Connection = conn.connect();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dataSet, "NhanVien");
            cbbTennhanvien.DataSource = dataSet.Tables["NhanVien"];
            cbbTennhanvien.DisplayMember = "TenNhanVien";
            cbbTennhanvien.ValueMember = "ID";
        }


        private void btnXacnhan_Click(object sender, EventArgs e)
        {
                if (string.IsNullOrEmpty(txtTendangnhap.Text) || string.IsNullOrEmpty(txtMatkhau.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản!", "Lưu Ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                var con = conn.connect();
                string Check_exist_query = "SELECT TaiKhoan FROM tblTaiKhoan WHERE TaiKhoan = '" + txtTendangnhap.Text + "'";
                string Insert_query = "insert into tblTaiKhoan values(" + int.Parse(txtIDtaikhoan.Text) + ", " +
                "'"+ int.Parse(cbbTennhanvien.SelectedValue.ToString()) + "','" + txtTendangnhap.Text + "', " +
                "'" + txtMatkhau.Text + "', " + int.Parse(cbbVitri.SelectedValue.ToString()) + ")";
                SqlCommand cmd = new SqlCommand(Check_exist_query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (!dr.HasRows)
                {
                    dr.Close();
                    cmd = new SqlCommand(Insert_query, con);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        con.Close();
                        MessageBox.Show("Thêm tài khoản thành công", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Const.loadgridview = true;
                        
                        this.Dispose();
                    }
                }
                else
                {
                    con.Close();
                    MessageBox.Show("Tên tài khoản đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void Form_ThemTaiKhoan_Load(object sender, EventArgs e)
        {
            txtIDtaikhoan.Enabled = false;
            addcbbVitri();
            addcbbNhanvien();
            txtIDtaikhoan.Text = Const.idtaikhoan.ToString();
        }

    }
}
