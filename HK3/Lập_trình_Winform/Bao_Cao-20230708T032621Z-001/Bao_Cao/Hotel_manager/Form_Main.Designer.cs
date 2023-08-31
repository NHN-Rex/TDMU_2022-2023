namespace Hotel_manager
{
    partial class Form_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            pntop = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ptbminimize = new PictureBox();
            ptbstate = new PictureBox();
            ptbclose = new PictureBox();
            pnright = new Panel();
            pnbottom = new Panel();
            pnleft = new Panel();
            grbcontent = new GroupBox();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            khoáMànHìnhToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem1 = new ToolStripMenuItem();
            danhMụcToolStripMenuItem = new ToolStripMenuItem();
            phòngToolStripMenuItem = new ToolStripMenuItem();
            danhSáchPhòngToolStripMenuItem = new ToolStripMenuItem();
            loạiPhòngToolStripMenuItem = new ToolStripMenuItem();
            quảnLýKháchHàngToolStripMenuItem = new ToolStripMenuItem();
            nhânViênToolStripMenuItem = new ToolStripMenuItem();
            tàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            vịTríViệcLàmToolStripMenuItem = new ToolStripMenuItem();
            tácVụToolStripMenuItem = new ToolStripMenuItem();
            thuêPhòngToolStripMenuItem = new ToolStripMenuItem();
            trảPhòngToolStripMenuItem = new ToolStripMenuItem();
            thốngKêToolStripMenuItem = new ToolStripMenuItem();
            phòngĐangThuêToolStripMenuItem = new ToolStripMenuItem();
            doanhThuToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pntop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbminimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbstate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbclose).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pntop
            // 
            pntop.Controls.Add(pictureBox1);
            pntop.Controls.Add(label1);
            pntop.Controls.Add(ptbminimize);
            pntop.Controls.Add(ptbstate);
            pntop.Controls.Add(ptbclose);
            pntop.Dock = DockStyle.Top;
            pntop.Location = new Point(0, 0);
            pntop.Name = "pntop";
            pntop.Size = new Size(928, 30);
            pntop.TabIndex = 0;
            pntop.MouseDoubleClick += pntop_MouseDoubleClick;
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
            // ptbminimize
            // 
            ptbminimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ptbminimize.Cursor = Cursors.Hand;
            ptbminimize.Image = Properties.Resources.icons8_minimize_30;
            ptbminimize.Location = new Point(847, 8);
            ptbminimize.Name = "ptbminimize";
            ptbminimize.Size = new Size(19, 20);
            ptbminimize.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbminimize.TabIndex = 0;
            ptbminimize.TabStop = false;
            ptbminimize.Click += ptbminimize_Click;
            // 
            // ptbstate
            // 
            ptbstate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ptbstate.Cursor = Cursors.Hand;
            ptbstate.Image = Properties.Resources.icons8_application_window_48;
            ptbstate.Location = new Point(872, 4);
            ptbstate.Name = "ptbstate";
            ptbstate.Size = new Size(19, 20);
            ptbstate.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbstate.TabIndex = 0;
            ptbstate.TabStop = false;
            ptbstate.Click += ptbstate_Click;
            // 
            // ptbclose
            // 
            ptbclose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ptbclose.Cursor = Cursors.Hand;
            ptbclose.Image = Properties.Resources.icons8_close_window_30;
            ptbclose.Location = new Point(897, 2);
            ptbclose.Name = "ptbclose";
            ptbclose.Size = new Size(21, 22);
            ptbclose.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbclose.TabIndex = 0;
            ptbclose.TabStop = false;
            ptbclose.Click += ptbclose_Click;
            // 
            // pnright
            // 
            pnright.Dock = DockStyle.Right;
            pnright.Location = new Point(918, 30);
            pnright.Name = "pnright";
            pnright.Size = new Size(10, 495);
            pnright.TabIndex = 0;
            pnright.Paint += pnright_Paint;
            // 
            // pnbottom
            // 
            pnbottom.Dock = DockStyle.Bottom;
            pnbottom.Location = new Point(0, 525);
            pnbottom.Name = "pnbottom";
            pnbottom.Size = new Size(928, 10);
            pnbottom.TabIndex = 0;
            pnbottom.Paint += pnbottom_Paint;
            // 
            // pnleft
            // 
            pnleft.Dock = DockStyle.Left;
            pnleft.Location = new Point(0, 30);
            pnleft.Name = "pnleft";
            pnleft.Size = new Size(10, 495);
            pnleft.TabIndex = 0;
            pnleft.Paint += pnleft_Paint;
            // 
            // grbcontent
            // 
            grbcontent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grbcontent.BackgroundImage = Properties.Resources.Vector_Hotel_PNG_Download_Image1;
            grbcontent.BackgroundImageLayout = ImageLayout.Zoom;
            grbcontent.Location = new Point(10, 30);
            grbcontent.Name = "grbcontent";
            grbcontent.Size = new Size(908, 495);
            grbcontent.TabIndex = 1;
            grbcontent.TabStop = false;
            grbcontent.Enter += grbcontent_Enter;
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { khoáMànHìnhToolStripMenuItem, thoátToolStripMenuItem1 });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(71, 20);
            hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // khoáMànHìnhToolStripMenuItem
            // 
            khoáMànHìnhToolStripMenuItem.Name = "khoáMànHìnhToolStripMenuItem";
            khoáMànHìnhToolStripMenuItem.ShowShortcutKeys = false;
            khoáMànHìnhToolStripMenuItem.Size = new Size(121, 22);
            khoáMànHìnhToolStripMenuItem.Text = "Đăng xuất";
            khoáMànHìnhToolStripMenuItem.Click += khoáMànHìnhToolStripMenuItem_Click;
            // 
            // thoátToolStripMenuItem1
            // 
            thoátToolStripMenuItem1.Name = "thoátToolStripMenuItem1";
            thoátToolStripMenuItem1.Size = new Size(121, 22);
            thoátToolStripMenuItem1.Text = "Thoát";
            thoátToolStripMenuItem1.Click += ThoátToolStripMenuItem1_Click;
            // 
            // danhMụcToolStripMenuItem
            // 
            danhMụcToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { phòngToolStripMenuItem, quảnLýKháchHàngToolStripMenuItem, nhânViênToolStripMenuItem, tàiKhoảnToolStripMenuItem, vịTríViệcLàmToolStripMenuItem });
            danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            danhMụcToolStripMenuItem.Size = new Size(74, 20);
            danhMụcToolStripMenuItem.Text = "Danh Mục";
            // 
            // phòngToolStripMenuItem
            // 
            phòngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { danhSáchPhòngToolStripMenuItem, loạiPhòngToolStripMenuItem });
            phòngToolStripMenuItem.Name = "phòngToolStripMenuItem";
            phòngToolStripMenuItem.Size = new Size(180, 22);
            phòngToolStripMenuItem.Text = "Quản lý phòng";
            // 
            // danhSáchPhòngToolStripMenuItem
            // 
            danhSáchPhòngToolStripMenuItem.Name = "danhSáchPhòngToolStripMenuItem";
            danhSáchPhòngToolStripMenuItem.Size = new Size(189, 22);
            danhSáchPhòngToolStripMenuItem.Text = "Danh sách phòng";
            danhSáchPhòngToolStripMenuItem.Click += danhSáchPhòngToolStripMenuItem_Click;
            // 
            // loạiPhòngToolStripMenuItem
            // 
            loạiPhòngToolStripMenuItem.Name = "loạiPhòngToolStripMenuItem";
            loạiPhòngToolStripMenuItem.Size = new Size(189, 22);
            loạiPhòngToolStripMenuItem.Text = "Danh sách loại phòng";
            loạiPhòngToolStripMenuItem.Click += loạiPhòngToolStripMenuItem_Click;
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            quảnLýKháchHàngToolStripMenuItem.Size = new Size(180, 22);
            quảnLýKháchHàngToolStripMenuItem.Text = "Quản lý khách hàng";
            quảnLýKháchHàngToolStripMenuItem.Click += quảnLýKháchHàngToolStripMenuItem_Click;
            // 
            // nhânViênToolStripMenuItem
            // 
            nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            nhânViênToolStripMenuItem.Size = new Size(180, 22);
            nhânViênToolStripMenuItem.Text = "Nhân viên";
            nhânViênToolStripMenuItem.Click += nhânViênToolStripMenuItem_Click_1;
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            tàiKhoảnToolStripMenuItem.Size = new Size(180, 22);
            tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            tàiKhoảnToolStripMenuItem.Click += tàiKhoảnToolStripMenuItem_Click_1;
            // 
            // vịTríViệcLàmToolStripMenuItem
            // 
            vịTríViệcLàmToolStripMenuItem.Name = "vịTríViệcLàmToolStripMenuItem";
            vịTríViệcLàmToolStripMenuItem.Size = new Size(180, 22);
            vịTríViệcLàmToolStripMenuItem.Text = "Vị trí việc làm";
            vịTríViệcLàmToolStripMenuItem.Click += vịTríViệcLàmToolStripMenuItem_Click;
            // 
            // tácVụToolStripMenuItem
            // 
            tácVụToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thuêPhòngToolStripMenuItem, trảPhòngToolStripMenuItem });
            tácVụToolStripMenuItem.Name = "tácVụToolStripMenuItem";
            tácVụToolStripMenuItem.Size = new Size(53, 20);
            tácVụToolStripMenuItem.Text = "Tác Vụ";
            // 
            // thuêPhòngToolStripMenuItem
            // 
            thuêPhòngToolStripMenuItem.Name = "thuêPhòngToolStripMenuItem";
            thuêPhòngToolStripMenuItem.Size = new Size(138, 22);
            thuêPhòngToolStripMenuItem.Text = "Thuê phòng";
            thuêPhòngToolStripMenuItem.Click += thuêPhòngToolStripMenuItem_Click;
            // 
            // trảPhòngToolStripMenuItem
            // 
            trảPhòngToolStripMenuItem.Name = "trảPhòngToolStripMenuItem";
            trảPhòngToolStripMenuItem.Size = new Size(138, 22);
            trảPhòngToolStripMenuItem.Text = "Trả phòng";
            trảPhòngToolStripMenuItem.Click += trảPhòngToolStripMenuItem_Click;
            // 
            // thốngKêToolStripMenuItem
            // 
            thốngKêToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { phòngĐangThuêToolStripMenuItem, doanhThuToolStripMenuItem });
            thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            thốngKêToolStripMenuItem.Size = new Size(69, 20);
            thốngKêToolStripMenuItem.Text = "Thống Kê";
            // 
            // phòngĐangThuêToolStripMenuItem
            // 
            phòngĐangThuêToolStripMenuItem.Name = "phòngĐangThuêToolStripMenuItem";
            phòngĐangThuêToolStripMenuItem.Size = new Size(200, 22);
            phòngĐangThuêToolStripMenuItem.Text = "Phòng đang thuê/trống";
            phòngĐangThuêToolStripMenuItem.Click += phòngĐangThuêToolStripMenuItem_Click;
            // 
            // doanhThuToolStripMenuItem
            // 
            doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            doanhThuToolStripMenuItem.Size = new Size(200, 22);
            doanhThuToolStripMenuItem.Text = "Doanh thu";
            doanhThuToolStripMenuItem.Click += doanhThuToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, danhMụcToolStripMenuItem, tácVụToolStripMenuItem, thốngKêToolStripMenuItem });
            menuStrip1.Location = new Point(10, 30);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(908, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 153, 204);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(928, 535);
            Controls.Add(menuStrip1);
            Controls.Add(grbcontent);
            Controls.Add(pnleft);
            Controls.Add(pnright);
            Controls.Add(pnbottom);
            Controls.Add(pntop);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phần Mềm Quản Lý Phòng Trọ";
            Load += Form_Main_Load;
            pntop.ResumeLayout(false);
            pntop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbminimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbstate).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbclose).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pntop;
        private Panel pnright;
        private Panel pnbottom;
        private Panel pnleft;
        private GroupBox grbcontent;
        private PictureBox ptbminimize;
        private PictureBox ptbstate;
        private PictureBox ptbclose;
        private Label label1;
        private PictureBox pictureBox1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem khoáMànHìnhToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem1;
        private ToolStripMenuItem danhMụcToolStripMenuItem;
        private ToolStripMenuItem phòngToolStripMenuItem;
        private ToolStripMenuItem danhSáchPhòngToolStripMenuItem;
        private ToolStripMenuItem loạiPhòngToolStripMenuItem;
        private ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private ToolStripMenuItem tácVụToolStripMenuItem;
        private ToolStripMenuItem thuêPhòngToolStripMenuItem;
        private ToolStripMenuItem trảPhòngToolStripMenuItem;
        private ToolStripMenuItem thốngKêToolStripMenuItem;
        private ToolStripMenuItem phòngĐangThuêToolStripMenuItem;
        private ToolStripMenuItem doanhThuToolStripMenuItem;
        private ToolStripMenuItem thôngTinToolStripMenuItem;
        private ToolStripMenuItem phiênBảnToolStripMenuItem;
        private ToolStripMenuItem bảnQuyềnToolStripMenuItem;
        private ToolStripMenuItem liênHệToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem nhânViênToolStripMenuItem;
        private ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem vịTríViệcLàmToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}