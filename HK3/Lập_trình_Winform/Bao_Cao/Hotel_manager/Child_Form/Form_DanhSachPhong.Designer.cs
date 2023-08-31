namespace Hotel_manager.Child_Form
{
    partial class Form_DanhSachPhong
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
            label2 = new Label();
            grvPhong = new DataGridView();
            panel1 = new Panel();
            btnTim = new Button();
            ckbDangthue = new CheckBox();
            label3 = new Label();
            btnHientatcaphong = new Button();
            label4 = new Label();
            label5 = new Label();
            txtMaphong = new TextBox();
            txtTenphong = new TextBox();
            label1 = new Label();
            cbbLoaiphong = new ComboBox();
            panel2 = new Panel();
            btnLuu = new Button();
            btnXoa = new Button();
            btnCapnhat = new Button();
            btnThem = new Button();
            ((System.ComponentModel.ISupportInitialize)grvPhong).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(356, 5);
            label2.Name = "label2";
            label2.Size = new Size(169, 25);
            label2.TabIndex = 74;
            label2.Text = "Danh Sách Phòng";
            // 
            // grvPhong
            // 
            grvPhong.AllowUserToOrderColumns = true;
            grvPhong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grvPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grvPhong.BackgroundColor = SystemColors.ButtonFace;
            grvPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grvPhong.Location = new Point(12, 187);
            grvPhong.MultiSelect = false;
            grvPhong.Name = "grvPhong";
            grvPhong.RowTemplate.Height = 25;
            grvPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grvPhong.Size = new Size(776, 259);
            grvPhong.TabIndex = 72;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnTim);
            panel1.Controls.Add(ckbDangthue);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnHientatcaphong);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtMaphong);
            panel1.Controls.Add(txtTenphong);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbbLoaiphong);
            panel1.Location = new Point(12, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(423, 159);
            panel1.TabIndex = 85;
            panel1.Click += Form_DanhSachPhong_Load;
            // 
            // btnTim
            // 
            btnTim.Anchor = AnchorStyles.None;
            btnTim.Location = new Point(355, 59);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(38, 23);
            btnTim.TabIndex = 95;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // ckbDangthue
            // 
            ckbDangthue.Anchor = AnchorStyles.None;
            ckbDangthue.AutoSize = true;
            ckbDangthue.Location = new Point(132, 135);
            ckbDangthue.Name = "ckbDangthue";
            ckbDangthue.Size = new Size(81, 19);
            ckbDangthue.TabIndex = 94;
            ckbDangthue.Text = "Đang thuê";
            ckbDangthue.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(30, 57);
            label3.Name = "label3";
            label3.Size = new Size(81, 21);
            label3.TabIndex = 91;
            label3.Text = "Mã Phòng";
            // 
            // btnHientatcaphong
            // 
            btnHientatcaphong.Anchor = AnchorStyles.None;
            btnHientatcaphong.ImageAlign = ContentAlignment.MiddleLeft;
            btnHientatcaphong.Location = new Point(231, 131);
            btnHientatcaphong.Name = "btnHientatcaphong";
            btnHientatcaphong.Size = new Size(118, 25);
            btnHientatcaphong.TabIndex = 87;
            btnHientatcaphong.Text = "Hiện tất cả phòng";
            btnHientatcaphong.UseVisualStyleBackColor = true;
            btnHientatcaphong.Click += btnHientatcaphong_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(30, 131);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 92;
            label4.Text = "Trạng Thái";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(30, 100);
            label5.Name = "label5";
            label5.Size = new Size(82, 21);
            label5.TabIndex = 93;
            label5.Text = "Tên Phòng";
            // 
            // txtMaphong
            // 
            txtMaphong.Anchor = AnchorStyles.None;
            txtMaphong.Location = new Point(132, 59);
            txtMaphong.Name = "txtMaphong";
            txtMaphong.Size = new Size(217, 23);
            txtMaphong.TabIndex = 86;
            // 
            // txtTenphong
            // 
            txtTenphong.Anchor = AnchorStyles.None;
            txtTenphong.Location = new Point(132, 102);
            txtTenphong.Name = "txtTenphong";
            txtTenphong.Size = new Size(217, 23);
            txtTenphong.TabIndex = 87;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 22);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 89;
            label1.Text = "Loại Phòng";
            // 
            // cbbLoaiphong
            // 
            cbbLoaiphong.Anchor = AnchorStyles.None;
            cbbLoaiphong.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbbLoaiphong.FormattingEnabled = true;
            cbbLoaiphong.Location = new Point(132, 19);
            cbbLoaiphong.Name = "cbbLoaiphong";
            cbbLoaiphong.Size = new Size(217, 23);
            cbbLoaiphong.TabIndex = 88;
            cbbLoaiphong.SelectedIndexChanged += cbbLoaiphong_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnLuu);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnCapnhat);
            panel2.Controls.Add(btnThem);
            panel2.Location = new Point(441, 116);
            panel2.Name = "panel2";
            panel2.Size = new Size(347, 66);
            panel2.TabIndex = 86;
            panel2.Click += Form_DanhSachPhong_Load;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.None;
            btnLuu.Enabled = false;
            btnLuu.Location = new Point(273, 37);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(74, 27);
            btnLuu.TabIndex = 88;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.None;
            btnXoa.Location = new Point(113, 38);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(74, 25);
            btnXoa.TabIndex = 85;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnCapnhat
            // 
            btnCapnhat.Anchor = AnchorStyles.None;
            btnCapnhat.Location = new Point(193, 38);
            btnCapnhat.Name = "btnCapnhat";
            btnCapnhat.Size = new Size(74, 25);
            btnCapnhat.TabIndex = 86;
            btnCapnhat.Text = "Cập nhật";
            btnCapnhat.UseVisualStyleBackColor = true;
            btnCapnhat.Click += btnCapnhat_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.None;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(33, 38);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(74, 25);
            btnThem.TabIndex = 87;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // Form_DanhSachPhong
            // 
            AcceptButton = btnLuu;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 153, 204);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(grvPhong);
            Name = "Form_DanhSachPhong";
            Text = "Form_DanhSachPhong";
            Load += Form_DanhSachPhong_Load;
            Click += Form_DanhSachPhong_Load;
            ((System.ComponentModel.ISupportInitialize)grvPhong).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private DataGridView grvPhong;
        private Panel panel1;
        private Button btnTim;
        private CheckBox ckbDangthue;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMaphong;
        private TextBox txtTenphong;
        private Label label1;
        private ComboBox cbbLoaiphong;
        private Panel panel2;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnCapnhat;
        private Button btnThem;
        private Button btnHientatcaphong;
    }
}