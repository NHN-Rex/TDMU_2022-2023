namespace Hotel_manager.Child_Form
{
    partial class Form_ThongKe
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            grvThongkephong = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            lbSophongtrong = new Label();
            pntop = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            pictureBox4 = new PictureBox();
            ptbminimize = new PictureBox();
            ptbstate = new PictureBox();
            ptbclose = new PictureBox();
            pnleft = new Panel();
            pnright = new Panel();
            pnbottom = new Panel();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)grvThongkephong).BeginInit();
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
            // grvThongkephong
            // 
            grvThongkephong.AllowUserToOrderColumns = true;
            grvThongkephong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grvThongkephong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grvThongkephong.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grvThongkephong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grvThongkephong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grvThongkephong.Location = new Point(6, 102);
            grvThongkephong.MultiSelect = false;
            grvThongkephong.Name = "grvThongkephong";
            grvThongkephong.RowTemplate.Height = 25;
            grvThongkephong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grvThongkephong.Size = new Size(676, 256);
            grvThongkephong.TabIndex = 22;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(224, 19);
            label2.Name = "label2";
            label2.Size = new Size(253, 25);
            label2.TabIndex = 107;
            label2.Text = "Thống Kê Số Lượng Phòng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(32, 66);
            label1.Name = "label1";
            label1.Size = new Size(170, 20);
            label1.TabIndex = 112;
            label1.Text = "Số lượng phòng trống: ";
            // 
            // lbSophongtrong
            // 
            lbSophongtrong.AutoSize = true;
            lbSophongtrong.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbSophongtrong.Location = new Point(208, 66);
            lbSophongtrong.Name = "lbSophongtrong";
            lbSophongtrong.Size = new Size(21, 20);
            lbSophongtrong.TabIndex = 112;
            lbSophongtrong.Text = "...";
            // 
            // pntop
            // 
            pntop.Controls.Add(pictureBox2);
            pntop.Controls.Add(pictureBox1);
            pntop.Controls.Add(pictureBox3);
            pntop.Controls.Add(label3);
            pntop.Controls.Add(pictureBox4);
            pntop.Controls.Add(ptbminimize);
            pntop.Controls.Add(ptbstate);
            pntop.Controls.Add(ptbclose);
            pntop.Dock = DockStyle.Top;
            pntop.Location = new Point(0, 0);
            pntop.Name = "pntop";
            pntop.Size = new Size(706, 30);
            pntop.TabIndex = 113;
            pntop.MouseDown += pntop_MouseDown;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.icons8_minimize_30;
            pictureBox2.Location = new Point(629, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(19, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 114;
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
            pictureBox3.Location = new Point(654, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(19, 20);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 115;
            pictureBox3.TabStop = false;
            pictureBox3.Click += ptbstate_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(42, 9);
            label3.Name = "label3";
            label3.Size = new Size(256, 15);
            label3.TabIndex = 1;
            label3.Text = "PHẦN MỀM QUẢN LÝ PHÒNG TRỌ - NHÓM 1";
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = Properties.Resources.icons8_close_window_30;
            pictureBox4.Location = new Point(679, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(21, 22);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 116;
            pictureBox4.TabStop = false;
            pictureBox4.Click += ptbclose_Click;
            // 
            // ptbminimize
            // 
            ptbminimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ptbminimize.Cursor = Cursors.Hand;
            ptbminimize.Image = Properties.Resources.icons8_minimize_30;
            ptbminimize.Location = new Point(1373, 8);
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
            ptbstate.Location = new Point(1398, 4);
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
            ptbclose.Location = new Point(1423, 2);
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
            pnleft.Size = new Size(10, 364);
            pnleft.TabIndex = 114;
            // 
            // pnright
            // 
            pnright.Dock = DockStyle.Right;
            pnright.Location = new Point(696, 30);
            pnright.Name = "pnright";
            pnright.Size = new Size(10, 364);
            pnright.TabIndex = 115;
            // 
            // pnbottom
            // 
            pnbottom.Dock = DockStyle.Bottom;
            pnbottom.Location = new Point(0, 394);
            pnbottom.Name = "pnbottom";
            pnbottom.Size = new Size(706, 10);
            pnbottom.TabIndex = 116;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(grvThongkephong);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lbSophongtrong);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(10, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(686, 364);
            groupBox1.TabIndex = 117;
            groupBox1.TabStop = false;
            // 
            // Form_ThongKe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 153, 204);
            ClientSize = new Size(706, 404);
            Controls.Add(groupBox1);
            Controls.Add(pnleft);
            Controls.Add(pnright);
            Controls.Add(pnbottom);
            Controls.Add(pntop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_ThongKe";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form_ThongKe";
            Load += Form_ThongKe_Load;
            ((System.ComponentModel.ISupportInitialize)grvThongkephong).EndInit();
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

        private DataGridView grvThongkephong;
        private Label label2;
        private Label label1;
        private Label lbSophongtrong;
        private Panel pntop;
        private PictureBox pictureBox1;
        private Label label3;
        private PictureBox ptbminimize;
        private PictureBox ptbstate;
        private PictureBox ptbclose;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Panel pnleft;
        private Panel pnright;
        private Panel pnbottom;
        private GroupBox groupBox1;
    }
}