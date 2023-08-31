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
    public partial class Form_Quadratic : Form
    {
        public Form_Quadratic()
        {
            InitializeComponent();
        }

        private int gpt(int a, int b, int c, ref float x1, ref float x2)
        {
            float delta = b * b - 4 * a * c; //tính delta
            if (delta < 0)
            {
                x1 = x2 = 0;
                return 0;
            }
            else if (delta == 0)
            {
                x1 = x2 = -b / (2 * a);
                return 1;
            }
            else
            {
                delta = (float)Math.Sqrt(delta);
                x1 = (-b + delta) / (2 * a);
                x2 = (-b - delta) / (2 * a);
                return 2;
            }
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            try
            {
                float x1 = 0;
                float x2 = 0;
                int a = int.Parse(txtA.Text);
                int b = int.Parse(txtB.Text);
                int c = int.Parse(txtC.Text);
                if (a == 0)
                {
                    lbkq.Text = "A phải khác 0.";
                    txtA.Text = string.Empty;
                    txtA.Focus();
                }
                else
                {
                    if (gpt(a, b, c, ref x1, ref x2) == 0)
                    {
                        lbkq.Text = "Phương trình vô nghiệm.";
                    }
                    else if (gpt(a, b, c, ref x1, ref x2) == 1)
                    {
                        lbkq.Text = "Phương trình có nghiệm kép: x = " + x1.ToString();
                    }
                    else if (gpt(a, b, c, ref x1, ref x2) == 2)
                    {
                        lbkq.Text = "Phương trình có 2 nghiêm x1 = " + x1.ToString() + ",\nx2 = " + x2.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            txtA.Text = txtB.Text = txtC.Text = string.Empty; txtA.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose(); // đóng form này lại.
        }
    }
}
