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
    public partial class Form_Sphere : Form
    {
        public Form_Sphere()
        {
            InitializeComponent();
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            lbresult.Text = "..........";
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
            int a = int.Parse(textBox1.Text);
            string result = Math.Round((Math.Pow(a, 3) - (4 * Math.PI * Math.Pow(a / 2, 3)) / 3), 2).ToString();
            lbresult.Text = result;
        }
    }
}
