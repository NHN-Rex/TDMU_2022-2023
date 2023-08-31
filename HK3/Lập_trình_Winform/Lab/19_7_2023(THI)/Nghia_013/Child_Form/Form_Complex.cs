using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nghia_013.Child_Form
{
    public partial class Form_Complex : Form
    {
        public Form_Complex()
        {
            InitializeComponent();
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = string.Empty;
            lbresult.Text = textBox2.Text = "..........";
            textBox1.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn đóng form hiện tại?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            float a, b, c, d;
            if(textBox1.Text.Contains("+"))
            {
                string[] arr = textBox1.Text.Split('+');
                a = float.Parse(arr[0]);
                b = float.Parse(arr[1].Split('i')[0]);
            }
            else
            {
                string[] arr = textBox1.Text.Split('-');
                a = float.Parse(arr[0]);
                b = float.Parse(arr[1].Split('i')[0])*-1;
            }
            
            if (textBox2.Text.Contains("+"))
            {
                string[] arr = textBox2.Text.Split('+');
                c = float.Parse(arr[0]);
                d = float.Parse(arr[1].Split('i')[0]);
            }
            else
            {
                string[] arr = textBox2.Text.Split('-');
                c = float.Parse(arr[0]);
                d = float.Parse(arr[1].Split('i')[0])*-1;
            }
            if ((b + d) < 0)
            {
                lbresult.Text = (a + c).ToString() + (b + d).ToString() + "i";
            }
            else
            {
                lbresult.Text = (a + c).ToString() + "+" + (b + d).ToString() + "i";
            }
            if((b-d) < 0)
            {
                lbresulth.Text = (a - c).ToString() + (b - d).ToString() + "i";
            }
            else
            {
                lbresulth.Text = (a + c).ToString() + "+" + (b - d).ToString() + "i";
            }

        }
    }
}
