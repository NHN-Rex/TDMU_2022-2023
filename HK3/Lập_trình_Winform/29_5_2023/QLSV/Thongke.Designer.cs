namespace QLSV
{
    partial class Form_Thongke
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
            grvsinhvien = new DataGridView();
            label1 = new Label();
            cbolop = new ComboBox();
            lbtong = new Label();
            ((System.ComponentModel.ISupportInitialize)grvsinhvien).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 90);
            label2.Name = "label2";
            label2.Size = new Size(133, 15);
            label2.TabIndex = 7;
            label2.Text = "DANH SÁCH SINH VIÊN";
            // 
            // grvsinhvien
            // 
            grvsinhvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grvsinhvien.Location = new Point(37, 108);
            grvsinhvien.Name = "grvsinhvien";
            grvsinhvien.RowTemplate.Height = 25;
            grvsinhvien.Size = new Size(708, 203);
            grvsinhvien.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(254, 41);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 5;
            label1.Text = "Chọn Lớp";
            // 
            // cbolop
            // 
            cbolop.FormattingEnabled = true;
            cbolop.Location = new Point(349, 38);
            cbolop.Name = "cbolop";
            cbolop.Size = new Size(210, 23);
            cbolop.TabIndex = 4;
            cbolop.SelectedIndexChanged += cbolop_SelectedIndexChanged;
            // 
            // lbtong
            // 
            lbtong.AutoSize = true;
            lbtong.Location = new Point(69, 349);
            lbtong.Name = "lbtong";
            lbtong.Size = new Size(16, 15);
            lbtong.TabIndex = 8;
            lbtong.Text = "...";
            // 
            // Form_Thongke
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbtong);
            Controls.Add(label2);
            Controls.Add(grvsinhvien);
            Controls.Add(label1);
            Controls.Add(cbolop);
            Name = "Form_Thongke";
            Text = "Thống kê";
            Load += Thongke_Load;
            ((System.ComponentModel.ISupportInitialize)grvsinhvien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView grvsinhvien;
        private Label label1;
        private ComboBox cbolop;
        private Label lbtong;
    }
}