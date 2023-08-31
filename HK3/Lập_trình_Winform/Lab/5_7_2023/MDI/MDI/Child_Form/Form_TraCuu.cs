using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MDI.Child_Form
{
    public partial class Form_TraCuu : Form
    {
        public Form_TraCuu()
        {
            InitializeComponent();
        }
        List<Computer> dscpt = new List<Computer>();
        string path = Application.StartupPath + "list.txt";
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn dừng tra cứu?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
        private void Format_lisview()
        {
            lstCpt.Columns.Add("Sản Phẩm", 100); // thêm header vào lisview ".Add(<name>,<width>)".
            lstCpt.Columns.Add("Thông Số Kỹ Thuật", 641);
            lstCpt.Columns.Add("Giá Bán", 100);
        }


        private void Form_TraCuu_Load(object sender, EventArgs e)
        {

            Format_lisview();
            Excute.Read(dscpt, path);
            cbbHsx_SelectedIndexChanged(sender, e);

        }

        private void addcbbdsp(List<Computer> cpt)
        {
            DataTable dt = new DataTable("DSP"); // tạo 1 Datatable có tên là "DSP".
            dt.Columns.Add("TS"); // Thêm cột có tên "TS" vào datatable vừa tạo.
            //Vòng foreach này sẽ lập từng phần tử computer trong listcomputer có tên là cpt.
            foreach (Computer comp in cpt)
            {
                // Xét điều kiện nếu giá trị của cbbHsx.Text == với comp.hsx thì sẽ thêm comp.tsp tương ứng vào cbbDsp bằng cách sử dụng datarow.
                if (cbbHsx.Text == comp.hsx.ToString())
                {
                    DataRow dr = dt.NewRow();
                    dr["TS"] = comp.tsp;
                    dt.Rows.Add(dr);
                }
            }
            //sau khi qua vòng for lúc này ta sẽ có được 1 table có tên "DSP" gồm 1 cột có tên "TS".
            cbbDsp.DataSource = dt;//gán DataSource của cbbDsp = table DSP.
            cbbDsp.DisplayMember = "TS";// Gán DisplayMember của cbbDsp = cột "TS" trong table "DSP".
        }

        private void cbbHsx_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstCpt.Items.Clear();//xoá các items đang có trong listview
            addcbbdsp(dscpt);
            try
            {
                foreach (Computer cpt in dscpt)
                {
                    if (cbbHsx.Text == "Tất Cả")
                    {
                        ListViewItem a = new ListViewItem(cpt.tsp); //tạo 1 listview items mới với Item là cpt.tsp

                        //tạo 1 subitems mới tên "b" với "a" là tên của lisviewitems vừa tạo, "cpt.thongso" là giá trị của subitems.
                        ListViewItem.ListViewSubItem b = new ListViewItem.ListViewSubItem(a, cpt.thongso);

                        //tạo thêm 1 subitems mới tên "c" với a là tên của lisviewitems vừa tạo, "cpt.gia" là giá trị của subitem.
                        //vì "cpt.gia" trong project này có đơn vị tiền tệ. Nên dùng hàm string.Format(<kiểu định dạng>, <Giá trị>) lại cho dễ nhìn.
                        ListViewItem.ListViewSubItem c = new ListViewItem.ListViewSubItem(a, string.Format("{0:#,##0}", int.Parse(cpt.gia)));
                        a.SubItems.Add(b);//thêm subitems b vào items a.
                        a.SubItems.Add(c);//them subitems c vào items a.
                        lstCpt.Items.Add(a); //thêm items a vào listview.
                    }
                    else
                    {
                        cbbDsp_SelectedIndexChanged(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            count();
        }

        private void cbbDsp_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstCpt.Items.Clear();
            try
            {
                foreach (Computer cpt in dscpt)
                {
                    if (cpt.tsp == cbbDsp.Text)
                    {
                        ListViewItem a = new ListViewItem(cpt.tsp);
                        ListViewItem.ListViewSubItem b = new ListViewItem.ListViewSubItem(a, cpt.thongso);
                        ListViewItem.ListViewSubItem c = new ListViewItem.ListViewSubItem(a, string.Format("{0:#,##0}", int.Parse(cpt.gia)));
                        a.SubItems.Add(b);
                        a.SubItems.Add(c);
                        lstCpt.Items.Add(a);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void count()
        {
            txtSum.Text = lstCpt.Items.Count.ToString();
        }
    }
}
