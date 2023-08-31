using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Hotel_manager
{
    public class Database
    {
        private String connectionString = @"Server = DESKTOP-IC4OH16\MSSQLSERVER01; Database = Hotel_Management; Integrated Security = True;";
        private SqlConnection conn;
        private DataTable dt;
        private SqlCommand cmd;

        public Database()
        {
            try
            {
                conn = new SqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connect failed: " + ex.Message);
            }
        }
        public DataTable SelectData(String sql, List<CustomParameter> lstPara = null)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                if(lstPara != null)
                {
                    foreach (var para in lstPara)
                    {
                        cmd.Parameters.AddWithValue(para.key, para.value);
                    }
                }
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load data failed: " + ex.Message, "Error");
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public int ExeCute(String sql, List<CustomParameter>lstPara)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach(var p in lstPara)
                {
                    cmd.Parameters.AddWithValue(p.key, p.value);
                }
                var rs = cmd.ExecuteNonQuery();
                return (int)rs;
            }
            catch(Exception ex)
            {
                MessageBox.Show("ExeCute failed: " + ex.Message,"Error");
                return -1;
            }
            finally { conn.Close(); }
        }
        public DataRow Select(String sql)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt.Rows[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show("Select failed: " + ex.Message,"Error");
                return null;
            }
            finally { conn.Close(); }
        }
    }

    

    public class CustomParameter
    {
        public string key { get; set; }
        public string value { get; set; }
    }
}
