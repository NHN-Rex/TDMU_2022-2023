using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_manager.Child_Form
{
    public partial class Form_KhachHang_Dialog : Form
    {
        private ConnectDatabase conn = new ConnectDatabase();
        private DataSet ds = new DataSet();
        private int kt;
        public Form_KhachHang_Dialog()
        {
            InitializeComponent();
        }

        private void back()
        {
            txtHovaten.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtCCCD.Text = string.Empty;
            txtQueQuan.Text = string.Empty;
            txtHKTT.Text = string.Empty;
            txtHovaten.Focus();
        }

        private bool themkhachhang()
        {
            if (string.IsNullOrEmpty(txtHovaten.Text))
            {
                MessageBox.Show("Vui lòng nhập họ khách hàng!",
                    "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            var con = conn.connect();
            //MessageBox.Show(cbbLoaiphong.SelectedValue.ToString());
            string Check_exist_query = "SELECT CCCD FROM tblKhachHang WHERE CCCD = " + txtCCCD.Text;
            string Insert_query = "insert into tblKhachHang values" +
                "(N'" + txtHovaten.Text + "', '" + txtCCCD.Text + "', '" + txtSDT.Text + "', N'" + txtQueQuan.Text + "', N'" + txtHKTT.Text + "')";
            SqlCommand cmd = new SqlCommand(Check_exist_query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (!dr.HasRows)
            {
                dr.Close();
                cmd = new SqlCommand(Insert_query, con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    con.Close();
                    return true;
                }
            }
            con.Close();
            MessageBox.Show("CCCD/CMND bị trùng!", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (themkhachhang())
            {
                MessageBox.Show("Thêm khách hàng thành công", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                back();
                Const.tatnutluu = true;
                this.Dispose();
            }
            else if (MessageBox.Show("Bạn muốn dừng thêm???", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Const.tatnutluu = true;
                this.Dispose();
            }
        }

        private void Form_KhachHang_Dialog_Load(object sender, EventArgs e)
        {
            txtHovaten.Focus();
        }
    }
}
