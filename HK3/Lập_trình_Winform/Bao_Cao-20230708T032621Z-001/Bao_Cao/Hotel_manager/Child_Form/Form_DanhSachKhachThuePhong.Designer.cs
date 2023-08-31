namespace Hotel_manager.Child_Form
{
    partial class Form_DanhSachKhachThuePhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DanhSachKhachThuePhong));
            panel3 = new Panel();
            btnTim = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnCapnhat = new Button();
            btnThem = new Button();
            panel2 = new Panel();
            label7 = new Label();
            label8 = new Label();
            label3 = new Label();
            label6 = new Label();
            label1 = new Label();
            txtCCCD = new TextBox();
            txtHKTT = new TextBox();
            txtSDT = new TextBox();
            txtHovaten = new TextBox();
            txtQueQuan = new TextBox();
            label2 = new Label();
            grvKhachthuephong = new DataGridView();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grvKhachthuephong).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(btnTim);
            panel3.Controls.Add(btnLuu);
            panel3.Controls.Add(btnXoa);
            panel3.Controls.Add(btnCapnhat);
            panel3.Controls.Add(btnThem);
            panel3.Location = new Point(474, 80);
            panel3.Name = "panel3";
            panel3.Size = new Size(313, 100);
            panel3.TabIndex = 131;
            // 
            // btnTim
            // 
            btnTim.Anchor = AnchorStyles.None;
            btnTim.Location = new Point(0, 42);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(74, 25);
            btnTim.TabIndex = 130;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.None;
            btnLuu.Enabled = false;
            btnLuu.Location = new Point(240, 71);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(74, 27);
            btnLuu.TabIndex = 129;
            btnLuu.Text = "Xác Nhận";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.None;
            btnXoa.Location = new Point(80, 71);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(74, 25);
            btnXoa.TabIndex = 126;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnCapnhat
            // 
            btnCapnhat.Anchor = AnchorStyles.None;
            btnCapnhat.Location = new Point(160, 71);
            btnCapnhat.Name = "btnCapnhat";
            btnCapnhat.Size = new Size(74, 25);
            btnCapnhat.TabIndex = 127;
            btnCapnhat.Text = "Cập nhật";
            btnCapnhat.UseVisualStyleBackColor = true;
            btnCapnhat.Click += btnCapnhat_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.None;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(0, 71);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(74, 25);
            btnThem.TabIndex = 128;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtCCCD);
            panel2.Controls.Add(txtHKTT);
            panel2.Controls.Add(txtSDT);
            panel2.Controls.Add(txtHovaten);
            panel2.Controls.Add(txtQueQuan);
            panel2.Location = new Point(13, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(455, 102);
            panel2.TabIndex = 130;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(220, 47);
            label7.Name = "label7";
            label7.Size = new Size(104, 21);
            label7.TabIndex = 131;
            label7.Text = "CCCD/CMND";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(9, 70);
            label8.Name = "label8";
            label8.Size = new Size(46, 21);
            label8.TabIndex = 130;
            label8.Text = "HKTT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(9, 21);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 129;
            label3.Text = "Họ và Tên";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(216, 21);
            label6.Name = "label6";
            label6.Size = new Size(106, 21);
            label6.TabIndex = 133;
            label6.Text = "Số Điện Thoại";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(9, 50);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 132;
            label1.Text = "Quê Quán";
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(328, 47);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(124, 23);
            txtCCCD.TabIndex = 127;
            // 
            // txtHKTT
            // 
            txtHKTT.Location = new Point(90, 74);
            txtHKTT.Name = "txtHKTT";
            txtHKTT.Size = new Size(362, 23);
            txtHKTT.TabIndex = 128;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(328, 18);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(124, 23);
            txtSDT.TabIndex = 125;
            // 
            // txtHovaten
            // 
            txtHovaten.Location = new Point(90, 19);
            txtHovaten.Name = "txtHovaten";
            txtHovaten.Size = new Size(122, 23);
            txtHovaten.TabIndex = 124;
            // 
            // txtQueQuan
            // 
            txtQueQuan.Location = new Point(90, 48);
            txtQueQuan.Name = "txtQueQuan";
            txtQueQuan.Size = new Size(124, 23);
            txtQueQuan.TabIndex = 126;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(272, 13);
            label2.Name = "label2";
            label2.Size = new Size(276, 25);
            label2.TabIndex = 129;
            label2.Text = "Danh Sách Khách Thuê Phòng";
            // 
            // grvKhachthuephong
            // 
            grvKhachthuephong.AllowUserToOrderColumns = true;
            grvKhachthuephong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grvKhachthuephong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grvKhachthuephong.BackgroundColor = SystemColors.ButtonFace;
            grvKhachthuephong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grvKhachthuephong.Location = new Point(13, 181);
            grvKhachthuephong.MultiSelect = false;
            grvKhachthuephong.Name = "grvKhachthuephong";
            grvKhachthuephong.RowTemplate.Height = 25;
            grvKhachthuephong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grvKhachthuephong.Size = new Size(774, 257);
            grvKhachthuephong.TabIndex = 128;
            // 
            // Form_DanhSachKhachThuePhong
            // 
            AcceptButton = btnLuu;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 153, 204);
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(grvKhachthuephong);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_DanhSachKhachThuePhong";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form_KhachThuePhong";
            Load += Form_KhachThuePhong_Load;
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grvKhachthuephong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private Button btnTim;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnCapnhat;
        private Button btnThem;
        private Panel panel2;
        private Label label7;
        private Label label8;
        private Label label3;
        private Label label6;
        private Label label1;
        private TextBox txtCCCD;
        private TextBox txtHKTT;
        private TextBox txtSDT;
        private TextBox txtHovaten;
        private TextBox txtQueQuan;
        private Label label2;
        private DataGridView grvKhachthuephong;
    }
}