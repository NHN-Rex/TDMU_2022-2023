namespace Hotel_manager.Child_Form
{
    partial class Form_KhachHang_Dialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_KhachHang_Dialog));
            btnLuu = new Button();
            panel3 = new Panel();
            label2 = new Label();
            txtQueQuan = new TextBox();
            txtHovaten = new TextBox();
            txtSDT = new TextBox();
            txtHKTT = new TextBox();
            txtCCCD = new TextBox();
            label1 = new Label();
            label6 = new Label();
            label3 = new Label();
            label8 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.None;
            btnLuu.Location = new Point(3, 71);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(74, 27);
            btnLuu.TabIndex = 129;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(btnLuu);
            panel3.Location = new Point(474, 80);
            panel3.Name = "panel3";
            panel3.Size = new Size(77, 100);
            panel3.TabIndex = 135;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(194, 27);
            label2.Name = "label2";
            label2.Size = new Size(232, 25);
            label2.TabIndex = 133;
            label2.Text = "Thêm Khách Thuê Phòng";
            // 
            // txtQueQuan
            // 
            txtQueQuan.Location = new Point(90, 48);
            txtQueQuan.Name = "txtQueQuan";
            txtQueQuan.Size = new Size(124, 23);
            txtQueQuan.TabIndex = 126;
            // 
            // txtHovaten
            // 
            txtHovaten.Location = new Point(90, 19);
            txtHovaten.Name = "txtHovaten";
            txtHovaten.Size = new Size(122, 23);
            txtHovaten.TabIndex = 124;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(328, 18);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(124, 23);
            txtSDT.TabIndex = 125;
            // 
            // txtHKTT
            // 
            txtHKTT.Location = new Point(90, 74);
            txtHKTT.Name = "txtHKTT";
            txtHKTT.Size = new Size(362, 23);
            txtHKTT.TabIndex = 128;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(328, 47);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(124, 23);
            txtCCCD.TabIndex = 127;
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
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            panel2.Size = new Size(455, 100);
            panel2.TabIndex = 134;
            // 
            // Form_KhachHang_Dialog
            // 
            AcceptButton = btnLuu;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(102, 153, 204);
            ClientSize = new Size(563, 188);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_KhachHang_Dialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form_KhachHang_Dialog";
            Load += Form_KhachHang_Dialog_Load;
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLuu;
        private Panel panel3;
        private Label label2;
        private TextBox txtQueQuan;
        private TextBox txtHovaten;
        private TextBox txtSDT;
        private TextBox txtHKTT;
        private TextBox txtCCCD;
        private Label label1;
        private Label label6;
        private Label label3;
        private Label label8;
        private Label label7;
        private Panel panel2;
    }
}