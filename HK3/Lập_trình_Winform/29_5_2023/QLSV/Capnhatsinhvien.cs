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
    public partial class Form_Capnhatsinhvien : Form
    {
        public Form_Capnhatsinhvien()
        {
            InitializeComponent();
        }
        private void returned()
        {
            txtmasv.Text = null;
            txtquequan.Text = null;
            txttensv.Text = null;
            cbogioitinh.Text = null;
            cbogioitinh.ValueMember = null;
            cbolop.Text = null;
            txtmasv.Focus();
        }
        private ErrorProvider er = new ErrorProvider();
        private connectdata con = new connectdata();
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        private int kt = 0;
        SqlDataAdapter da = new SqlDataAdapter();
        private void Capnhatsinhvien_Load(object sender, EventArgs e)
        {

            dt = getdata().Tables["TBLSINHVIEN"];
            grvsinhvien.DataSource = dt;
            con.setcolumnnamegrv(grvsinhvien);
        }
        public class connectdata
        {
            private SqlConnection con;
            public SqlConnection connect() //Hàm kết nối
            {
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
        private DataSet getdata()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"Select MASV, TENSV, convert(datetime, NgaySinh, 103) as N'NGAYSINH', 
                               (CASE GIOITINH WHEN 1 THEN N'Nam' ELSE N'Nữ' END) AS N'GIOITINH',
                               QUEQUAN, MALOP FROM SINHVIEN";
            cmd.Connection = con.connect();
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            da.Fill(ds, "TBLSINHVIEN");
            return ds;
        }
        private void addtext(int i)
        {
            txtmasv.Text = grvsinhvien.Rows[i].Cells["MASV"].Value.ToString();
            txttensv.Text = grvsinhvien.Rows[i].Cells["TENSV"].Value.ToString();
            dtngaysinh.Text = grvsinhvien.Rows[i].Cells["NGAYSINH"].Value.ToString();
            cbogioitinh.Text = grvsinhvien.Rows[i].Cells["GIOITINH"].Value.ToString();
            txtquequan.Text = grvsinhvien.Rows[i].Cells["QUEQUAN"].Value.ToString();
            cbolop.Text = grvsinhvien.Rows[i].Cells[5].Value.ToString();
        }
        private void grvsinhvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 i = Convert.ToInt32(grvsinhvien.CurrentRow.Index);
            addtext(i);
        }

        private void addtenloptocbolop(int c)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select MALOP,TENLOP from LOP";
            cmd.Connection = con.connect();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            if (c == 0)
            {
                da.Fill(ds, "LOP");
                cbolop.DataSource = ds.Tables["LOP"];

            }
            cbolop.DisplayMember = "TENLOP";
            cbolop.ValueMember = "MALOP";
            cbolop.SelectedItem = "MALOP";
        }
        private void addgioitinhtocbogioitinh(int c)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select DISTINCT (CASE GIOITINH WHEN 1 THEN N'Nam' ELSE N'Nữ' END) AS N'GIOITINH' from SINHVIEN";
            cmd.Connection = con.connect();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            if (c == 0)
            {
                da.Fill(ds, "TBLGIOITINH");
                cbogioitinh.DataSource = ds.Tables["TBLGIOITINH"];
            }
            cbogioitinh.DisplayMember = "GIOITINH";
            cbogioitinh.ValueMember = "GIOITINH";
            cbogioitinh.SelectedItem = "GIOITINH";
        }

        private void enablecommand(bool kt)
        {
            btnthem.Enabled = kt;
            btnluu.Enabled = !kt;
            btnsua.Enabled = kt;
            btnthem.Enabled = kt;
            btnthoat.Enabled = kt;
        }
        private bool insert()
        {
            DataTable dtb = ds.Tables["TBLSINHVIEN"];
            DataRow row = dtb.NewRow();
            row["MASV"] = txtmasv.Text;
            row["TENSV"] = txttensv.Text;
            row["NGAYSINH"] = Convert.ToDateTime(dtngaysinh.Text);
            row["GIOITINH"] = cbogioitinh.Text;
            row["QUEQUAN"] = txtquequan.Text;
            row["MALOP"] = cbolop.SelectedValue;
            dtb.Rows.Add(row);
            SqlCommand cmd = new SqlCommand();
            /*cmd.CommandText = @"Insert into SINHVIEN values(@MASV,@TENSV,@NGAYSINH,@GIOITINH,@QUEQUAN,@MALOP)";
            cmd.Parameters.Add("@MASV", SqlDbType.NVarChar, 10, "MASV");
            cmd.Parameters.Add("@TENSV", SqlDbType.NVarChar, 30, "TENSV");
            cmd.Parameters.Add("@NGAYSINH", SqlDbType.DateTime, 10, "NGAYSINH");
            cmd.Parameters.Add("@GIOITINH", SqlDbType.Bit);
            if (cbogioitinh.Text == "Nam")
                cmd.Parameters["@GIOITINH"].Value = 0;
            else
                cmd.Parameters["@GIOITINH"].Value = 1;
            cmd.Parameters.Add("@QUEQUAN", SqlDbType.NVarChar, 50, "QUEQUAN");
            cmd.Parameters.Add("@MALOP", SqlDbType.NVarChar, 7, "MALOP");
            SqlDataAdapter da = new SqlDataAdapter();
            da.InsertCommand = cmd;*/
            cmd.Connection = con.connect();
            try
            {
                da.Update(dtb);
                return true;
            }
            catch { return false; }
        }
   
        private void insertSV()
        {
            if (txtmasv.Text == "")
            {
                er.SetError(txtmasv, "Mã sinh viên không để trống!");
                txtmasv.Focus();
            }
            else
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select MASV FROM SINHVIEN where MASV=@MASV";
                cmd.Parameters.Add("@MASV", SqlDbType.NVarChar, 10);
                cmd.Parameters["@MASV"].Value = Convert.ToString(txtmasv.Text);
                cmd.Connection = con.connect();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    er.SetError(txtmasv, "Mã sinh viên đã tồn tại!");
                    txtmasv.Focus();
                }
                else
                {
                    if (insert())
                        MessageBox.Show("Thêm thành công.");
                    else
                        MessageBox.Show("Thêm không thành công.");
                    enablecommand(true);
                }
            }
        }

        int c = 0;
        private void btnthem_Click(object sender, EventArgs e)
        {
            enablecommand(false);
            cbolop.Refresh();
            addtenloptocbolop(c);
            addgioitinhtocbogioitinh(c);
            returned();
            kt = 1;
            c += 1;

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            txtmasv.Enabled = false;
            enablecommand(false);
            kt = 2;
        }


        private void deleteSV()
        {
            DataRow row = ds.Tables["tblsinhvien"].Select("MASV = '" + txtmasv.Text + "'")[0]; 
            row.Delete();
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            try
            {
                da.Update(ds.Tables["tblsinhvien"]);
                MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Xóa không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự muốn xóa sinh viên có mã " + txtmasv.Text + " không???", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                deleteSV();
                returned();
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (kt == 1)
                insertSV();
            else if (kt == 2)
                updateSV();
        }
        private void updateSV()
        {
            DataRow row = ds.Tables["TBLSINHVIEN"].Select("MASV = '" + txtmasv.Text + "'")[0];
            row["TENSV"] = txttensv.Text;
            row["NGAYSINH"] = Convert.ToDateTime(dtngaysinh.Text);
            row["GIOITINH"] = cbogioitinh.Text;
            row["QUEQUAN"] = txtquequan.Text;
            row["MALOP"] = cbolop.Text;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"Update SINHVIEN set TENSV=@TENSV,
                                NGAYSINH=@NGAYSINH,GIOITINH=@GIOITINH,QUEQUAN=@QUEQUAN,
                                MALOP=@MALOP WHERE MASV=@MASV";
            cmd.Parameters.Add("@MASV", SqlDbType.NVarChar, 10);
            cmd.Parameters["@MASV"].Value = txtmasv.Text;
            cmd.Parameters.Add("@MALOP", SqlDbType.NVarChar, 7, "MALOP");
            cmd.Connection = con.connect();
            SqlDataAdapter da = new SqlDataAdapter();
            da.UpdateCommand = cmd;
            try
            {
                da.Update(ds.Tables["TBLSINHVIEN"]);
                MessageBox.Show("Sửa thành công.");
            }
            catch { MessageBox.Show("Sửa không thành công."); }
            txtmasv.Enabled = true;
            enablecommand(true);
        }
    }
}
