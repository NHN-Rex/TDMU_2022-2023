using Nghia_013.Child_Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nghia_013
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        public void AddForm(Form f)
        {
            this.grpcontent.Controls.Clear(); // xoá tất cả các control hiện có trên groupbox.
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.Text = f.Text;
            this.grpcontent.Controls.Add(f);
            f.Show();// hiện form lên.
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn muốn thoát chương trình?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void sphereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Form_Sphere();
            AddForm(f);
        }

        private void complexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Form_Complex();
            AddForm(f);
        }

        private void cylinderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Form_Cylinder();
            AddForm(f);
        }
    }
}
