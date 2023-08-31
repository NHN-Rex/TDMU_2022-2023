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
    public partial class Form_Fraction : Form
    {
        public Form_Fraction()
        {
            InitializeComponent();
        }

        private int ucln(int a, int b)
        {
            //tìm ước chung lớn nhất theo phương pháp trừ.
            if (a == 0 || b == 0)
            {
                return a + b;
            }
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            return a;
        }
        private void back()
        {
            txtMau.Text = txtTu.Text = String.Empty;
            txtTu.Focus();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtTu.Text);
                int b = int.Parse(txtMau.Text);
                if (b != 0)
                {
                    int u = ucln(a, b);
                    lbkq.Text = (a / u).ToString() + "/" + (b / u).ToString();
                }
                else
                {
                    MessageBox.Show("Phân số không tồn tại");
                    back();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            back();
        }

        private void Form_Fraction_Load(object sender, EventArgs e)
        {
            txtTu.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
