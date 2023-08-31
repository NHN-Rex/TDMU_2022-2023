using MDI.Child_Form;

namespace MDI
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

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // nếu lựa chọn yes thì sẽ thoát chương trình.
            if (MessageBox.Show("Bạn Muốn Thoát Chương Trình?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void nhậpThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //tạo 1 biến form mới sau đó add vào theo định dạng của hàm AddForm().
            var f = new Form_Nhap();
            AddForm(f);
        }

        private void traCứuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Form_TraCuu();
            AddForm(f);
        }
    }
}