namespace FormSinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            ListViewItem item1 = new ListViewItem();
            ListViewItem.ListViewSubItem subitem1;
            if(txtmssv.Text.Length > 0)
            {
                item1.Text = txtmssv.Text;
                string[] listSub = { txthoten.Text, txtemail.Text, txtnienkhoa.Text, txtnienkhoa.Text, txtemail.Text, txtngaysinh.Text, txtadress.Text, txtmssv.Text };
                foreach(string s in listSub)
                {
                    item1.SubItems.Add(s);
                }
            }
            /*ListViewItem.ListViewSubItem subitem2;
            ListViewItem.ListViewSubItem subitem3;
            ListViewItem.ListViewSubItem subitem4;
            ListViewItem.ListViewSubItem subitem5;
            ListViewItem.ListViewSubItem subitem6;
            ListViewItem.ListViewSubItem subitem7;

            subitem1 = new ListViewItem.ListViewSubItem();
            subitem2 = new ListViewItem.ListViewSubItem();
            subitem3 = new ListViewItem.ListViewSubItem();
            subitem4 = new ListViewItem.ListViewSubItem();
            subitem5 = new ListViewItem.ListViewSubItem();
            subitem6 = new ListViewItem.ListViewSubItem();
            subitem7 = new ListViewItem.ListViewSubItem();
            if (txtmssv.Text.Length > 0)
            {
                item1.Text = txtmssv.Text;

                subitem1.Text = txthoten.Text;
                subitem2.Text = txtsdt.Text;
                subitem3.Text = txtngaysinh.Text;
                subitem4.Text = txtlop.Text;
                subitem5.Text = txtadress.Text;
                subitem6.Text = txtemail.Text;
                subitem7.Text = txtnienkhoa.Text;

                item1.SubItems.Add(subitem1);
                item1.SubItems.Add(subitem2);
                item1.SubItems.Add(subitem3);
                item1.SubItems.Add(subitem4);
                item1.SubItems.Add(subitem5);
                item1.SubItems.Add(subitem6);
                item1.SubItems.Add(subitem7);
                listView1.Items.Add(item1);

                txtmssv.Text = string.Empty;
                txthoten.Text = string.Empty;
                txtsdt.Text = string.Empty;
                txtngaysinh.Text = string.Empty;
                txtlop.Text = string.Empty;
                txtadress.Text = string.Empty;
                txtemail.Text = string.Empty;
                txtnienkhoa.Text = string.Empty;
                */
        }

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                //get index of item
                int index_of_item = listView1.Items.IndexOf(listView1.SelectedItems[0]);
                txtmssv.Text = listView1.Items[index_of_item].Text;
                txthoten.Text = listView1.Items[index_of_item].SubItems[1].Text;
                txtsdt.Text = listView1.Items[index_of_item].SubItems[2].Text;
                txtngaysinh.Text = listView1.Items[index_of_item].SubItems[3].Text;
                txtlop.Text = listView1.Items[index_of_item].SubItems[4].Text;
                txtadress.Text = listView1.Items[index_of_item].SubItems[5].Text;
                txtemail.Text = listView1.Items[index_of_item].SubItems[6].Text;
                txtnienkhoa.Text = listView1.Items[index_of_item].SubItems[7].Text;
            }


        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                //get index of item
                int index_of_item = listView1.Items.IndexOf(listView1.SelectedItems[0]);
                listView1.Items.RemoveAt(index_of_item);
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                //get index of item
                int index_of_item = listView1.Items.IndexOf(listView1.SelectedItems[0]);
                //edit item
                listView1.Items[index_of_item].Text = txtmssv.Text;
                listView1.Items[index_of_item].SubItems[1].Text = txthoten.Text;
                listView1.Items[index_of_item].SubItems[2].Text = txtsdt.Text;
                listView1.Items[index_of_item].SubItems[3].Text = txtngaysinh.Text;
                listView1.Items[index_of_item].SubItems[4].Text = txtlop.Text;
                listView1.Items[index_of_item].SubItems[5].Text = txtadress.Text;
                listView1.Items[index_of_item].SubItems[6].Text = txtemail.Text;
                listView1.Items[index_of_item].SubItems[7].Text = txtnienkhoa.Text;
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}