
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Drawing;
using Microsoft.VisualBasic;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;

namespace FormRegister
{
    public partial class Register_Admin_Form : Form
    {
        public Register_Admin_Form()
        {
            InitializeComponent();
        }
        private void Register_Admin_Form_Load(object sender, EventArgs e)
        {
            Grid_fill();
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
        private void Grid_fill()
        {
            /*SqlDataAdapter da = new SqlDataAdapter("Select * from INFO", str);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;*/

            SqlConnection Connecting = Connect();
            string sql = "Select * from INFO";
            SqlCommand com = new SqlCommand(sql, Connecting);
            com.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            Connecting.Close();
            dataGridView1.DataSource = dt;
        }
        private void back()
        {
            txtUserName.Text = "";
            txtPASS.Text = "";
            txtUserName.Focus();
        }
        private void BTNLOGIN_Click(object sender, EventArgs e)
        {
            if (Login())
            {
                MessageBox.Show("Login Complete!");
                /*Register_Member_Form register_Member = new Register_Member_Form();
                register_Member.Show();
                this.Hide();*/
            }
            else
            {
                MessageBox.Show("Login Error. Because ID or Password is wrong!");
            }
            back();

        }
        private bool Login()
        {
            string query = "SELECT * FROM INFO WHERE INFO.ID = '" + txtUserName.Text + "' AND INFO.PASS = '" + txtPASS.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Connect());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
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
                Grid_fill();
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
            string Check_exist_query = "SELECT INFO.ID FROM INFO WHERE ID = '" + txtUserName.Text + "'";
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            bool check_pass = false;
            if (Remove(ref check_pass))
            {
                MessageBox.Show("Remove " + txtUserName.Text + " Complete!");
                Grid_fill();
            }
            else
            {
                if (check_pass)
                {
                    MessageBox.Show("Remove Error. Because ID or Password is wrong!");
                }
                else
                {
                    MessageBox.Show("Remove Error. Because " + txtUserName.Text + " does not exist!");
                }
            }
            back();
        }

        private void remove()
        {
            SqlConnection Connecting = Connect();
            string Check_exist_query = "SELECT INFO.ID FROM INFO WHERE INFO.ID = '" + txtUserName.Text + "' AND INFO.PASS = '" + txtPASS.Text + "'";
            string Remove_query = "DELETE FROM INFO WHERE  INFO.ID = '" + txtUserName.Text + "' AND INFO.PASS = '" + txtPASS.Text + "'";
            SqlCommand cmd = new SqlCommand(Check_exist_query, Connecting);
            SqlDataReader dr = cmd.ExecuteReader();
        }

        private bool Remove(ref bool check_pass)
        {
            check_pass = true;
            SqlConnection Connecting = Connect();
            string Check_exist_query = "SELECT INFO.ID FROM INFO WHERE INFO.ID = '" + txtUserName.Text + "' AND INFO.PASS = '" + txtPASS.Text + "'";
            string Remove_query = "DELETE FROM INFO WHERE INFO.ID = '" + txtUserName.Text + "' AND INFO.PASS = '" + txtPASS.Text + "'";
            SqlCommand cmd = new SqlCommand(Check_exist_query, Connecting);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Close();
                cmd = new SqlCommand(Remove_query, Connecting);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    check_pass = false;
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Updated())
            {
                MessageBox.Show("Data has been updated!");
                Grid_fill();
            }
            else
            {
                MessageBox.Show("Update Error!");
            }
        }

        private bool Updated()
        {
            SqlConnection Connecting = Connect();
            string Check_exist_query = "SELECT ID FROM INFO WHERE ID = '" + txtUserName.Text + "'";
            string Update_query = "UPDATE INFO set INFO.PASS = '" + txtPASS.Text + 
                "' where INFO.ID = '" + txtUserName.Text + "'";
            SqlCommand cmd = new SqlCommand(Check_exist_query, Connecting);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Close();
                cmd = new SqlCommand(Update_query, Connecting);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                MessageBox.Show(cmd.ExecuteNonQuery().ToString());
            }
            return false;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            SqlConnection Connecting = Connect();
            string Check_exist_query = "SELECT ID FROM INFO WHERE ID = '" + txtUserName.Text + "'";
            string Find_query = "SELECT * FROM INFO WHERE ID = '" + txtUserName.Text + "'";
            SqlCommand cmd = new SqlCommand(Check_exist_query, Connecting);
            cmd = new SqlCommand(Find_query, Connecting);
            var rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                txtPASS.Text = rd["PASS"].ToString();
            }
            else
            {
                MessageBox.Show("404-ID is not found!");
            }

        }
    }
}