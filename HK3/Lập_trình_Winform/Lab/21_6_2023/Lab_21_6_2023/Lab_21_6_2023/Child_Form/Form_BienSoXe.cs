using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_21_6_2023.Child_Form
{
    public partial class Form_BienSoXe : Form
    {
        public Form_BienSoXe()
        {
            InitializeComponent();
        }

        private void btTatca_Click(object sender, EventArgs e)
        {
            listBangso.Items.Clear();
            for (int i = 1; i <= 9999; i++)
            {
                string s = String.Format("{0:0000}", i);
                listBangso.Items.Add(s);
            }
            lbDem.Text = listBangso.Items.Count.ToString();
        }

        private void btChinnut_Click(object sender, EventArgs e)
        {
            listBangso.Items.Clear();
            for (int i = 1; i <= 9999; i++)
            {
                string s = String.Format("{0:0000}", i);
                int s1 = Convert.ToInt16(s.Substring(0, 1));
                int s2 = Convert.ToInt16(s.Substring(1, 1));
                int s3 = Convert.ToInt16(s.Substring(2, 1));
                int s4 = Convert.ToInt16(s.Substring(3, 1));
                string tong = Convert.ToString(s1 + s2 + s3 + s4);
                if (tong.Substring(tong.Length - 1, 1) == "9")
                {
                    listBangso.Items.Add(s);
                }
            }
            lbDem.Text = listBangso.Items.Count.ToString();
        }

        private void btDoixung_Click(object sender, EventArgs e)
        {
            listBangso.Items.Clear();
            for (int i = 1; i <= 9999; i++)
            {
                string s = String.Format("{0:0000}", i);
                int s1 = Convert.ToInt16(s.Substring(0, 1));
                int s2 = Convert.ToInt16(s.Substring(1, 1));
                int s3 = Convert.ToInt16(s.Substring(2, 1));
                int s4 = Convert.ToInt16(s.Substring(3, 1));
                if (s1 == s4 && s2 == s3)
                {
                    listBangso.Items.Add(s);
                }
            }
            lbDem.Text = listBangso.Items.Count.ToString();
        }

        private void btGanh_Click(object sender, EventArgs e)
        {
            listBangso.Items.Clear();
            for (int i = 1; i <= 9999; i++)
            {
                string s = String.Format("{0:0000}", i);
                int s1 = Convert.ToInt16(s.Substring(0, 1));
                int s2 = Convert.ToInt16(s.Substring(1, 1));
                int s3 = Convert.ToInt16(s.Substring(2, 1));
                int s4 = Convert.ToInt16(s.Substring(3, 1));
                if ((s1 == s3 || s2 == s4) && ((s1 != s2 && s2 != s3) || (s2 != s3 && s3 != s4)))
                {
                    listBangso.Items.Add(s);
                }
            }
            lbDem.Text = listBangso.Items.Count.ToString();
        }

        private void btBasotang_Click(object sender, EventArgs e)
        {
            listBangso.Items.Clear();
            for (int i = 1; i <= 9999; i++)
            {
                string s = String.Format("{0:0000}", i);
                int s1 = Convert.ToInt16(s.Substring(0, 1));
                int s2 = Convert.ToInt16(s.Substring(1, 1));
                int s3 = Convert.ToInt16(s.Substring(2, 1));
                int s4 = Convert.ToInt16(s.Substring(3, 1));
                if ((s1 <= s2 && s2 < s3 && s3 > s4) || (s2 <= s3 && s3 < s4 && s1 > s2))
                {
                    listBangso.Items.Add(s);
                }
            }
            lbDem.Text = listBangso.Items.Count.ToString();
        }

        private void btKhonggiam_Click(object sender, EventArgs e)
        {
            listBangso.Items.Clear();
            for (int i = 1; i <= 9999; i++)
            {
                string s = String.Format("{0:0000}", i);
                int s1 = Convert.ToInt16(s.Substring(0, 1));
                int s2 = Convert.ToInt16(s.Substring(1, 1));
                int s3 = Convert.ToInt16(s.Substring(2, 1));
                int s4 = Convert.ToInt16(s.Substring(3, 1));
                if (s1 <= s2 && s2 <= s3 && s3 <= s4)
                {
                    listBangso.Items.Add(s);
                }
            }
            lbDem.Text = listBangso.Items.Count.ToString();
        }

        private void tbExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
