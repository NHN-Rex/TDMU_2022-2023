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
    public partial class Form_XucXac : Form
    {
        public Form_XucXac()
        {
            InitializeComponent();
        }
        string pathImg = "";
        int nChoose, nCount, nWin, nLose;
        private void Form_XucXac_Load(object sender, EventArgs e)
        {
            nChoose = 1;
            nCount = nWin = nLose = 0;
            pathImg = Application.StartupPath + @"HinhXucXac";
            Bitmap bmp = new Bitmap(pathImg + @"\die1.gif");
            pictureBox1.Image = (Image)bmp;
            lbCount.Text = lbLose.Text = lbWin.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            Bitmap bmp = new Bitmap(pathImg + @"\die" + bt.Text + ".gif");
            pictureBox1.Image = (Image)bmp;
            nChoose = Convert.ToInt16(bt.Text);
        }

        private void btPlay_Click(object sender, EventArgs e)
        {
            nCount++;
            string sResult = "";
            Random rand = new Random();
            int n = rand.Next(1, 7);
            Bitmap bmp = new Bitmap(pathImg + @"\die" + n.ToString() + ".gif");
            pictureBox3.Image = (Image)bmp;
            if (n == nChoose)
            {
                nWin++;
                sResult = "Thắng";
            }
            else
            {
                nLose++;
                sResult = "Thua";
            }
            lbCount.Text = "Lần đoán: " + nCount.ToString();
            lbWin.Text = "Lần thắng: " + nWin.ToString() + " (" + Convert.ToString(nWin * 100.0 / nCount) + "%)";
            lbLose.Text = "Lần thua: " + nLose.ToString() + " (" + Convert.ToString(nLose * 100.0 / nCount) + "%)";
            listResult.Items.Add(nCount.ToString() + ". " + sResult + " (Đoán " + nChoose.ToString() + " ra " + n.ToString() + ")");
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            nChoose = 1;
            nCount = nWin = nLose = 0;
            pathImg = Application.StartupPath + @"HinhXucXac";
            Bitmap bmp = new Bitmap(pathImg + @"\die1.gif");
            pictureBox1.Image = (Image)bmp;
            lbCount.Text = lbLose.Text = lbWin.Text = "";
            listResult.Items.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
