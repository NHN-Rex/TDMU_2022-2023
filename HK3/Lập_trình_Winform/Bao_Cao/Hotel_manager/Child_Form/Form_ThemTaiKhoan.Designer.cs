namespace Hotel_manager.Child_Form
{
    partial class Form_ThemTaiKhoan
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
            pnleft = new Panel();
            pnright = new Panel();
            pnbottom = new Panel();
            ptbminimize = new PictureBox();
            ptbstate = new PictureBox();
            ptbclose = new PictureBox();
            pntop = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnHuy = new Button();
            btnXacnhan = new Button();
            label3 = new Label();
            label8 = new Label();
            cbbTennhanvien = new ComboBox();
            cbbVitri = new ComboBox();
            label1 = new Label();
            label7 = new Label();
            label4 = new Label();
            label9 = new Label();
            txtIDtaikhoan = new TextBox();
            txtTendangnhap = new TextBox();
            txtGmail = new TextBox();
            txtMatkhau = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ptbminimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbstate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbclose).BeginInit();
            pntop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pnleft
            // 
            pnleft.Dock = DockStyle.Left;
            pnleft.Location = new Point(0, 30);
            pnleft.Name = "pnleft";
            pnleft.Size = new Size(10, 357);
            pnleft.TabIndex = 1;
            // 
            // pnright
            // 
            pnright.Dock = DockStyle.Right;
            pnright.Location = new Point(661, 30);
            pnright.Name = "pnright";
            pnright.Size = new Size(10, 357);
            pnright.TabIndex = 2;
            // 
            // pnbottom
            // 
            pnbottom.Dock = DockStyle.Bottom;
            pnbottom.Location = new Point(0, 387);
            pnbottom.Name = "pnbottom";
            pnbottom.Size = new Size(671, 10);
            pnbottom.TabIndex = 3;
            // 
            // ptbminimize
            // 
            ptbminimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ptbminimize.Cursor = Cursors.Hand;
            ptbminimize.Image = Properties.Resources.icons8_minimize_30;
            ptbminimize.Location = new Point(589, 9);
            ptbminimize.Name = "ptbminimize";
            ptbminimize.Size = new Size(19, 20);
            ptbminimize.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbminimize.TabIndex = 4;
            ptbminimize.TabStop = false;
            ptbminimize.Click += ptbminimize_Click;
            // 
            // ptbstate
            // 
            ptbstate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ptbstate.Cursor = Cursors.Hand;
            ptbstate.Image = Properties.Resources.icons8_application_window_48;
            ptbstate.Location = new Point(614, 5);
            ptbstate.Name = "ptbstate";
            ptbstate.Size = new Size(19, 20);
            ptbstate.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbstate.TabIndex = 5;
            ptbstate.TabStop = false;
            ptbstate.Click += ptbstate_Click;
            // 
            // ptbclose
            // 
            ptbclose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ptbclose.Cursor = Cursors.Hand;
            ptbclose.Image = Properties.Resources.icons8_close_window_30;
            ptbclose.Location = new Point(639, 3);
            ptbclose.Name = "ptbclose";
            ptbclose.Size = new Size(21, 22);
            ptbclose.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbclose.TabIndex = 6;
            ptbclose.TabStop = false;
            ptbclose.Click += ptbclose_Click;
            // 
            // pntop
            // 
            pntop.Controls.Add(pictureBox1);
            pntop.Controls.Add(pictureBox2);
            pntop.Controls.Add(pictureBox3);
            pntop.Controls.Add(pictureBox4);
            pntop.Controls.Add(label2);
            pntop.Dock = DockStyle.Top;
            pntop.Location = new Point(0, 0);
            pntop.Name = "pntop";
            pntop.Size = new Size(671, 30);
            pntop.TabIndex = 7;
            pntop.MouseDown += pntop_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.Vector_Hotel_PNG_Download_Image;
            pictureBox1.Location = new Point(10, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.icons8_minimize_30;
            pictureBox2.Location = new Point(1318, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(19, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = Properties.Resources.icons8_application_window_48;
            pictureBox3.Location = new Point(1343, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(19, 20);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = Properties.Resources.icons8_close_window_30;
            pictureBox4.Location = new Point(1368, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(21, 22);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(246, 5);
            label2.Name = "label2";
            label2.Size = new Size(192, 25);
            label2.TabIndex = 108;
            label2.Text = "Thêm Tài Khoản Mới";
            label2.MouseDown += pntop_MouseDown;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnXacnhan);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cbbTennhanvien);
            groupBox1.Controls.Add(cbbVitri);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtIDtaikhoan);
            groupBox1.Controls.Add(txtTendangnhap);
            groupBox1.Controls.Add(txtGmail);
            groupBox1.Controls.Add(txtMatkhau);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(10, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(651, 357);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // btnHuy
            // 
            btnHuy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnHuy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHuy.Location = new Point(398, 236);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(122, 36);
            btnHuy.TabIndex = 122;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += ptbclose_Click;
            // 
            // btnXacnhan
            // 
            btnXacnhan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnXacnhan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnXacnhan.Location = new Point(185, 236);
            btnXacnhan.Name = "btnXacnhan";
            btnXacnhan.Size = new Size(122, 36);
            btnXacnhan.TabIndex = 123;
            btnXacnhan.Text = "Xác Nhận";
            btnXacnhan.UseVisualStyleBackColor = true;
            btnXacnhan.Click += btnXacnhan_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(130, 190);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 116;
            label3.Text = "Gmail";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(105, 154);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 117;
            label8.Text = "Mật khẩu";
            // 
            // cbbTennhanvien
            // 
            cbbTennhanvien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbbTennhanvien.FormattingEnabled = true;
            cbbTennhanvien.Location = new Point(185, 79);
            cbbTennhanvien.Name = "cbbTennhanvien";
            cbbTennhanvien.Size = new Size(334, 23);
            cbbTennhanvien.TabIndex = 121;
            // 
            // cbbVitri
            // 
            cbbVitri.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbbVitri.FormattingEnabled = true;
            cbbVitri.Location = new Point(294, 41);
            cbbVitri.Name = "cbbVitri";
            cbbVitri.Size = new Size(225, 23);
            cbbVitri.TabIndex = 121;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(72, 81);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 118;
            label1.Text = "Tên nhân viên";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(64, 114);
            label7.Name = "label7";
            label7.Size = new Size(116, 20);
            label7.TabIndex = 118;
            label7.Text = "Tên đăng nhập";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(80, 41);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 119;
            label4.Text = "Mã tài khoản";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(249, 41);
            label9.Name = "label9";
            label9.Size = new Size(40, 20);
            label9.TabIndex = 120;
            label9.Text = "Vị trí";
            // 
            // txtIDtaikhoan
            // 
            txtIDtaikhoan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtIDtaikhoan.Location = new Point(185, 42);
            txtIDtaikhoan.Name = "txtIDtaikhoan";
            txtIDtaikhoan.Size = new Size(62, 23);
            txtIDtaikhoan.TabIndex = 112;
            // 
            // txtTendangnhap
            // 
            txtTendangnhap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTendangnhap.Location = new Point(185, 115);
            txtTendangnhap.Name = "txtTendangnhap";
            txtTendangnhap.Size = new Size(334, 23);
            txtTendangnhap.TabIndex = 113;
            // 
            // txtGmail
            // 
            txtGmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtGmail.Location = new Point(185, 192);
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(334, 23);
            txtGmail.TabIndex = 114;
            // 
            // txtMatkhau
            // 
            txtMatkhau.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMatkhau.Location = new Point(185, 153);
            txtMatkhau.Name = "txtMatkhau";
            txtMatkhau.Size = new Size(334, 23);
            txtMatkhau.TabIndex = 115;
            // 
            // Form_ThemTaiKhoan
            // 
            AcceptButton = btnXacnhan;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 153, 204);
            ClientSize = new Size(671, 397);
            Controls.Add(groupBox1);
            Controls.Add(pnleft);
            Controls.Add(pnright);
            Controls.Add(pnbottom);
            Controls.Add(ptbminimize);
            Controls.Add(ptbstate);
            Controls.Add(ptbclose);
            Controls.Add(pntop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_ThemTaiKhoan";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form_ThemNhanVien";
            Load += Form_ThemTaiKhoan_Load;
            ((System.ComponentModel.ISupportInitialize)ptbminimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbstate).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbclose).EndInit();
            pntop.ResumeLayout(false);
            pntop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnleft;
        private Panel pnright;
        private Panel pnbottom;
        private PictureBox ptbminimize;
        private PictureBox ptbstate;
        private PictureBox ptbclose;
        private Panel pntop;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private Label label8;
        private ComboBox cbbVitri;
        private Label label7;
        private Label label4;
        private Label label9;
        private TextBox txtIDtaikhoan;
        private TextBox txtTendangnhap;
        private TextBox txtGmail;
        private TextBox txtMatkhau;
        private Button btnHuy;
        private Button btnXacnhan;
        private Label label1;
        private ComboBox cbbTennhanvien;
    }
}