using Lab_21_6_2023.Child_Form;

namespace Lab_21_6_2023
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void btnXucxac_Click(object sender, EventArgs e)
        {
            var f = new Form_XucXac();
            f.ShowDialog();
        }

        private void btnBiensoxe_Click(object sender, EventArgs e)
        {
            var f = new Form_BienSoXe();
            f.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}