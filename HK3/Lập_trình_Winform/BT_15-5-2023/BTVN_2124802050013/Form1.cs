namespace BTVN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_Pass_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_Pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_Dangky_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text == "TDMU" && txt_Pass.Text == "TDMU")
            {
                MessageBox.Show("Vui long nhap lai ID va Pass!");
            }
            else
            {
                MessageBox.Show("Dang ky thanh cong!");
                txt_ID.Text = null;
                txt_Pass.Text = null;
                txt_sdt.Text = null;
                txt_diachi.Text = null;
            }
        }
    }
}