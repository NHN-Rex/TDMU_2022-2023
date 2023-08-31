namespace MDI
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
            menuStrip1 = new MenuStrip();
            nhậpThôngTinToolStripMenuItem = new ToolStripMenuItem();
            traCứuToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            grpcontent = new GroupBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { nhậpThôngTinToolStripMenuItem, traCứuToolStripMenuItem, thoátToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(884, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // nhậpThôngTinToolStripMenuItem
            // 
            nhậpThôngTinToolStripMenuItem.Name = "nhậpThôngTinToolStripMenuItem";
            nhậpThôngTinToolStripMenuItem.Size = new Size(104, 20);
            nhậpThôngTinToolStripMenuItem.Text = "Nhập Thông Tin";
            nhậpThôngTinToolStripMenuItem.Click += nhậpThôngTinToolStripMenuItem_Click;
            // 
            // traCứuToolStripMenuItem
            // 
            traCứuToolStripMenuItem.Name = "traCứuToolStripMenuItem";
            traCứuToolStripMenuItem.Size = new Size(59, 20);
            traCứuToolStripMenuItem.Text = "Tra Cứu";
            traCứuToolStripMenuItem.Click += traCứuToolStripMenuItem_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(49, 20);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // grpcontent
            // 
            grpcontent.BackgroundImage = Properties.Resources.He_thong_quan_ly_thong_tin_MIS;
            grpcontent.BackgroundImageLayout = ImageLayout.Stretch;
            grpcontent.Dock = DockStyle.Fill;
            grpcontent.Location = new Point(0, 24);
            grpcontent.Name = "grpcontent";
            grpcontent.Size = new Size(884, 467);
            grpcontent.TabIndex = 1;
            grpcontent.TabStop = false;
            grpcontent.Text = "Nguyễn Hữu Nghĩa - 2124802050013";
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 491);
            Controls.Add(grpcontent);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem nhậpThôngTinToolStripMenuItem;
        private ToolStripMenuItem traCứuToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private GroupBox grpcontent;
    }
}