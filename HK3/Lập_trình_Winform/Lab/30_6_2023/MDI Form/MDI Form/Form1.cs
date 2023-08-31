using MDI_Form.ChilForm;

namespace MDI_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void AddForm(Form f)
        {
            this.grpcontent.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.Text = f.Text;
            this.grpcontent.Controls.Add(f);
            f.Show();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void triangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Form_Triangle();
            AddForm(f);
        }

        private void fractionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Form_Fraction();
            AddForm(f);
        }

        private void quadraticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Form_Quadratic();
            AddForm(f);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sao bạn không click vào mục trên menu?");
        }
    }
}