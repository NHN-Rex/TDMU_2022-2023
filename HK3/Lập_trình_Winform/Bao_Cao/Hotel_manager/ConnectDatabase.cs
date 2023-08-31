using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_manager
{
    public class ConnectDatabase
    {
        private SqlConnection con;
        public SqlConnection connect() //Hàm kết nối
        {
            string strcon = @"Server = DESKTOP-UQ4VVGU; Database = Hotel_Management1; Integrated Security = True;";
            con = new SqlConnection(strcon);
            try
            {
                con.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Cannot connect to database! Lỗi: " +
                ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            return con;
        }
        public void disconnect() //Hàm ngắt kết nối
        {
            con.Close(); //Ngat ket noi
            con.Dispose(); //Giai phong doi tuong
        }
    }
}
