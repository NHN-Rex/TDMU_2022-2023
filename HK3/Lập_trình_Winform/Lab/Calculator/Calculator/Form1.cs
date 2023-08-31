using System.Diagnostics.Eventing.Reader;

namespace Calculator
{
    public partial class Form_calculator : Form
    {
        public Form_calculator()
        {

            InitializeComponent();
        }
        double A, B, KQ;
        char Op;

        private void Form_calculator_Load(object sender, EventArgs e)
        {

        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtResult.Text += bt.Text;
        }

        private void btnOP_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtResult.Text += bt.Text;
            Op = bt.Text[0];
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            /*switch (Op)
            {
                case '+': KQ = A + B; break;
                case '-': KQ = A - B; break;
                case '*': KQ = A * B; break;
                case '/':
                    if (B == 0)
                    {
                        MessageBox.Show("khong the chia 0");
                        break;
                    }
                    else
                    {
                        KQ = A / B;
                        break;
                    }
            }
            txtResult.Text = KQ.ToString();*/
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(txtResult.Text.Contains('(').ToString());
            //tinh();
            txtResult.Text = string.Empty;

        }

        private void tinhtraiquaphai()
        {
            /*string c = string.Empty;
            if (txtResult.Text.Contains('('))
            {
                int i = txtResult.Text.IndexOf('(');
                while (txtResult.Text[i] != ')')
                {
                    c += txtResult.Text[i];
                    i++;
                }   
                MessageBox.Show(c+ txtResult.Text[i]);
            }*/

            string s1 = txtResult.Text;



        }
    }
}