using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_manager.Child_Form
{
    public partial class Form_DanhSachPhong : Form
    {
        private ConnectDatabase conn = new ConnectDatabase();
        private DataSet ds = new DataSet();
        private int kt;
        public Form_DanhSachPhong()
        {
            InitializeComponent();
        }
        private void back()
        {
            txtTenphong.Text = string.Empty;
            txtMaphong.Text = string.Empty;
            ckbDangthue.Checked = false;
            txtMaphong.Focus();
        }

        private void enablecommand(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnCapnhat.Enabled = kt;
            btnThem.Enabled = kt;
            btnXoa.Enabled = kt;
            grvPhong.ReadOnly = kt;
            //Form_LoaiPhong.ac
        }
        private void addcbbLoaiphong()
        {
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select ID, TenLoaiPhong from tblLoaiPhong";
            cmd.Connection = conn.connect();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds, "LoaiPhong");
            cbbLoaiphong.DataSource = ds.Tables["LoaiPhong"];
            cbbLoaiphong.DisplayMember = "TenLoaiPhong";
            cbbLoaiphong.ValueMember = "ID";
        }

        private void loaddata()
        {
            var con = conn.connect();
            string sql = "Select tblPhong.ID as 'Mã Phòng', TenLoaiPhong as 'Tên Loại Phòng', TenPhong as 'Tên Phòng', " +
                " TrangThai as 'Trạng Thái'" +
                "FROM tblPhong, tblLoaiPhong where IDLoaiPhong = '" + cbbLoaiphong.SelectedValue.ToString() + "' and tblPhong.IDLoaiPhong = tblLoaiPhong.ID";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            grvPhong.DataSource = dt;
        }
        private void loadalldata()
        {
            var con = conn.connect();
            string sql = "Select tblPhong.ID as 'Mã Phòng', TenLoaiPhong as 'Tên Loại Phòng', TenPhong as 'Tên Phòng', TrangThai as 'Trạng Thái' FROM tblPhong, tblLoaiPhong Where tblPhong.IDLoaiPhong = tblLoaiPhong.ID";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            grvPhong.DataSource = dt;

        }


        private void Form_DanhSachPhong_Load(object sender, EventArgs e)
        {
            addcbbLoaiphong();
            loadalldata();

        }

        private void cbbLoaiphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaddata();
        }

        private void binding()
        {
            Int32 i = Convert.ToInt32(grvPhong.CurrentRow.Index);
            txtTenphong.DataBindings.Clear();
            txtTenphong.DataBindings.Add("Text", grvPhong.DataSource, "Tên Phòng");
            txtMaphong.DataBindings.Clear();
            txtMaphong.DataBindings.Add("Text", grvPhong.DataSource, "Mã Phòng");
            if (grvPhong.Rows[i].Cells["Trạng Thái"].Value.ToString() == "Đang thuê")
            {
                ckbDangthue.Checked = true;
            }
            else
            {
                ckbDangthue.Checked = false;
            }

        }

        private bool themphong()
        {
            if (string.IsNullOrEmpty(txtTenphong.Text))
            {
                MessageBox.Show("Vui lòng nhập tên phòng!",
                    "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbbLoaiphong.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại phòng!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            var con = conn.connect();
            string check;
            if (ckbDangthue.Checked)
            {
                check = "Đang thuê";
            }
            else check = "Còn trống";
            //MessageBox.Show(cbbLoaiphong.SelectedValue.ToString());
            string Check_exist_query = "SELECT ID FROM tblPhong WHERE ID = " + txtMaphong.Text;
            string Insert_query = "insert into tblPhong values" +
                "(" + int.Parse(txtMaphong.Text) + ", N'" + txtTenphong.Text + "', '" + cbbLoaiphong.SelectedValue.ToString() + "', N'" + check + "')";
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
            MessageBox.Show("ID đã tồn tại", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaphong.ReadOnly = true;
            back();
            Int32 i;
            if (grvPhong.Rows.Count >= 1)
            {
                i = 1;
            }
            else
            {
                i = Convert.ToInt32(grvPhong.CurrentRow.Index);
            }
            int id = int.Parse(grvPhong.RowCount.ToString());
            txtMaphong.Text = id.ToString();
            txtTenphong.Focus();
            enablecommand(false);
            kt = 1;
        }

        private bool xoaphong()
        {
            if (string.IsNullOrEmpty(txtMaphong.Text))
            {
                MessageBox.Show("Vui lòng nhập mã phòng!",
                    "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            var con = conn.connect();
            string Check_exist_query = "SELECT * FROM tblPhong WHERE ID = " + txtMaphong.Text;
            string Delete_query = "Delete from tblPhong where ID = " + txtMaphong.Text + " and TrangThai = N'Còn trống'";
            SqlCommand cmd = new SqlCommand(Check_exist_query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Close();
                cmd = new SqlCommand(Delete_query, con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    con.Close();
                    return true;
                }
            }
            con.Close();
            MessageBox.Show("ID Không tồn tại hoặc phòng đang được thuê", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            binding();
            if (MessageBox.Show("Bạn thực sự muốn xóa phòng có mã '" +
                txtMaphong.Text + "' không???", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                if (xoaphong())
                {
                    MessageBox.Show("Xoá phòng thành công", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            loaddata();
            back();
        }

        private bool capnhat()
        {
            string check;
            if (ckbDangthue.Checked)
            {
                check = "Đang thuê";
            }
            else
            {
                check = "Còn trống";
            }
            var con = conn.connect();
            string Update_query = "UPDATE tblPhong SET ID = '" + txtMaphong.Text +
                "', TenPhong = N'" + txtTenphong.Text +
                "', TrangThai = N'" + check + "'" +
                "WHERE ID = " + txtMaphong.Text;
            SqlCommand cmd = new SqlCommand(Update_query, con);
            if (cmd.ExecuteNonQuery() > 0)
            {
                con.Close();
                return true;
            }
            con.Close();
            return false;
        }
        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            binding();
            cbbLoaiphong.Enabled = false;
            grvPhong.Enabled = false;
            txtMaphong.ReadOnly = true;
            enablecommand(false);
            kt = 2;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (kt == 1)
            {
                if (themphong())
                {
                    MessageBox.Show("Thêm phòng thành công", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    enablecommand(true);
                    txtMaphong.ReadOnly = false;
                    loadalldata();
                    back();
                }
                else if (MessageBox.Show("Bạn muốn dừng thêm???", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    enablecommand(true);
            }
            else if (kt == 2)
            {
                if (capnhat())
                {
                    MessageBox.Show("Cập nhật phòng thành công", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    enablecommand(true);
                    txtMaphong.ReadOnly = false;
                    loadalldata();
                    cbbLoaiphong.Enabled = true;
                    grvPhong.Enabled = true;
                    back();
                }
            }
        }
        private void grvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            back();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaphong.Text) && string.IsNullOrEmpty(txtTenphong.Text))
            {
                MessageBox.Show("Vui lòng nhập mã phòng hoặc tên phòng!",
                    "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var con = conn.connect();
            string sql = "Select tblPhong.ID as 'Mã Phòng', TenLoaiPhong as 'Tên Loại Phòng', TenPhong as 'Tên Phòng', " +
                "IDLoaiPhong as 'Mã Loại Phòng', TrangThai as 'Trạng Thái'" +
                "FROM tblPhong, tblLoaiPhong " +
                "where (tblPhong.ID = '" + txtMaphong.Text + "' or TenPhong = N'" + txtTenphong.Text + "') and IDLoaiPhong = tblLoaiPhong.ID";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            grvPhong.DataSource = dt;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHientatcaphong_Click(object sender, EventArgs e)
        {
            loadalldata();
        }
    }
}
