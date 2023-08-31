namespace Hotel_manager.Child_Form
{
    partial class Form_HoaDon
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
            label2 = new Label();
            grvHoaDon = new DataGridView();
            label3 = new Label();
            label5 = new Label();
            dtpTuNgay = new DateTimePicker();
            dtpToingay = new DateTimePicker();
            label6 = new Label();
            lbTongdoanhthu = new Label();
            btnLoc = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)grvHoaDon).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(325, 1);
            label2.Name = "label2";
            label2.Size = new Size(201, 47);
            label2.TabIndex = 92;
            label2.Text = "Doanh Thu";
            // 
            // grvHoaDon
            // 
            grvHoaDon.AllowUserToOrderColumns = true;
            grvHoaDon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grvHoaDon.BackgroundColor = SystemColors.ButtonFace;
            grvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grvHoaDon.Location = new Point(12, 165);
            grvHoaDon.MultiSelect = false;
            grvHoaDon.Name = "grvHoaDon";
            grvHoaDon.RowTemplate.Height = 25;
            grvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grvHoaDon.Size = new Size(776, 273);
            grvHoaDon.TabIndex = 94;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(14, 125);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 96;
            label3.Text = "Từ ngày";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(271, 128);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 96;
            label5.Text = "Tới ngày";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Format = DateTimePickerFormat.Short;
            dtpTuNgay.Location = new Point(81, 127);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(100, 23);
            dtpTuNgay.TabIndex = 97;
            // 
            // dtpToingay
            // 
            dtpToingay.Format = DateTimePickerFormat.Short;
            dtpToingay.Location = new Point(356, 129);
            dtpToingay.Name = "dtpToingay";
            dtpToingay.Size = new Size(100, 23);
            dtpToingay.TabIndex = 97;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(68, 14);
            label6.Name = "label6";
            label6.Size = new Size(323, 37);
            label6.TabIndex = 113;
            label6.Text = "Tổng Doanh Thu Là: ";
            // 
            // lbTongdoanhthu
            // 
            lbTongdoanhthu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbTongdoanhthu.AutoSize = true;
            lbTongdoanhthu.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lbTongdoanhthu.Location = new Point(397, 14);
            lbTongdoanhthu.Name = "lbTongdoanhthu";
            lbTongdoanhthu.Size = new Size(44, 37);
            lbTongdoanhthu.TabIndex = 114;
            lbTongdoanhthu.Text = "...";
            // 
            // btnLoc
            // 
            btnLoc.Location = new Point(737, 136);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(51, 23);
            btnLoc.TabIndex = 115;
            btnLoc.Text = "Lọc";
            btnLoc.UseVisualStyleBackColor = true;
            btnLoc.Click += btnLoc_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lbTongdoanhthu);
            panel1.Location = new Point(135, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(599, 72);
            panel1.TabIndex = 116;
            // 
            // Form_HoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 153, 204);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(btnLoc);
            Controls.Add(dtpToingay);
            Controls.Add(dtpTuNgay);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(grvHoaDon);
            Controls.Add(label2);
            Name = "Form_HoaDon";
            Text = "Form_HoaDon";
            Load += Form_HoaDon_Load;
            Click += Form_HoaDon_Click;
            ((System.ComponentModel.ISupportInitialize)grvHoaDon).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView grvHoaDon;
        private Label label3;
        private Label label5;
        private DateTimePicker dtpTuNgay;
        private DateTimePicker dtpToingay;
        private Label label6;
        private Label lbTongdoanhthu;
        private Button btnLoc;
        private Panel panel1;
    }
}