namespace Hotel_manager.Child_Form
{
    partial class Form_TaiKhoan
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
            grvTaikhoan = new DataGridView();
            panel2 = new Panel();
            btnXoa = new Button();
            btnXacnhan = new Button();
            btnCapnhat = new Button();
            btnThem = new Button();
            panel1 = new Panel();
            label8 = new Label();
            cbbVitri = new ComboBox();
            label7 = new Label();
            btnTim = new Button();
            label3 = new Label();
            label9 = new Label();
            txtIDtaikhoan = new TextBox();
            txtTendangnhap = new TextBox();
            txtMatkhau = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)grvTaikhoan).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // grvTaikhoan
            // 
            grvTaikhoan.AllowUserToOrderColumns = true;
            grvTaikhoan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grvTaikhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grvTaikhoan.BackgroundColor = SystemColors.ButtonFace;
            grvTaikhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grvTaikhoan.Location = new Point(12, 195);
            grvTaikhoan.MultiSelect = false;
            grvTaikhoan.Name = "grvTaikhoan";
            grvTaikhoan.RowTemplate.Height = 25;
            grvTaikhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grvTaikhoan.Size = new Size(776, 253);
            grvTaikhoan.TabIndex = 94;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnXacnhan);
            panel2.Controls.Add(btnCapnhat);
            panel2.Controls.Add(btnThem);
            panel2.Location = new Point(470, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(318, 100);
            panel2.TabIndex = 105;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(82, 61);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(74, 36);
            btnXoa.TabIndex = 104;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnXacnhan
            // 
            btnXacnhan.Enabled = false;
            btnXacnhan.Location = new Point(242, 61);
            btnXacnhan.Name = "btnXacnhan";
            btnXacnhan.Size = new Size(74, 36);
            btnXacnhan.TabIndex = 105;
            btnXacnhan.Text = "Xác Nhận";
            btnXacnhan.UseVisualStyleBackColor = true;
            btnXacnhan.Click += btnXacnhan_Click;
            // 
            // btnCapnhat
            // 
            btnCapnhat.Location = new Point(162, 60);
            btnCapnhat.Name = "btnCapnhat";
            btnCapnhat.Size = new Size(74, 36);
            btnCapnhat.TabIndex = 106;
            btnCapnhat.Text = "Cập nhật";
            btnCapnhat.UseVisualStyleBackColor = true;
            btnCapnhat.Click += btnCapnhat_Click;
            // 
            // btnThem
            // 
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(2, 61);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(74, 36);
            btnThem.TabIndex = 107;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label8);
            panel1.Controls.Add(cbbVitri);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnTim);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtIDtaikhoan);
            panel1.Controls.Add(txtTendangnhap);
            panel1.Controls.Add(txtMatkhau);
            panel1.Location = new Point(12, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(454, 134);
            panel1.TabIndex = 106;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(41, 109);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 108;
            label8.Text = "Mật khẩu";
            // 
            // cbbVitri
            // 
            cbbVitri.FormattingEnabled = true;
            cbbVitri.Location = new Point(231, 51);
            cbbVitri.Name = "cbbVitri";
            cbbVitri.Size = new Size(169, 23);
            cbbVitri.TabIndex = 110;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(0, 80);
            label7.Name = "label7";
            label7.Size = new Size(116, 20);
            label7.TabIndex = 108;
            label7.Text = "Tên đăng nhập";
            // 
            // btnTim
            // 
            btnTim.ImageAlign = ContentAlignment.MiddleLeft;
            btnTim.Location = new Point(406, 52);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(45, 23);
            btnTim.TabIndex = 100;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(16, 52);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 108;
            label3.Text = "Mã tài khoản";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(185, 52);
            label9.Name = "label9";
            label9.Size = new Size(40, 20);
            label9.TabIndex = 108;
            label9.Text = "Vị trí";
            // 
            // txtIDtaikhoan
            // 
            txtIDtaikhoan.Location = new Point(122, 52);
            txtIDtaikhoan.Name = "txtIDtaikhoan";
            txtIDtaikhoan.Size = new Size(57, 23);
            txtIDtaikhoan.TabIndex = 102;
            // 
            // txtTendangnhap
            // 
            txtTendangnhap.Location = new Point(122, 80);
            txtTendangnhap.Name = "txtTendangnhap";
            txtTendangnhap.Size = new Size(329, 23);
            txtTendangnhap.TabIndex = 102;
            // 
            // txtMatkhau
            // 
            txtMatkhau.Location = new Point(122, 107);
            txtMatkhau.Name = "txtMatkhau";
            txtMatkhau.Size = new Size(329, 23);
            txtMatkhau.TabIndex = 104;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(265, 9);
            label2.Name = "label2";
            label2.Size = new Size(273, 25);
            label2.TabIndex = 107;
            label2.Text = "Quản Lý Danh Sách Tài Khoản";
            // 
            // Form_TaiKhoan
            // 
            AcceptButton = btnXacnhan;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 153, 204);
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(grvTaikhoan);
            Name = "Form_TaiKhoan";
            Text = "Form_TaiKhoan";
            Load += Form_TaiKhoan_Load;
            ((System.ComponentModel.ISupportInitialize)grvTaikhoan).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grvTaikhoan;
        private Panel panel2;
        private Button btnXoa;
        private Button btnXacnhan;
        private Button btnCapnhat;
        private Button btnThem;
        private Panel panel1;
        private ComboBox cbbVitri;
        private Button btnTim;
        private TextBox txtTendangnhap;
        private TextBox txtMatkhau;
        private Label label2;
        private TextBox txtIDtaikhoan;
        private Label label8;
        private Label label7;
        private Label label3;
        private Label label9;
    }
}