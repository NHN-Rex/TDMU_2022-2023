namespace QLSV
{
    partial class Form_Hienthisinhvien
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
            cbolop = new ComboBox();
            label1 = new Label();
            grvsinhvien = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)grvsinhvien).BeginInit();
            SuspendLayout();
            // 
            // cbolop
            // 
            cbolop.FormattingEnabled = true;
            cbolop.Location = new Point(254, 64);
            cbolop.Name = "cbolop";
            cbolop.Size = new Size(210, 23);
            cbolop.TabIndex = 0;
            cbolop.SelectedIndexChanged += cbolop_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 67);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 1;
            label1.Text = "Chọn Lớp";
            // 
            // grvsinhvien
            // 
            grvsinhvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grvsinhvien.Location = new Point(31, 174);
            grvsinhvien.Name = "grvsinhvien";
            grvsinhvien.RowTemplate.Height = 25;
            grvsinhvien.Size = new Size(549, 264);
            grvsinhvien.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 156);
            label2.Name = "label2";
            label2.Size = new Size(133, 15);
            label2.TabIndex = 3;
            label2.Text = "DANH SÁCH SINH VIÊN";
            // 
            // Form_Hienthisinhvien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 450);
            Controls.Add(label2);
            Controls.Add(grvsinhvien);
            Controls.Add(label1);
            Controls.Add(cbolop);
            Name = "Form_Hienthisinhvien";
            Text = "Hiển thị sinh viên";
            Load += Form_Hienthisinhvien_Load;
            ((System.ComponentModel.ISupportInitialize)grvsinhvien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbolop;
        private Label label1;
        private DataGridView grvsinhvien;
        private Label label2;
    }
}