using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MDI.Child_Form
{
    public partial class Form_Nhap : Form
    {
        public Form_Nhap()
        {
            InitializeComponent();
        }
        #region btnThoat
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn dừng thêm?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
        #endregion
        #region btnThem
        private void btnThem_Click(object sender, EventArgs e)
        {
            cbbHsx.Text = txtGia.Text = txtDsp.Text = txtTs.Text = txtTsp.Text = string.Empty;
            txtDsp.Focus();
        }
        #endregion
        #region btnGhi
        List<Computer> dscpt = new List<Computer>(); //tạo list computer có kiểu là Computer. Computer là 1 class được tạo ra để chứa thông tin của Computer.
        private void btnGhitep_Click(object sender, EventArgs e)
        {
            dscpt.Clear();// xoá các phần tử đang có trong listcomputer.
            Computer cpt = new Computer(); // tạo một computer mới là cpt.
            //gán lần lượt từng thông tin tương ứng vào thuộc tính trong cpt.
            cpt.dsp = txtDsp.Text;
            cpt.hsx = cbbHsx.Text;
            cpt.tsp = txtTsp.Text;
            cpt.thongso = txtTs.Text;
            cpt.gia = txtGia.Text;
            dscpt.Add(cpt);//thêm phần tử computer vừa rồi vào listcomputer
            //path là đường dẫn tới file cần thao tác.
            //Application.StartupPath trả về đường dẫn tới thư mục chứa file cần thao tác. VD: D:\TTNT\2022-2023\HK3\Lập_trình_Winform\Lab\5_7_2023\MDI\MDI\bin\Debug\net6.0-windows\.
            string path = Application.StartupPath + "list.txt";
            //Excute.Write là một hàm trong class Excute được tạo ra dùng để ghi dữ liệu vào file theo đường dẫn path.
            //Trả về True nếu thành công và ngược lại.
            if (Excute.Write(dscpt, path))
            {
                MessageBox.Show("Ghi thành công.");
            }
        }
        #endregion
    }
}
