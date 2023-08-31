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
    public partial class Form_Cylinder : Form
    {
        public Form_Cylinder()
        {
            InitializeComponent();
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = string.Empty;
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
            double edge = double.Parse(textBox1.Text);
            double height = double.Parse(textBox2.Text);

            double rectangularVolume = Math.Pow(edge, 2) * height;
            double radius = edge / 2;

            double cylindricalVolume = Math.PI * Math.Pow(radius, 2) * height;

            double V = rectangularVolume - cylindricalVolume;
            double roundedV = Math.Round(V, 2);
            lbresult.Text = roundedV.ToString();
        }
    }
}
