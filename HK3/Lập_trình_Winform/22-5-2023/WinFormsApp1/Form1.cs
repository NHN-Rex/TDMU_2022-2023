namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.IndexOf(textBox1.Text) >= 0)
                listBox1.SelectedItem = textBox1.Text;
            //else if (textBox1.Text.Length > 0)
            //{
              //listBox1.Items.Add(textBox1.Text);
              //textBox1.Text = string.Empty;
            //}
            else if(textBox1.Text.Length > 0)
            {
                cb1.Items.Add(textBox1.Text);
                textBox1.Text = string.Empty;
            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(Object sender, EventArgs e)
        {
            string str;
            str = cb1.Text;
            MessageBox.Show(str);
        }
    }
}