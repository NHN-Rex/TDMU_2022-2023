namespace Hotel_manager.Child_Form
{
    partial class Form_DanhSachThuePhong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLuu = new Button();
            btnThem = new Button();
            btnTim = new Button();
            label5 = new Label();
            panel2 = new Panel();
            btnGiahan = new Button();
            label1 = new Label();
            cbbKhachhang = new ComboBox();
            panel1 = new Panel();
            ckbTrangthai = new CheckBox();
            dtpNgaythue = new DateTimePicker();
            button1 = new Button();
            label7 = new Label();
            label4 = new Label();
            label6 = new Label();
            txtThoigianthue = new TextBox();
            txtID = new TextBox();
            cbbPhong = new ComboBox();
            grvThuephong = new DataGridView();
            label2 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grvThuephong).BeginInit();
            SuspendLayout();
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.None;
            btnLuu.Enabled = false;
            btnLuu.Location = new Point(255, 30);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(74, 31);
            btnLuu.TabIndex = 88;
            btnLuu.Text = "Xác Nhận";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.None;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(95, 30);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(74, 31);
            btnThem.TabIndex = 87;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnTim
            // 
            btnTim.Anchor = AnchorStyles.None;
            btnTim.Location = new Point(380, 17);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(38, 26);
            btnTim.TabIndex = 95;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 81);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 93;
            label5.Text = "Tên Phòng";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnLuu);
            panel2.Controls.Add(btnGiahan);
            panel2.Controls.Add(btnThem);
            panel2.Location = new Point(456, 154);
            panel2.Name = "panel2";
            panel2.Size = new Size(332, 66);
            panel2.TabIndex = 90;
            panel2.Click += Form_DanhSachThuePhong_Load;
            // 
            // btnGiahan
            // 
            btnGiahan.Anchor = AnchorStyles.None;
            btnGiahan.ImageAlign = ContentAlignment.MiddleLeft;
            btnGiahan.Location = new Point(175, 30);
            btnGiahan.Name = "btnGiahan";
            btnGiahan.Size = new Size(74, 31);
            btnGiahan.TabIndex = 87;
            btnGiahan.Text = "Gia Hạn";
            btnGiahan.UseVisualStyleBackColor = true;
            btnGiahan.Click += btnGiahan_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(2, 52);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 89;
            label1.Text = "Khách Hàng";
            // 
            // cbbKhachhang
            // 
            cbbKhachhang.Anchor = AnchorStyles.None;
            cbbKhachhang.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbbKhachhang.FormattingEnabled = true;
            cbbKhachhang.Location = new Point(104, 49);
            cbbKhachhang.Name = "cbbKhachhang";
            cbbKhachhang.Size = new Size(270, 23);
            cbbKhachhang.TabIndex = 88;
            // 
            // panel1
            // 
            panel1.Controls.Add(ckbTrangthai);
            panel1.Controls.Add(dtpNgaythue);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnTim);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtThoigianthue);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbbPhong);
            panel1.Controls.Add(cbbKhachhang);
            panel1.Location = new Point(12, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(434, 170);
            panel1.TabIndex = 89;
            panel1.Click += Form_DanhSachThuePhong_Load;
            // 
            // ckbTrangthai
            // 
            ckbTrangthai.AutoSize = true;
            ckbTrangthai.Location = new Point(314, 147);
            ckbTrangthai.Name = "ckbTrangthai";
            ckbTrangthai.Size = new Size(104, 19);
            ckbTrangthai.TabIndex = 91;
            ckbTrangthai.Text = "Đã Thanh Toán";
            ckbTrangthai.UseVisualStyleBackColor = true;
            // 
            // dtpNgaythue
            // 
            dtpNgaythue.Format = DateTimePickerFormat.Short;
            dtpNgaythue.Location = new Point(104, 110);
            dtpNgaythue.Name = "dtpNgaythue";
            dtpNgaythue.Size = new Size(89, 23);
            dtpNgaythue.TabIndex = 97;
            dtpNgaythue.Value = new DateTime(2023, 6, 20, 1, 44, 27, 0);
            dtpNgaythue.ValueChanged += dtpNgaythue_ValueChanged;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(380, 46);
            button1.Name = "button1";
            button1.Size = new Size(38, 26);
            button1.TabIndex = 95;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(198, 112);
            label7.Name = "label7";
            label7.Size = new Size(156, 20);
            label7.TabIndex = 93;
            label7.Text = "Thời Gian Thuê (Giờ)";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(13, 113);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 93;
            label4.Text = "Ngày Thuê";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(72, 23);
            label6.Name = "label6";
            label6.Size = new Size(26, 20);
            label6.TabIndex = 93;
            label6.Text = "ID";
            // 
            // txtThoigianthue
            // 
            txtThoigianthue.Anchor = AnchorStyles.None;
            txtThoigianthue.Location = new Point(360, 110);
            txtThoigianthue.Name = "txtThoigianthue";
            txtThoigianthue.Size = new Size(58, 23);
            txtThoigianthue.TabIndex = 87;
            // 
            // txtID
            // 
            txtID.Anchor = AnchorStyles.None;
            txtID.Location = new Point(104, 20);
            txtID.Name = "txtID";
            txtID.Size = new Size(270, 23);
            txtID.TabIndex = 87;
            // 
            // cbbPhong
            // 
            cbbPhong.Anchor = AnchorStyles.None;
            cbbPhong.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbbPhong.FormattingEnabled = true;
            cbbPhong.Location = new Point(104, 78);
            cbbPhong.Name = "cbbPhong";
            cbbPhong.Size = new Size(314, 23);
            cbbPhong.TabIndex = 88;
            // 
            // grvThuephong
            // 
            grvThuephong.AllowUserToOrderColumns = true;
            grvThuephong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grvThuephong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grvThuephong.BackgroundColor = SystemColors.ButtonFace;
            grvThuephong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grvThuephong.Location = new Point(12, 226);
            grvThuephong.MultiSelect = false;
            grvThuephong.Name = "grvThuephong";
            grvThuephong.RowTemplate.Height = 25;
            grvThuephong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grvThuephong.Size = new Size(776, 220);
            grvThuephong.TabIndex = 87;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(279, 9);
            label2.Name = "label2";
            label2.Size = new Size(260, 25);
            label2.TabIndex = 88;
            label2.Text = "Quản Lý Tác Vụ Thuê Phòng";
            // 
            // Form_DanhSachThuePhong
            // 
            AcceptButton = btnLuu;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 153, 204);
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(grvThuephong);
            Name = "Form_DanhSachThuePhong";
            Text = "Form_ThuePhong";
            Load += Form_DanhSachThuePhong_Load;
            Click += Form_DanhSachThuePhong_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grvThuephong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLuu;
        private Button btnThem;
        private Button btnTim;
        private Label label5;
        private Panel panel2;
        private Label label1;
        private ComboBox cbbKhachhang;
        private Panel panel1;
        private DataGridView grvThuephong;
        private Label label2;
        private Label label4;
        private DateTimePicker dtpNgaythue;
        private Label label6;
        private TextBox txtID;
        private Label label7;
        private ComboBox cbbPhong;
        private TextBox txtThoigianthue;
        private Button button1;
        private Button btnGiahan;
        private CheckBox ckbTrangthai;
    }
}