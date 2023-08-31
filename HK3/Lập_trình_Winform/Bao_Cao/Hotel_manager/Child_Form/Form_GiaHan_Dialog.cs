using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_manager.Child_Form
{
    public partial class Form_GiaHan_Dialog : Form
    {

        public Form_GiaHan_Dialog()
        {
            InitializeComponent();
        }

        private void Form_GiaHan_Dialog_Load(object sender, EventArgs e)
        {
            dtpNgaygiahan.Value = DateTime.Now;
        }
    }
}
