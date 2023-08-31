namespace Hotel_manager.Child_Form
{
    partial class Form_DanhSachDichVu
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
            grvDichvu = new DataGridView();
            label2 = new Label();
            panel1 = new Panel();
            btnTim = new Button();
            label3 = new Label();
            label5 = new Label();
            txtMadichvu = new TextBox();
            txtTendichvu = new TextBox();
            panel2 = new Panel();
            btnLuu = new Button();
            btnXoa = new Button();
            btnCapnhat = new Button();
            btnThem = new Button();
            txtDongia = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)grvDichvu).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // grvDichvu
            // 
            grvDichvu.AllowUserToOrderColumns = true;
            grvDichvu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grvDichvu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grvDichvu.BackgroundColor = SystemColors.ButtonFace;
            grvDichvu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grvDichvu.Location = new Point(12, 188);
            grvDichvu.MultiSelect = false;
            grvDichvu.Name = "grvDichvu";
            grvDichvu.RowTemplate.Height = 25;
            grvDichvu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grvDichvu.Size = new Size(776, 259);
            grvDichvu.TabIndex = 23;
            grvDichvu.CellClick += grvPhong_CellClick;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(332, 27);
            label2.Name = "label2";
            label2.Size = new Size(179, 25);
            label2.TabIndex = 25;
            label2.Text = "Danh Sách Dịch Vụ";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnTim);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtMadichvu);
            panel1.Controls.Add(txtDongia);
            panel1.Controls.Add(txtTendichvu);
            panel1.Location = new Point(12, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(393, 100);
            panel1.TabIndex = 97;
            panel1.Click += Form_DichVu_Load;
            // 
            // btnTim
            // 
            btnTim.Anchor = AnchorStyles.None;
            btnTim.Location = new Point(340, 16);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(38, 25);
            btnTim.TabIndex = 102;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(15, 16);
            label3.Name = "label3";
            label3.Size = new Size(90, 21);
            label3.TabIndex = 100;
            label3.Text = "Mã Dịch Vụ";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(15, 45);
            label5.Name = "label5";
            label5.Size = new Size(91, 21);
            label5.TabIndex = 101;
            label5.Text = "Tên Dịch Vụ";
            // 
            // txtMadichvu
            // 
            txtMadichvu.Anchor = AnchorStyles.None;
            txtMadichvu.Location = new Point(117, 18);
            txtMadichvu.Name = "txtMadichvu";
            txtMadichvu.Size = new Size(217, 23);
            txtMadichvu.TabIndex = 98;
            // 
            // txtTendichvu
            // 
            txtTendichvu.Anchor = AnchorStyles.None;
            txtTendichvu.Location = new Point(117, 47);
            txtTendichvu.Name = "txtTendichvu";
            txtTendichvu.Size = new Size(217, 23);
            txtTendichvu.TabIndex = 99;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnLuu);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnCapnhat);
            panel2.Controls.Add(btnThem);
            panel2.Location = new Point(411, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(377, 100);
            panel2.TabIndex = 98;
            panel2.Click += Form_DichVu_Load;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.None;
            btnLuu.Enabled = false;
            btnLuu.Location = new Point(299, 71);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(74, 27);
            btnLuu.TabIndex = 100;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.None;
            btnXoa.Location = new Point(139, 72);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(74, 25);
            btnXoa.TabIndex = 97;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnCapnhat
            // 
            btnCapnhat.Anchor = AnchorStyles.None;
            btnCapnhat.Location = new Point(219, 72);
            btnCapnhat.Name = "btnCapnhat";
            btnCapnhat.Size = new Size(74, 25);
            btnCapnhat.TabIndex = 98;
            btnCapnhat.Text = "Cập nhật";
            btnCapnhat.UseVisualStyleBackColor = true;
            btnCapnhat.Click += btnCapnhat_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.None;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(59, 72);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(74, 25);
            btnThem.TabIndex = 99;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtDongia
            // 
            txtDongia.Anchor = AnchorStyles.None;
            txtDongia.Location = new Point(117, 75);
            txtDongia.Name = "txtDongia";
            txtDongia.Size = new Size(217, 23);
            txtDongia.TabIndex = 99;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 73);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 101;
            label1.Text = "Đơn Giá";
            // 
            // Form_DanhSachDichVu
            // 
            AcceptButton = btnLuu;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 153, 204);
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(grvDichvu);
            Name = "Form_DanhSachDichVu";
            Text = "Form_DichVu";
            Load += Form_DichVu_Load;
            Click += Form_DichVu_Load;
            ((System.ComponentModel.ISupportInitialize)grvDichvu).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grvDichvu;
        private Label label2;
        private Panel panel1;
        private Button btnTim;
        private Label label3;
        private Label label5;
        private TextBox txtMadichvu;
        private TextBox txtTendichvu;
        private Panel panel2;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnCapnhat;
        private Button btnThem;
        private Label label1;
        private TextBox txtDongia;
    }
}