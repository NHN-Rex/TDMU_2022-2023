namespace Hotel_manager.Child_Form
{
    partial class Form_DanhSachNhanVien
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
            grvNhanvien = new DataGridView();
            label2 = new Label();
            panel1 = new Panel();
            cbbVitri = new ComboBox();
            btnTim = new Button();
            txtTennhanvien = new TextBox();
            txtCCCD = new TextBox();
            txtDiachihientai = new TextBox();
            txtIDnhanvien = new TextBox();
            panel2 = new Panel();
            btnXoa = new Button();
            btnXacnhan = new Button();
            btnCapnhat = new Button();
            btnThem = new Button();
            label7 = new Label();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)grvNhanvien).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // grvNhanvien
            // 
            grvNhanvien.AllowUserToOrderColumns = true;
            grvNhanvien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grvNhanvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grvNhanvien.BackgroundColor = SystemColors.ButtonFace;
            grvNhanvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grvNhanvien.Location = new Point(12, 187);
            grvNhanvien.MultiSelect = false;
            grvNhanvien.Name = "grvNhanvien";
            grvNhanvien.ReadOnly = true;
            grvNhanvien.RowTemplate.Height = 25;
            grvNhanvien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grvNhanvien.Size = new Size(776, 263);
            grvNhanvien.TabIndex = 22;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(257, 9);
            label2.Name = "label2";
            label2.Size = new Size(280, 25);
            label2.TabIndex = 89;
            label2.Text = "Quản Lý Danh Sách Nhân Viên";
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(cbbVitri);
            panel1.Controls.Add(btnTim);
            panel1.Controls.Add(txtTennhanvien);
            panel1.Controls.Add(txtCCCD);
            panel1.Controls.Add(txtDiachihientai);
            panel1.Controls.Add(txtIDnhanvien);
            panel1.Location = new Point(12, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(365, 134);
            panel1.TabIndex = 104;
            panel1.Click += panel1_Click;
            // 
            // cbbVitri
            // 
            cbbVitri.FormattingEnabled = true;
            cbbVitri.Location = new Point(210, 15);
            cbbVitri.Name = "cbbVitri";
            cbbVitri.Size = new Size(103, 23);
            cbbVitri.TabIndex = 110;
            // 
            // btnTim
            // 
            btnTim.ImageAlign = ContentAlignment.MiddleLeft;
            btnTim.Location = new Point(319, 15);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(41, 23);
            btnTim.TabIndex = 100;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // txtTennhanvien
            // 
            txtTennhanvien.Location = new Point(114, 44);
            txtTennhanvien.Name = "txtTennhanvien";
            txtTennhanvien.Size = new Size(199, 23);
            txtTennhanvien.TabIndex = 102;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(114, 72);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(199, 23);
            txtCCCD.TabIndex = 103;
            // 
            // txtDiachihientai
            // 
            txtDiachihientai.Location = new Point(114, 101);
            txtDiachihientai.Name = "txtDiachihientai";
            txtDiachihientai.Size = new Size(199, 23);
            txtDiachihientai.TabIndex = 104;
            // 
            // txtIDnhanvien
            // 
            txtIDnhanvien.Location = new Point(114, 15);
            txtIDnhanvien.Name = "txtIDnhanvien";
            txtIDnhanvien.Size = new Size(50, 23);
            txtIDnhanvien.TabIndex = 101;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnXacnhan);
            panel2.Controls.Add(btnCapnhat);
            panel2.Controls.Add(btnThem);
            panel2.Location = new Point(383, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(405, 100);
            panel2.TabIndex = 104;
            panel2.Click += panel2_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(168, 63);
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
            btnXacnhan.Location = new Point(328, 63);
            btnXacnhan.Name = "btnXacnhan";
            btnXacnhan.Size = new Size(74, 36);
            btnXacnhan.TabIndex = 105;
            btnXacnhan.Text = "Xác Nhận";
            btnXacnhan.UseVisualStyleBackColor = true;
            btnXacnhan.Click += btnXacnhan_Click;
            // 
            // btnCapnhat
            // 
            btnCapnhat.Location = new Point(248, 62);
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
            btnThem.Location = new Point(88, 63);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(74, 36);
            btnThem.TabIndex = 107;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(164, 15);
            label7.Name = "label7";
            label7.Size = new Size(40, 20);
            label7.TabIndex = 105;
            label7.Text = "Vị trí";
            label7.Click += label7_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(5, 18);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 105;
            label5.Text = "Mã nhân viên";
            label5.Click += label7_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(0, 47);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 105;
            label3.Text = "Tên nhân viên";
            label3.Click += label7_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 75);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 105;
            label1.Text = "CCCD/CMND";
            label1.Click += label7_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(0, 104);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 105;
            label4.Text = "Địa chỉ hiện tại";
            label4.Click += label7_Click;
            // 
            // Form_DanhSachNhanVien
            // 
            AcceptButton = btnXacnhan;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 153, 204);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(grvNhanvien);
            Name = "Form_DanhSachNhanVien";
            Text = "Form_DanhSachNhanVien";
            Load += Form_DanhSachNhanVien_Load;
            Click += Form_DanhSachNhanVien_Click;
            ((System.ComponentModel.ISupportInitialize)grvNhanvien).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grvNhanvien;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private ComboBox cbbVitri;
        private Button btnTim;
        private TextBox txtTennhanvien;
        private TextBox txtCCCD;
        private TextBox txtDiachihientai;
        private TextBox txtIDnhanvien;
        private Button btnXoa;
        private Button btnXacnhan;
        private Button btnCapnhat;
        private Button btnThem;
        private Label label7;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label1;
    }
}