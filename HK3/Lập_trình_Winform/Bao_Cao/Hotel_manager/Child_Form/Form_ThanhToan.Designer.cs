namespace Hotel_manager.Child_Form
{
    partial class Form_ThanhToan
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
            pntop = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            ptbminimize = new PictureBox();
            ptbstate = new PictureBox();
            ptbclose = new PictureBox();
            groupBox1 = new GroupBox();
            btnHuy = new Button();
            btnXacnhan = new Button();
            txtTienkhachdua = new TextBox();
            lbTenphong = new Label();
            lbTenkhachhang = new Label();
            lbCanthanhtoan = new Label();
            lbTienthua = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lbNgaythanhtoan = new Label();
            label2 = new Label();
            pntop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbminimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbstate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbclose).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pnleft
            // 
            pnleft.Dock = DockStyle.Left;
            pnleft.Location = new Point(0, 30);
            pnleft.Name = "pnleft";
            pnleft.Size = new Size(10, 340);
            pnleft.TabIndex = 1;
            // 
            // pnright
            // 
            pnright.Dock = DockStyle.Right;
            pnright.Location = new Point(616, 30);
            pnright.Name = "pnright";
            pnright.Size = new Size(10, 340);
            pnright.TabIndex = 2;
            // 
            // pnbottom
            // 
            pnbottom.Dock = DockStyle.Bottom;
            pnbottom.Location = new Point(0, 370);
            pnbottom.Name = "pnbottom";
            pnbottom.Size = new Size(626, 10);
            pnbottom.TabIndex = 3;
            // 
            // pntop
            // 
            pntop.Controls.Add(pictureBox2);
            pntop.Controls.Add(pictureBox1);
            pntop.Controls.Add(pictureBox3);
            pntop.Controls.Add(label1);
            pntop.Controls.Add(pictureBox4);
            pntop.Controls.Add(ptbminimize);
            pntop.Controls.Add(ptbstate);
            pntop.Controls.Add(ptbclose);
            pntop.Dock = DockStyle.Top;
            pntop.Location = new Point(0, 0);
            pntop.Name = "pntop";
            pntop.Size = new Size(626, 30);
            pntop.TabIndex = 4;
            pntop.MouseDown += pntop_MouseDown;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.icons8_minimize_30;
            pictureBox2.Location = new Point(543, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(19, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += ptbminimize_Click;
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
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = Properties.Resources.icons8_application_window_48;
            pictureBox3.Location = new Point(568, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(19, 20);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            pictureBox3.Click += ptbstate_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(207, 6);
            label1.Name = "label1";
            label1.Size = new Size(212, 25);
            label1.TabIndex = 1;
            label1.Text = "Thanh Toán Phòng";
            label1.MouseDown += pntop_MouseDown;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = Properties.Resources.icons8_close_window_30;
            pictureBox4.Location = new Point(593, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(21, 22);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            pictureBox4.Click += ptbclose_Click;
            // 
            // ptbminimize
            // 
            ptbminimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ptbminimize.Cursor = Cursors.Hand;
            ptbminimize.Image = Properties.Resources.icons8_minimize_30;
            ptbminimize.Location = new Point(1273, 8);
            ptbminimize.Name = "ptbminimize";
            ptbminimize.Size = new Size(19, 20);
            ptbminimize.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbminimize.TabIndex = 0;
            ptbminimize.TabStop = false;
            // 
            // ptbstate
            // 
            ptbstate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ptbstate.Cursor = Cursors.Hand;
            ptbstate.Image = Properties.Resources.icons8_application_window_48;
            ptbstate.Location = new Point(1298, 4);
            ptbstate.Name = "ptbstate";
            ptbstate.Size = new Size(19, 20);
            ptbstate.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbstate.TabIndex = 0;
            ptbstate.TabStop = false;
            // 
            // ptbclose
            // 
            ptbclose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ptbclose.Cursor = Cursors.Hand;
            ptbclose.Image = Properties.Resources.icons8_close_window_30;
            ptbclose.Location = new Point(1323, 2);
            ptbclose.Name = "ptbclose";
            ptbclose.Size = new Size(21, 22);
            ptbclose.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbclose.TabIndex = 0;
            ptbclose.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnXacnhan);
            groupBox1.Controls.Add(txtTienkhachdua);
            groupBox1.Controls.Add(lbTenphong);
            groupBox1.Controls.Add(lbTenkhachhang);
            groupBox1.Controls.Add(lbCanthanhtoan);
            groupBox1.Controls.Add(lbTienthua);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lbNgaythanhtoan);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(10, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(606, 340);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // btnHuy
            // 
            btnHuy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHuy.Location = new Point(361, 285);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(100, 37);
            btnHuy.TabIndex = 92;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += ptbclose_Click;
            // 
            // btnXacnhan
            // 
            btnXacnhan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnXacnhan.Location = new Point(148, 285);
            btnXacnhan.Name = "btnXacnhan";
            btnXacnhan.Size = new Size(100, 37);
            btnXacnhan.TabIndex = 92;
            btnXacnhan.Text = "Xác Nhận";
            btnXacnhan.UseVisualStyleBackColor = true;
            btnXacnhan.Click += btnXacnhan_Click;
            // 
            // txtTienkhachdua
            // 
            txtTienkhachdua.Anchor = AnchorStyles.None;
            txtTienkhachdua.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtTienkhachdua.Location = new Point(330, 191);
            txtTienkhachdua.Name = "txtTienkhachdua";
            txtTienkhachdua.Size = new Size(131, 23);
            txtTienkhachdua.TabIndex = 91;
            txtTienkhachdua.KeyUp += txtTienkhachdua_KeyUp;
            // 
            // lbTenphong
            // 
            lbTenphong.Anchor = AnchorStyles.None;
            lbTenphong.AutoSize = true;
            lbTenphong.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbTenphong.Location = new Point(330, 115);
            lbTenphong.Name = "lbTenphong";
            lbTenphong.Size = new Size(95, 20);
            lbTenphong.TabIndex = 90;
            lbTenphong.Text = "Tên Phòng";
            // 
            // lbTenkhachhang
            // 
            lbTenkhachhang.Anchor = AnchorStyles.None;
            lbTenkhachhang.AutoSize = true;
            lbTenkhachhang.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbTenkhachhang.Location = new Point(330, 73);
            lbTenkhachhang.Name = "lbTenkhachhang";
            lbTenkhachhang.Size = new Size(152, 20);
            lbTenkhachhang.TabIndex = 90;
            lbTenkhachhang.Text = "Tên Khách Hàng: ";
            // 
            // lbCanthanhtoan
            // 
            lbCanthanhtoan.Anchor = AnchorStyles.None;
            lbCanthanhtoan.AutoSize = true;
            lbCanthanhtoan.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbCanthanhtoan.Location = new Point(330, 153);
            lbCanthanhtoan.Name = "lbCanthanhtoan";
            lbCanthanhtoan.Size = new Size(146, 20);
            lbCanthanhtoan.TabIndex = 90;
            lbCanthanhtoan.Text = "Cần Thanh Toán:";
            // 
            // lbTienthua
            // 
            lbTienthua.Anchor = AnchorStyles.None;
            lbTienthua.AutoSize = true;
            lbTienthua.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbTienthua.Location = new Point(330, 237);
            lbTienthua.Name = "lbTienthua";
            lbTienthua.Size = new Size(74, 20);
            lbTienthua.TabIndex = 90;
            lbTienthua.Text = ".............";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(148, 237);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 90;
            label6.Text = "Tiền Thừa:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(143, 194);
            label5.Name = "label5";
            label5.Size = new Size(126, 20);
            label5.TabIndex = 90;
            label5.Text = "Tiền Khách Đưa:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(143, 153);
            label4.Name = "label4";
            label4.Size = new Size(131, 20);
            label4.TabIndex = 90;
            label4.Text = "Cần Thanh Toán:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(148, 115);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 90;
            label3.Text = "Tên Phòng:";
            // 
            // lbNgaythanhtoan
            // 
            lbNgaythanhtoan.Anchor = AnchorStyles.None;
            lbNgaythanhtoan.AutoSize = true;
            lbNgaythanhtoan.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbNgaythanhtoan.Location = new Point(432, 25);
            lbNgaythanhtoan.Name = "lbNgaythanhtoan";
            lbNgaythanhtoan.Size = new Size(49, 20);
            lbNgaythanhtoan.TabIndex = 90;
            lbNgaythanhtoan.Text = "Ngày";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(148, 73);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 90;
            label2.Text = "Tên Khách Hàng: ";
            // 
            // Form_ThanhToan
            // 
            AcceptButton = btnXacnhan;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 153, 204);
            ClientSize = new Size(626, 380);
            Controls.Add(groupBox1);
            Controls.Add(pnleft);
            Controls.Add(pnright);
            Controls.Add(pnbottom);
            Controls.Add(pntop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_ThanhToan";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form_ThanhToan";
            Load += Form_ThanhToan_Load;
            pntop.ResumeLayout(false);
            pntop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbminimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbstate).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbclose).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnleft;
        private Panel pnright;
        private Panel pnbottom;
        private Panel pntop;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox ptbminimize;
        private PictureBox ptbstate;
        private PictureBox ptbclose;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private GroupBox groupBox1;
        private Label label2;
        private Label lbTenkhachhang;
        private Label label3;
        private Label lbTenphong;
        private Label label4;
        private Label lbCanthanhtoan;
        private Label label5;
        private TextBox txtTienkhachdua;
        private Label label6;
        private Label lbTienthua;
        private Label lbNgaythanhtoan;
        private Button btnHuy;
        private Button btnXacnhan;
    }
}