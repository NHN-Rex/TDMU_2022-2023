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
    public partial class Form_GiaHanPhong : Form
    {
        private ConnectDatabase conn = new ConnectDatabase();
        private DataSet ds = new DataSet();
        private int kt;
        public Form_GiaHanPhong()
        {
            InitializeComponent();
        }
    }
}
