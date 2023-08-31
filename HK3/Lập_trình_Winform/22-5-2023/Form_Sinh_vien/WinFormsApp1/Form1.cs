namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListViewItem item1 = new ListViewItem();
            ListViewItem.ListViewSubItem subitem1;
            subitem1 = new ListViewItem.ListViewSubItem();

            item1.Text = "Nguyen Huu Nghia";
            subitem1.Text = "2124802050013";

            item1.SubItems.Add(subitem1);
            listView1.Items.Add(item1);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_fullname.Text.Length > 0)
            {
                comboBox1.Items.Add(txt_fullname.Text);
                txt_fullname.Text = string.Empty;
                txt_mssv.Text = string.Empty;
                txt_sdt.Text = string.Empty;
                txt_lop.Text = string.Empty;
                txt_khoa_vien.Text = string.Empty;
                txt_que.Text = string.Empty;
                txt_dia_chi.Text = string.Empty;
                txt_nien_khoa.Text = string.Empty;

            }
        }

        private void txt_fullname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_fullname_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_mssv_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_mssv_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_nien_khoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection item;
            item = listView1.SelectedItems;
            if (item.Count > 0)
            {
                string str1 = item[0].Text;
                string str2 = item[0].SubItems[1].Text;
                MessageBox.Show(str1 + "--" + str2);

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}