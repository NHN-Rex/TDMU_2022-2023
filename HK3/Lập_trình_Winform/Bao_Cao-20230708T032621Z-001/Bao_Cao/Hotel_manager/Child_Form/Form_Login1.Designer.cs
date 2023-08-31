namespace Hotel_manager.Child_Form
{
    partial class Form_Login1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login1));
            pntop = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            ptbminimize = new PictureBox();
            ptbstate = new PictureBox();
            ptbclose = new PictureBox();
            pnleft = new Panel();
            pnright = new Panel();
            pnbottom = new Panel();
            btnDangnhap = new Button();
            lbMatkhau = new Label();
            lbTendangnhap = new Label();
            txtMatkhau = new TextBox();
            txtTendangnhap = new TextBox();
            pictureBox5 = new PictureBox();
            groupBox1 = new GroupBox();
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            danhMụcToolStripMenuItem = new ToolStripMenuItem();
            tácVụToolStripMenuItem = new ToolStripMenuItem();
            hệThốngToolStripMenuItem1 = new ToolStripMenuItem();
            pntop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbminimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbstate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbclose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
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
            pntop.Size = new Size(928, 30);
            pntop.TabIndex = 13;
            pntop.MouseDoubleClick += pntop_MouseDoubleClick;
            pntop.MouseDown += pntop_MouseDown;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.icons8_minimize_30;
            pictureBox2.Location = new Point(850, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(19, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
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
            pictureBox3.Location = new Point(875, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(19, 20);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            pictureBox3.Click += ptbstate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(42, 9);
            label1.Name = "label1";
            label1.Size = new Size(236, 15);
            label1.TabIndex = 1;
            label1.Text = "PHẦN MỀM QUẢN LÝ KHÁCH SẠN GREEN";
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = Properties.Resources.icons8_close_window_30;
            pictureBox4.Location = new Point(900, 1);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(21, 22);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            pictureBox4.Click += ptbclose_Click;
            // 
            // ptbminimize
            // 
            ptbminimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ptbminimize.Cursor = Cursors.Hand;
            ptbminimize.Image = Properties.Resources.icons8_minimize_30;
            ptbminimize.Location = new Point(1595, 8);
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
            ptbstate.Location = new Point(1620, 4);
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
            ptbclose.Location = new Point(1645, 2);
            ptbclose.Name = "ptbclose";
            ptbclose.Size = new Size(21, 22);
            ptbclose.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbclose.TabIndex = 0;
            ptbclose.TabStop = false;
            // 
            // pnleft
            // 
            pnleft.Dock = DockStyle.Left;
            pnleft.Location = new Point(0, 30);
            pnleft.Name = "pnleft";
            pnleft.Size = new Size(10, 495);
            pnleft.TabIndex = 14;
            // 
            // pnright
            // 
            pnright.Dock = DockStyle.Right;
            pnright.Location = new Point(918, 30);
            pnright.Name = "pnright";
            pnright.Size = new Size(10, 495);
            pnright.TabIndex = 15;
            // 
            // pnbottom
            // 
            pnbottom.Dock = DockStyle.Bottom;
            pnbottom.Location = new Point(0, 525);
            pnbottom.Name = "pnbottom";
            pnbottom.Size = new Size(928, 10);
            pnbottom.TabIndex = 16;
            // 
            // btnDangnhap
            // 
            btnDangnhap.Anchor = AnchorStyles.None;
            btnDangnhap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDangnhap.Location = new Point(398, 433);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(156, 46);
            btnDangnhap.TabIndex = 20;
            btnDangnhap.Text = "Đăng Nhập";
            btnDangnhap.UseVisualStyleBackColor = true;
            btnDangnhap.Click += btnDangnhap_Click;
            // 
            // lbMatkhau
            // 
            lbMatkhau.Anchor = AnchorStyles.None;
            lbMatkhau.AutoSize = true;
            lbMatkhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbMatkhau.Location = new Point(262, 388);
            lbMatkhau.Name = "lbMatkhau";
            lbMatkhau.Size = new Size(76, 21);
            lbMatkhau.TabIndex = 22;
            lbMatkhau.Text = "Mật Khẩu";
            // 
            // lbTendangnhap
            // 
            lbTendangnhap.Anchor = AnchorStyles.None;
            lbTendangnhap.AutoSize = true;
            lbTendangnhap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbTendangnhap.Location = new Point(262, 352);
            lbTendangnhap.Name = "lbTendangnhap";
            lbTendangnhap.Size = new Size(116, 21);
            lbTendangnhap.TabIndex = 23;
            lbTendangnhap.Text = "Tên Đăng Nhập";
            // 
            // txtMatkhau
            // 
            txtMatkhau.Anchor = AnchorStyles.None;
            txtMatkhau.Location = new Point(384, 390);
            txtMatkhau.Name = "txtMatkhau";
            txtMatkhau.Size = new Size(192, 23);
            txtMatkhau.TabIndex = 19;
            txtMatkhau.UseSystemPasswordChar = true;
            // 
            // txtTendangnhap
            // 
            txtTendangnhap.Anchor = AnchorStyles.None;
            txtTendangnhap.Location = new Point(384, 352);
            txtTendangnhap.Name = "txtTendangnhap";
            txtTendangnhap.Size = new Size(192, 23);
            txtTendangnhap.TabIndex = 18;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.None;
            pictureBox5.Image = Properties.Resources.Vector_Hotel_PNG_Download_Image;
            pictureBox5.Location = new Point(343, 119);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(251, 227);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 21;
            pictureBox5.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(menuStrip1);
            groupBox1.Location = new Point(10, 14);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(0);
            groupBox1.Size = new Size(908, 510);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, danhMụcToolStripMenuItem, tácVụToolStripMenuItem, hệThốngToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 16);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(908, 24);
            menuStrip1.TabIndex = 18;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(71, 20);
            hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // danhMụcToolStripMenuItem
            // 
            danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            danhMụcToolStripMenuItem.Size = new Size(74, 20);
            danhMụcToolStripMenuItem.Text = "Danh Mục";
            // 
            // tácVụToolStripMenuItem
            // 
            tácVụToolStripMenuItem.Name = "tácVụToolStripMenuItem";
            tácVụToolStripMenuItem.Size = new Size(53, 20);
            tácVụToolStripMenuItem.Text = "Tác Vụ";
            // 
            // hệThốngToolStripMenuItem1
            // 
            hệThốngToolStripMenuItem1.Name = "hệThốngToolStripMenuItem1";
            hệThốngToolStripMenuItem1.Size = new Size(69, 20);
            hệThốngToolStripMenuItem1.Text = "Thống Kê";
            // 
            // Form_Login1
            // 
            AcceptButton = btnDangnhap;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 153, 204);
            ClientSize = new Size(928, 535);
            Controls.Add(btnDangnhap);
            Controls.Add(lbMatkhau);
            Controls.Add(lbTendangnhap);
            Controls.Add(txtMatkhau);
            Controls.Add(txtTendangnhap);
            Controls.Add(pictureBox5);
            Controls.Add(pnleft);
            Controls.Add(pnright);
            Controls.Add(pnbottom);
            Controls.Add(pntop);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Login1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_Login1";
            FormClosing += Form_Login1_FormClosing;
            Load += Form_Login1_Load;
            pntop.ResumeLayout(false);
            pntop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbminimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbstate).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbclose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pntop;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox ptbminimize;
        private PictureBox ptbstate;
        private PictureBox ptbclose;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Panel pnleft;
        private Panel pnright;
        private Panel pnbottom;
        private Button btnDangnhap;
        private Label lbMatkhau;
        private Label lbTendangnhap;
        private TextBox txtMatkhau;
        private TextBox txtTendangnhap;
        private PictureBox pictureBox5;
        private GroupBox groupBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem danhMụcToolStripMenuItem;
        private ToolStripMenuItem tácVụToolStripMenuItem;
        private ToolStripMenuItem hệThốngToolStripMenuItem1;
    }
}