namespace App1
{
    public partial class App1 : Form
    {
        public App1()
        {
            InitializeComponent();
        }

        private void textBox_User_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Pass_Word_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox_User_Name.Text + " Is Login Complete");
        }
    }
}