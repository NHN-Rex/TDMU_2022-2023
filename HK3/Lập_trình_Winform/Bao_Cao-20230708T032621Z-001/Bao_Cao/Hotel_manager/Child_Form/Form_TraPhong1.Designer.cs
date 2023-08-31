namespace Hotel_manager.Child_Form
{
    partial class Form_TraPhong1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_TraPhong1));
            panel1 = new Panel();
            txtNgaytra = new TextBox();
            txtTenphong = new TextBox();
            txtTenloaiphong = new TextBox();
            txtKhachhang = new TextBox();
            ckbTrangthai = new CheckBox();
            btnTim = new Button();
            lbSotiencantra = new Label();
            label7 = new Label();
            label4 = new Label();
            label6 = new Label();
            txtSotienthanhtoan = new TextBox();
            txtID = new TextBox();
            txtNgaythue = new TextBox();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            btnLuu = new Button();
            btnTraphong = new Button();
            grvThuephong = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grvThuephong).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtNgaytra);
            panel1.Controls.Add(txtTenphong);
            panel1.Controls.Add(txtTenloaiphong);
            panel1.Controls.Add(txtKhachhang);
            panel1.Controls.Add(ckbTrangthai);
            panel1.Controls.Add(btnTim);
            panel1.Controls.Add(lbSotiencantra);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtSotienthanhtoan);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(txtNgaythue);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(24, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(601, 183);
            panel1.TabIndex = 90;
            // 
            // txtNgaytra
            // 
            txtNgaytra.Anchor = AnchorStyles.None;
            txtNgaytra.Location = new Point(321, 96);
            txtNgaytra.Name = "txtNgaytra";
            txtNgaytra.Size = new Size(119, 23);
            txtNgaytra.TabIndex = 87;
            // 
            // txtTenphong
            // 
            txtTenphong.Location = new Point(172, 67);
            txtTenphong.Name = "txtTenphong";
            txtTenphong.Size = new Size(268, 23);
            txtTenphong.TabIndex = 98;
            // 
            // txtTenloaiphong
            // 
            txtTenloaiphong.Location = new Point(106, 67);
            txtTenloaiphong.Name = "txtTenloaiphong";
            txtTenloaiphong.Size = new Size(60, 23);
            txtTenloaiphong.TabIndex = 98;
            // 
            // txtKhachhang
            // 
            txtKhachhang.Location = new Point(106, 38);
            txtKhachhang.Name = "txtKhachhang";
            txtKhachhang.Size = new Size(334, 23);
            txtKhachhang.TabIndex = 98;
            // 
            // ckbTrangthai
            // 
            ckbTrangthai.AutoSize = true;
            ckbTrangthai.Location = new Point(336, 133);
            ckbTrangthai.Name = "ckbTrangthai";
            ckbTrangthai.Size = new Size(104, 19);
            ckbTrangthai.TabIndex = 91;
            ckbTrangthai.Text = "Đã Thanh Toán";
            ckbTrangthai.UseVisualStyleBackColor = true;
            // 
            // btnTim
            // 
            btnTim.Anchor = AnchorStyles.None;
            btnTim.Location = new Point(402, 11);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(38, 23);
            btnTim.TabIndex = 95;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // lbSotiencantra
            // 
            lbSotiencantra.Anchor = AnchorStyles.None;
            lbSotiencantra.AutoSize = true;
            lbSotiencantra.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbSotiencantra.Location = new Point(14, 130);
            lbSotiencantra.Name = "lbSotiencantra";
            lbSotiencantra.Size = new Size(152, 20);
            lbSotiencantra.TabIndex = 93;
            lbSotiencantra.Text = "Số Tiền Thanh Toán";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(243, 96);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 93;
            label7.Text = "Ngày Trả";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(15, 96);
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
            label6.Location = new Point(74, 14);
            label6.Name = "label6";
            label6.Size = new Size(26, 20);
            label6.TabIndex = 93;
            label6.Text = "ID";
            // 
            // txtSotienthanhtoan
            // 
            txtSotienthanhtoan.Anchor = AnchorStyles.None;
            txtSotienthanhtoan.Location = new Point(172, 129);
            txtSotienthanhtoan.Name = "txtSotienthanhtoan";
            txtSotienthanhtoan.Size = new Size(158, 23);
            txtSotienthanhtoan.TabIndex = 87;
            // 
            // txtID
            // 
            txtID.Anchor = AnchorStyles.None;
            txtID.Location = new Point(106, 11);
            txtID.Name = "txtID";
            txtID.Size = new Size(290, 23);
            txtID.TabIndex = 87;
            // 
            // txtNgaythue
            // 
            txtNgaythue.Anchor = AnchorStyles.None;
            txtNgaythue.Location = new Point(106, 96);
            txtNgaythue.Name = "txtNgaythue";
            txtNgaythue.Size = new Size(119, 23);
            txtNgaythue.TabIndex = 87;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(45, 66);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 93;
            label5.Text = "Phòng";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 41);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 89;
            label1.Text = "Khách Hàng";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(286, 9);
            label2.Name = "label2";
            label2.Size = new Size(244, 25);
            label2.TabIndex = 91;
            label2.Text = "Quản Lý Tác Vụ Trả Phòng";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnLuu);
            panel2.Controls.Add(btnTraphong);
            panel2.Location = new Point(506, 158);
            panel2.Name = "panel2";
            panel2.Size = new Size(282, 66);
            panel2.TabIndex = 92;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.None;
            btnLuu.BackColor = Color.White;
            btnLuu.Enabled = false;
            btnLuu.FlatStyle = FlatStyle.System;
            btnLuu.Location = new Point(204, 32);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(74, 31);
            btnLuu.TabIndex = 88;
            btnLuu.Text = "Xác Nhận";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnTraphong
            // 
            btnTraphong.Anchor = AnchorStyles.None;
            btnTraphong.ImageAlign = ContentAlignment.MiddleLeft;
            btnTraphong.Location = new Point(124, 32);
            btnTraphong.Name = "btnTraphong";
            btnTraphong.Size = new Size(74, 31);
            btnTraphong.TabIndex = 87;
            btnTraphong.Text = "Trả Phòng";
            btnTraphong.UseVisualStyleBackColor = true;
            btnTraphong.Click += btnTraphong_Click;
            // 
            // grvThuephong
            // 
            grvThuephong.AllowUserToOrderColumns = true;
            grvThuephong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grvThuephong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grvThuephong.BackgroundColor = SystemColors.ButtonFace;
            grvThuephong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grvThuephong.Location = new Point(12, 230);
            grvThuephong.MultiSelect = false;
            grvThuephong.Name = "grvThuephong";
            grvThuephong.RowTemplate.Height = 25;
            grvThuephong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grvThuephong.Size = new Size(777, 220);
            grvThuephong.TabIndex = 93;
            // 
            // Form_TraPhong1
            // 
            AcceptButton = btnLuu;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 153, 204);
            ClientSize = new Size(801, 450);
            Controls.Add(grvThuephong);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_TraPhong1";
            Text = "Trả Phòng";
            Load += Form_TraPhong1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grvThuephong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private CheckBox ckbTrangthai;
        private Button btnTim;
        private Label label7;
        private Label label4;
        private Label label6;
        private TextBox txtNgaytra;
        private TextBox txtID;
        private Label label5;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Button btnLuu;
        private Button btnTraphong;
        private DataGridView grvThuephong;
        private TextBox txtKhachhang;
        private TextBox txtTenphong;
        private TextBox txtNgaythue;
        private Label lbSotiencantra;
        private TextBox txtSotienthanhtoan;
        private TextBox txtTenloaiphong;
    }
}