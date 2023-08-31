namespace MDI.Child_Form
{
    partial class Form_Nhap
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
            panel1 = new Panel();
            cbbHsx = new ComboBox();
            txtDsp = new TextBox();
            txtGia = new TextBox();
            txtTsp = new TextBox();
            txtTs = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnThoat = new Button();
            btnGhitep = new Button();
            btnThem = new Button();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(cbbHsx);
            panel1.Controls.Add(txtDsp);
            panel1.Controls.Add(txtGia);
            panel1.Controls.Add(txtTsp);
            panel1.Controls.Add(txtTs);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(523, 281);
            panel1.TabIndex = 0;
            // 
            // cbbHsx
            // 
            cbbHsx.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbbHsx.FormattingEnabled = true;
            cbbHsx.Items.AddRange(new object[] { "HP", "DELL" });
            cbbHsx.Location = new Point(239, 17);
            cbbHsx.Name = "cbbHsx";
            cbbHsx.Size = new Size(241, 23);
            cbbHsx.TabIndex = 13;
            cbbHsx.Text = "HP";
            // 
            // txtDsp
            // 
            txtDsp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDsp.Location = new Point(239, 61);
            txtDsp.Name = "txtDsp";
            txtDsp.Size = new Size(241, 23);
            txtDsp.TabIndex = 0;
            // 
            // txtGia
            // 
            txtGia.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtGia.Location = new Point(239, 226);
            txtGia.Name = "txtGia";
            txtGia.RightToLeft = RightToLeft.Yes;
            txtGia.Size = new Size(241, 23);
            txtGia.TabIndex = 3;
            // 
            // txtTsp
            // 
            txtTsp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTsp.Location = new Point(239, 103);
            txtTsp.Name = "txtTsp";
            txtTsp.Size = new Size(241, 23);
            txtTsp.TabIndex = 1;
            // 
            // txtTs
            // 
            txtTs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTs.Location = new Point(239, 142);
            txtTs.Multiline = true;
            txtTs.Name = "txtTs";
            txtTs.Size = new Size(241, 70);
            txtTs.TabIndex = 2;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(24, 226);
            label5.Name = "label5";
            label5.Size = new Size(83, 24);
            label5.TabIndex = 4;
            label5.Text = "Giá Bán";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(24, 142);
            label4.Name = "label4";
            label4.Size = new Size(190, 24);
            label4.TabIndex = 5;
            label4.Text = "Thông Số Kỹ Thuật";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(24, 99);
            label3.Name = "label3";
            label3.Size = new Size(148, 24);
            label3.TabIndex = 6;
            label3.Text = "Tên Sản Phẩm";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(24, 57);
            label2.Name = "label2";
            label2.Size = new Size(161, 24);
            label2.TabIndex = 7;
            label2.Text = "Dòng Sản Phẩm";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 17);
            label1.Name = "label1";
            label1.Size = new Size(151, 24);
            label1.TabIndex = 8;
            label1.Text = "Hãng Sản Xuất";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(btnThoat);
            panel2.Controls.Add(btnGhitep);
            panel2.Controls.Add(btnThem);
            panel2.Location = new Point(11, 355);
            panel2.Name = "panel2";
            panel2.Size = new Size(524, 82);
            panel2.TabIndex = 17;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.None;
            btnThoat.BackColor = Color.Red;
            btnThoat.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(388, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(114, 77);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnGhitep
            // 
            btnGhitep.Anchor = AnchorStyles.None;
            btnGhitep.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnGhitep.Location = new Point(214, 3);
            btnGhitep.Name = "btnGhitep";
            btnGhitep.Size = new Size(114, 77);
            btnGhitep.TabIndex = 5;
            btnGhitep.Text = "Ghi Tệp";
            btnGhitep.UseVisualStyleBackColor = true;
            btnGhitep.Click += btnGhitep_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.None;
            btnThem.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.Location = new Point(23, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(114, 77);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(91, 9);
            label6.Name = "label6";
            label6.Size = new Size(379, 37);
            label6.TabIndex = 18;
            label6.Text = "Nhập Thông Tin Laptop";
            // 
            // Form_Nhap
            // 
            AcceptButton = btnGhitep;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 440);
            Controls.Add(label6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form_Nhap";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form_Nhap";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ComboBox cbbHsx;
        private TextBox txtDsp;
        private TextBox txtGia;
        private TextBox txtTsp;
        private TextBox txtTs;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Button btnThoat;
        private Button btnGhitep;
        private Button btnThem;
        private Label label6;
    }
}