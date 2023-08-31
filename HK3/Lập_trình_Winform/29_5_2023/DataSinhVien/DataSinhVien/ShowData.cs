using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataSinhVien
{
    public partial class ShowData : Form
    {
        public ShowData()
        {
            InitializeComponent();
        }

        private void ShowData_Load(object sender, EventArgs e)
        {
            Grid_fill();
        }

        private SqlConnection Connect()
        {
            string str = @"Server = DESKTOP-IC4OH16\MSSQLSERVER01; Database = QLSV; Integrated Security = True;";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            return con;
        }
        private void Disconnect(SqlConnection con)
        {
            con.Close();
        }

        private void Grid_fill()
        {
            SqlConnection Connecting = Connect();
            string sql = "Select * from tblsinhvien";
            SqlCommand com = new SqlCommand(sql, Connecting);
            com.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            Connecting.Close();
            grvsinhvien.DataSource = dt;
        }
    }
}