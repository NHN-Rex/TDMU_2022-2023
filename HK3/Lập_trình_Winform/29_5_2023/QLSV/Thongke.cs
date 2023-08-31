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

namespace QLSV
{
    public partial class Form_Thongke : Form
    {
        public Form_Thongke()
        {
            InitializeComponent();
        }

        private void Thongke_Load(object sender, EventArgs e)
        {
            addtenloptocbolop();
            //con.setcolumnnamegrv(grvsinhvien);
            grvsinhvien.DataSource = getdata().Tables["SINHVIEN"];
        }
        public class connectdata
        {
            private SqlConnection con;
            public SqlConnection connect() //Hàm kết nối
            {
                //string strcon = @"server=minh;Database=QLSinhVien;uid=sa;pwd=sa;Integrated security=true";
                string strcon = @"Server = DESKTOP-IC4OH16\MSSQLSERVER01; Database = QUANLYSINHVIEN; Integrated Security = True;";
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
            public void setcolumnnamegrv(DataGridView grv)
            {
                grv.Columns["MASV"].HeaderText = "Mã sinh viên";
                grv.Columns["TENSV"].HeaderText = "Tên sinh viên";
                grv.Columns["NGAYSINH"].HeaderText = "Ngày sinh";
                grv.Columns["GIOITINH"].HeaderText = "Giới tính";
                grv.Columns["QUEQUAN"].HeaderText = "Quê quán";
                grv.Columns["MALOP"].HeaderText = "Mã lớp";

            }
        }
        private connectdata con = new connectdata();
        private void addtenloptocbolop()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select MALOP, TENLOP from LOP";
            cmd.Connection = con.connect();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            da.SelectCommand = cmd;
            da.Fill(ds, "LOP");
            cbolop.DataSource = ds.Tables["LOP"];
            cbolop.DisplayMember = "TENLOP";
            cbolop.ValueMember = "MALOP";
            cbolop.SelectedItem = "MALOP";
        }
        private DataSet getdata()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@MALOP", SqlDbType.NVarChar, 30);
            cmd.Parameters["@MALOP"].Value = cbolop.SelectedValue.ToString();
            cmd.CommandText = @"Select MASV,TENSV,convert(datetime,NGAYSINH,103)
                                as N'NGAYSINH', (CASE GioiTinh WHEN 1 THEN N'Nam' ELSE N'Nữ' END)
                               AS N'GIOITINH', QUEQUAN,MALOP FROM SINHVIEN where MALOP = @MALOP";
            cmd.Connection = con.connect();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds, "SINHVIEN");
            return ds;
        }

        private void cbolop_SelectedIndexChanged(object sender, EventArgs e)
        {
            grvsinhvien.DataSource = getdata().Tables["SINHVIEN"];
            lbtong.Text = "TỔNG SỐ SINH VIÊN: " + getdata().Tables["SINHVIEN"].Rows.Count.ToString();
        }
    }
}
