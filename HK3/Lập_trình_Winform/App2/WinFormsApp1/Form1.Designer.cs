namespace WinFormsApp1
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
            btn_Dang_nhap = new Button();
            btn_Dang_ky = new Button();
            lab_tdn = new Label();
            lab_pass = new Label();
            txt_tdn = new TextBox();
            txt_pass = new TextBox();
            SuspendLayout();
            // 
            // btn_Dang_nhap
            // 
            btn_Dang_nhap.Location = new Point(262, 245);
            btn_Dang_nhap.Name = "btn_Dang_nhap";
            btn_Dang_nhap.Size = new Size(92, 37);
            btn_Dang_nhap.TabIndex = 0;
            btn_Dang_nhap.Text = "Đăng nhập";
            btn_Dang_nhap.UseVisualStyleBackColor = true;
            btn_Dang_nhap.Click += btn_Dang_nhap_Click;
            // 
            // btn_Dang_ky
            // 
            btn_Dang_ky.Location = new Point(410, 245);
            btn_Dang_ky.Name = "btn_Dang_ky";
            btn_Dang_ky.Size = new Size(99, 37);
            btn_Dang_ky.TabIndex = 1;
            btn_Dang_ky.Text = "Đăng ký";
            btn_Dang_ky.UseVisualStyleBackColor = true;
            // 
            // lab_tdn
            // 
            lab_tdn.AutoSize = true;
            lab_tdn.Location = new Point(171, 155);
            lab_tdn.Name = "lab_tdn";
            lab_tdn.Size = new Size(85, 15);
            lab_tdn.TabIndex = 2;
            lab_tdn.Text = "Tên đăng nhập";
            // 
            // lab_pass
            // 
            lab_pass.AutoSize = true;
            lab_pass.Location = new Point(171, 198);
            lab_pass.Name = "lab_pass";
            lab_pass.Size = new Size(57, 15);
            lab_pass.TabIndex = 3;
            lab_pass.Text = "Mật khẩu";
            // 
            // txt_tdn
            // 
            txt_tdn.Location = new Point(262, 152);
            txt_tdn.Name = "txt_tdn";
            txt_tdn.Size = new Size(247, 23);
            txt_tdn.TabIndex = 4;
            txt_tdn.TextChanged += txt_tdn_TextChanged;
            txt_tdn.KeyPress += txt_tdn_KeyPress_1;
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(262, 198);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(247, 23);
            txt_pass.TabIndex = 5;
            txt_pass.TextChanged += txt_pass_TextChanged;
            // 
            // Form1
            // 
            AcceptButton = btn_Dang_nhap;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_pass);
            Controls.Add(txt_tdn);
            Controls.Add(lab_pass);
            Controls.Add(lab_tdn);
            Controls.Add(btn_Dang_ky);
            Controls.Add(btn_Dang_nhap);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Dang_nhap;
        private Button btn_Dang_ky;
        private Label lab_tdn;
        private Label lab_pass;
        private TextBox txt_tdn;
        private TextBox txt_pass;
    }
}