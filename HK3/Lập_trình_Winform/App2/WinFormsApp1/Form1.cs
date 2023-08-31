namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Dang_nhap_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("ID: {0} \n Password: {1} \n Login complete!", txt_tdn.Text, txt_pass.Text);
            MessageBox.Show("id: " + txt_tdn.Text + "\nPasswrod: " + txt_pass.Text + "\nLogin complete!");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Do you really want to close?", "Demo form", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            if (!char.IsDigit(control.Text[control.Text.Length - 1]))
                this.errorProvider1.SetError(control, "this is not a number");
            else
                this.errorProvider1.Clear();
        }

        private void txt_tdn_TextChanged(object sender, EventArgs e)
        {
            String text;
            text = ((TextBox)sender).Text;
            ((TextBox)sender).Text = text.ToUpper();
        }

        private void txt_tdn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txt_tdn_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }
    }
}