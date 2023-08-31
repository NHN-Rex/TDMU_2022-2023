namespace MDI_Form
{
    partial class Form1
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
            triangleToolStripMenuItem = new ToolStripMenuItem();
            fractionToolStripMenuItem = new ToolStripMenuItem();
            quadraticToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            grpcontent = new GroupBox();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            grpcontent.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { triangleToolStripMenuItem, fractionToolStripMenuItem, quadraticToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(748, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // triangleToolStripMenuItem
            // 
            triangleToolStripMenuItem.Name = "triangleToolStripMenuItem";
            triangleToolStripMenuItem.Size = new Size(60, 20);
            triangleToolStripMenuItem.Text = "Triangle";
            triangleToolStripMenuItem.Click += triangleToolStripMenuItem_Click;
            // 
            // fractionToolStripMenuItem
            // 
            fractionToolStripMenuItem.Name = "fractionToolStripMenuItem";
            fractionToolStripMenuItem.Size = new Size(62, 20);
            fractionToolStripMenuItem.Text = "Fraction";
            fractionToolStripMenuItem.Click += fractionToolStripMenuItem_Click;
            // 
            // quadraticToolStripMenuItem
            // 
            quadraticToolStripMenuItem.Name = "quadraticToolStripMenuItem";
            quadraticToolStripMenuItem.Size = new Size(71, 20);
            quadraticToolStripMenuItem.Text = "Quadratic";
            quadraticToolStripMenuItem.Click += quadraticToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(38, 20);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // grpcontent
            // 
            grpcontent.Controls.Add(label1);
            grpcontent.Dock = DockStyle.Fill;
            grpcontent.Location = new Point(0, 24);
            grpcontent.Name = "grpcontent";
            grpcontent.Size = new Size(748, 587);
            grpcontent.TabIndex = 1;
            grpcontent.TabStop = false;
            grpcontent.Text = "Nguyễn Hữu Nghĩa - 2124802050013";
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 23.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(736, 565);
            label1.TabIndex = 0;
            label1.Text = "Click vào bất kỳ đâu bạn muốn";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 611);
            Controls.Add(grpcontent);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            grpcontent.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem triangleToolStripMenuItem;
        private ToolStripMenuItem fractionToolStripMenuItem;
        private ToolStripMenuItem quadraticToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private GroupBox grpcontent;
        private Label label1;
    }
}