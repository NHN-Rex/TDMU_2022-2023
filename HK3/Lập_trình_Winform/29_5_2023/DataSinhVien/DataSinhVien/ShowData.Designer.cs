namespace DataSinhVien
{
    partial class ShowData
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
            grvsinhvien = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)grvsinhvien).BeginInit();
            SuspendLayout();
            // 
            // grvsinhvien
            // 
            grvsinhvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grvsinhvien.Location = new Point(0, 0);
            grvsinhvien.Name = "grvsinhvien";
            grvsinhvien.RowTemplate.Height = 25;
            grvsinhvien.Size = new Size(240, 150);
            grvsinhvien.TabIndex = 0;
            // 
            // ShowData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grvsinhvien);
            Name = "ShowData";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)grvsinhvien).EndInit();
            Load += ShowData_Load;
            ResumeLayout(false);
        }

        private void ShowData_Load1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DataGridView grvsinhvien;
    }
}