namespace Lab_21_6_2023
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
            btnBiensoxe = new Button();
            btnXucxac = new Button();
            label1 = new Label();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnBiensoxe
            // 
            btnBiensoxe.BackColor = Color.FromArgb(0, 0, 192);
            btnBiensoxe.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBiensoxe.ForeColor = Color.White;
            btnBiensoxe.Location = new Point(146, 78);
            btnBiensoxe.Name = "btnBiensoxe";
            btnBiensoxe.Size = new Size(103, 97);
            btnBiensoxe.TabIndex = 0;
            btnBiensoxe.Text = "Biển Số Xe";
            btnBiensoxe.UseVisualStyleBackColor = false;
            btnBiensoxe.Click += btnBiensoxe_Click;
            // 
            // btnXucxac
            // 
            btnXucxac.BackColor = Color.FromArgb(0, 192, 0);
            btnXucxac.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnXucxac.ForeColor = Color.White;
            btnXucxac.Location = new Point(281, 78);
            btnXucxac.Name = "btnXucxac";
            btnXucxac.Size = new Size(103, 97);
            btnXucxac.TabIndex = 0;
            btnXucxac.Text = "Xúc Xắc";
            btnXucxac.UseVisualStyleBackColor = false;
            btnXucxac.Click += btnXucxac_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(119, 20);
            label1.Name = "label1";
            label1.Size = new Size(313, 25);
            label1.TabIndex = 1;
            label1.Text = "CLICK VÀO MỘT TRONG BA";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(192, 0, 0);
            btnExit.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(214, 197);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(96, 44);
            btnExit.TabIndex = 2;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 255);
            Controls.Add(btnExit);
            Controls.Add(label1);
            Controls.Add(btnXucxac);
            Controls.Add(btnBiensoxe);
            Name = "Form_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nguyễn Hữu Nghĩa-2124802050013-Lab_21/6/2023";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBiensoxe;
        private Button btnXucxac;
        private Label label1;
        private Button btnExit;
    }
}