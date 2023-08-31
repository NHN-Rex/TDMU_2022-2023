using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_Form.ChilForm
{
    public partial class Form_Triangle : Form
    {
        public Form_Triangle()
        {
            InitializeComponent();
        }

        private bool checkTriangle(int a, int b, int c)
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Đây không phải 3 cạnh của một tam giác!", "Chú ý");
                return false;
            }
        }

        private int cal_chuvi(int a, int b, int c)
        {
            return a + b + c;
        }

        private float cal_dientich(int a, int b, int c)
        {
            //s tam giac được tính theo công thức herong
            float p = cal_chuvi(a, b, c) / 2;
            float s = (float)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtA.Text);
                int b = int.Parse(txtB.Text);
                int c = int.Parse(txtC.Text);
                txtP.ReadOnly = txtS.ReadOnly = true;//bật mode readonly của 2 text box chu vi và diện tích
                if (checkTriangle(a, b, c))
                {
                    txtP.Text = cal_chuvi(a, b, c).ToString(); //hiển thị kết quả chu vi lên text box
                    txtS.Text = cal_dientich(a, b, c).ToString(); //hiển thị kết quả diện tính lên text box
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//hiển thị lỗi.
            }
        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            txtA.Text = txtB.Text = txtC.Text = string.Empty; // làm trống 3 text box cạnh abc
            txtA.Focus();//đặt con trỏ vào text box cạnh a
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();//đóng form
        }

        private void Form_Triangle_Load(object sender, EventArgs e)
        {
            txtA.Focus();//đặt con trỏ vào text box cạnh A
        }
    }
}
