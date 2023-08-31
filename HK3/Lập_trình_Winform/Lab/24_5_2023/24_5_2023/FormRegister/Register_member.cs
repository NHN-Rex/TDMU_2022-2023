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

namespace FormRegister
{
    public partial class Register_Member_Form : Form
    {
        public Register_Member_Form()
        {
            InitializeComponent();
        }

        private void Register_Member_Form_Load(object sender, EventArgs e)
        {

        }
        private SqlConnection Connect()
        {
            string str = @"Server = DESKTOP-IC4OH16\MSSQLSERVER01; Database = INFORMATION; Integrated Security = True;";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            return con;
        }
        private void Disconnect()
        {
            Connect().Close();
        }
        private void back()
        {
            txtUserName.Text = "";
            txtPASS.Text = "";
            txtUserName.Focus();
        }
        private void BTNLOGIN_Click(object sender, EventArgs e)
        {
            bool check_admin = false;
            if (Login(ref check_admin))
            {
                if (check_admin)
                {
                    Register_Admin_Form register_Admin = new Register_Admin_Form();
                    this.Hide();
                    register_Admin.Show();
                }
                else
                {
                    MessageBox.Show("Login Complete!");
                }

            }
            else
            {
                MessageBox.Show("Login Error. Because ID or Password is wrong!");
            }
            back();
        }
        private bool Login(ref bool check_admin)
        {

            string query = "SELECT * FROM INFO WHERE ID = '" + txtUserName.Text + "' AND PASS = '" + txtPASS.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Connect());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                if (txtUserName.Text == "admin" && txtPASS.Text == "admin")
                {
                    check_admin = true;
                }
                dr.Close();
                return true;
            }
            dr.Close();
            return false;

        }
        private void BTNREGISTER_Click(object sender, EventArgs e)
        {
            if (Register())
            {
                MessageBox.Show("Register Complete!");
            }
            else
            {
                MessageBox.Show("Register Error. Because ID is exist!");
            }
            back();

        }
        private bool Register()
        {
            SqlConnection Connecting = Connect();
            string Check_exist_query = "SELECT ID FROM INFO WHERE ID = '" + txtUserName.Text + "'";
            string Inser_query = "INSERT INTO INFO(ID, PASS) VALUES ('" + txtUserName.Text + "',N'" + txtPASS.Text + "')";
            SqlCommand cmd = new SqlCommand(Check_exist_query, Connecting);
            SqlDataReader dr = cmd.ExecuteReader();
            if (!dr.HasRows)
            {
                dr.Close();
                cmd = new SqlCommand(Inser_query, Connecting);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }

            }
            return false;
        }
        private void checkBox_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowPassword.Checked)
            {
                txtPASS.UseSystemPasswordChar = false;
            }
            else
            {
                txtPASS.UseSystemPasswordChar = true;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
