
using System.Data;
using System.Data.SqlClient;
namespace FormRegister
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
        private void Grid_fill()
        {
            Connect();
            /*SqlDataAdapter da = new SqlDataAdapter("Select * from INFO", str);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;*/

            SqlConnection Connecting = Connect();
            Connecting.Open();
            string sql = "Select * from INFO";
            SqlCommand com = new SqlCommand(sql, Connecting);
            com.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            Connecting.Close();
            dataGridView1.DataSource = dt;
        }

        private void BTNLOGIN_Click(object sender, EventArgs e)
        {
            if (Login())
            {
                MessageBox.Show("Login Complete!");
            }
            else
            {
                MessageBox.Show("Login Error!");
            }
        }
        private bool Login()
        {
            Connect();
            string query = "SELECT * FROM INFO";
            return true;
        }
        private void Update(string id, string pass)
        {
           
        }
    }
}