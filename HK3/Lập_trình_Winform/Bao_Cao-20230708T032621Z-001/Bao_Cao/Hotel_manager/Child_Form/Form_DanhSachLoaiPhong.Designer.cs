namespace Hotel_manager.Child_Form
{
    partial class Form_DanhSachLoaiPhong
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
            lbquanlydanhmucloaiphong = new Label();
            grvLoaiPhong = new DataGridView();
            panel1 = new Panel();
            btnTim = new Button();
            txtKichthuoc = new TextBox();
            txtDongia = new TextBox();
            label1 = new Label();
            txtMaloaiphong = new TextBox();
            txtTenloaiphong = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            btnXoa = new Button();
            btnLuu = new Button();
            btnCapnhat = new Button();
            btnThem = new Button();
            ((System.ComponentModel.ISupportInitialize)grvLoaiPhong).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lbquanlydanhmucloaiphong
            // 
            lbquanlydanhmucloaiphong.Anchor = AnchorStyles.Top;
            lbquanlydanhmucloaiphong.AutoSize = true;
            lbquanlydanhmucloaiphong.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbquanlydanhmucloaiphong.Location = new Point(286, 21);
            lbquanlydanhmucloaiphong.Name = "lbquanlydanhmucloaiphong";
            lbquanlydanhmucloaiphong.Size = new Size(248, 25);
            lbquanlydanhmucloaiphong.TabIndex = 0;
            lbquanlydanhmucloaiphong.Text = "DANH SÁCH LOẠI PHÒNG";
            // 
            // grvLoaiPhong
            // 
            grvLoaiPhong.AllowUserToOrderColumns = true;
            grvLoaiPhong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grvLoaiPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grvLoaiPhong.BackgroundColor = SystemColors.ButtonFace;
            grvLoaiPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grvLoaiPhong.Location = new Point(12, 184);
            grvLoaiPhong.MultiSelect = false;
            grvLoaiPhong.Name = "grvLoaiPhong";
            grvLoaiPhong.RowTemplate.Height = 25;
            grvLoaiPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grvLoaiPhong.Size = new Size(776, 263);
            grvLoaiPhong.TabIndex = 21;
            grvLoaiPhong.CellClick += grvLoaiPhong_CellClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnTim);
            panel1.Controls.Add(txtKichthuoc);
            panel1.Controls.Add(txtDongia);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtMaloaiphong);
            panel1.Controls.Add(txtTenloaiphong);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(12, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(413, 129);
            panel1.TabIndex = 28;
            panel1.Click += Form_LoaiPhong_Load;
            // 
            // btnTim
            // 
            btnTim.Anchor = AnchorStyles.None;
            btnTim.ImageAlign = ContentAlignment.MiddleLeft;
            btnTim.Location = new Point(274, 19);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(41, 26);
            btnTim.TabIndex = 28;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // txtKichthuoc
            // 
            txtKichthuoc.Anchor = AnchorStyles.None;
            txtKichthuoc.Location = new Point(93, 76);
            txtKichthuoc.Name = "txtKichthuoc";
            txtKichthuoc.Size = new Size(174, 23);
            txtKichthuoc.TabIndex = 30;
            // 
            // txtDongia
            // 
            txtDongia.Anchor = AnchorStyles.None;
            txtDongia.Location = new Point(93, 105);
            txtDongia.Name = "txtDongia";
            txtDongia.Size = new Size(174, 23);
            txtDongia.TabIndex = 31;
            txtDongia.Text = "0";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(2, 79);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 32;
            label1.Text = "Kích thước";
            // 
            // txtMaloaiphong
            // 
            txtMaloaiphong.Anchor = AnchorStyles.None;
            txtMaloaiphong.Location = new Point(93, 19);
            txtMaloaiphong.Name = "txtMaloaiphong";
            txtMaloaiphong.Size = new Size(174, 23);
            txtMaloaiphong.TabIndex = 28;
            // 
            // txtTenloaiphong
            // 
            txtTenloaiphong.Anchor = AnchorStyles.None;
            txtTenloaiphong.Location = new Point(93, 47);
            txtTenloaiphong.Name = "txtTenloaiphong";
            txtTenloaiphong.Size = new Size(174, 23);
            txtTenloaiphong.TabIndex = 29;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(2, 22);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 34;
            label2.Text = "Mã Loại Phòng";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(2, 108);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 33;
            label3.Text = "Đơn giá";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(2, 50);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 35;
            label4.Text = "Tên loại phòng";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnLuu);
            panel2.Controls.Add(btnCapnhat);
            panel2.Controls.Add(btnThem);
            panel2.Location = new Point(431, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(357, 129);
            panel2.TabIndex = 29;
            panel2.Click += Form_LoaiPhong_Load;
            panel2.Paint += panel2_Paint;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.None;
            btnXoa.Location = new Point(123, 90);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(74, 36);
            btnXoa.TabIndex = 25;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.None;
            btnLuu.Enabled = false;
            btnLuu.Location = new Point(283, 90);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(74, 36);
            btnLuu.TabIndex = 26;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnCapnhat
            // 
            btnCapnhat.Anchor = AnchorStyles.None;
            btnCapnhat.Location = new Point(203, 89);
            btnCapnhat.Name = "btnCapnhat";
            btnCapnhat.Size = new Size(74, 36);
            btnCapnhat.TabIndex = 27;
            btnCapnhat.Text = "Cập nhật";
            btnCapnhat.UseVisualStyleBackColor = true;
            btnCapnhat.Click += btnCapnhat_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.None;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(43, 90);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(74, 36);
            btnThem.TabIndex = 28;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += tbnThem_Click;
            // 
            // Form_DanhSachLoaiPhong
            // 
            AcceptButton = btnLuu;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 153, 204);
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(grvLoaiPhong);
            Controls.Add(lbquanlydanhmucloaiphong);
            Name = "Form_DanhSachLoaiPhong";
            Text = "Form_LoaiPhong";
            Load += Form_LoaiPhong_Load;
            Click += Form_LoaiPhong_Load;
            ((System.ComponentModel.ISupportInitialize)grvLoaiPhong).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbquanlydanhmucloaiphong;
        private DataGridView grvLoaiPhong;
        private Panel panel1;
        private TextBox txtKichthuoc;
        private TextBox txtDongia;
        private Label label1;
        private TextBox txtMaloaiphong;
        private TextBox txtTenloaiphong;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel2;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnCapnhat;
        private Button btnThem;
        private Button btnTim;
    }
}