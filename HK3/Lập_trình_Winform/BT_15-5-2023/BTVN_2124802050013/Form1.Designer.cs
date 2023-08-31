namespace BTVN
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
            btn_Dangky = new Button();
            lab_ID = new Label();
            lab_Pass = new Label();
            lab_SDT = new Label();
            txt_ID = new TextBox();
            txt_sdt = new TextBox();
            txt_Pass = new TextBox();
            txt_diachi = new TextBox();
            lab_Diachi = new Label();
            SuspendLayout();
            // 
            // btn_Dangky
            // 
            btn_Dangky.Location = new Point(358, 331);
            btn_Dangky.Name = "btn_Dangky";
            btn_Dangky.Size = new Size(75, 23);
            btn_Dangky.TabIndex = 0;
            btn_Dangky.Text = "Dang Ky";
            btn_Dangky.UseVisualStyleBackColor = true;
            btn_Dangky.Click += btn_Dangky_Click;
            // 
            // lab_ID
            // 
            lab_ID.AutoSize = true;
            lab_ID.Location = new Point(151, 126);
            lab_ID.Name = "lab_ID";
            lab_ID.Size = new Size(18, 15);
            lab_ID.TabIndex = 1;
            lab_ID.Text = "ID";
            // 
            // lab_Pass
            // 
            lab_Pass.AutoSize = true;
            lab_Pass.Location = new Point(151, 171);
            lab_Pass.Name = "lab_Pass";
            lab_Pass.Size = new Size(30, 15);
            lab_Pass.TabIndex = 2;
            lab_Pass.Text = "Pass";
            // 
            // lab_SDT
            // 
            lab_SDT.AutoSize = true;
            lab_SDT.Location = new Point(151, 218);
            lab_SDT.Name = "lab_SDT";
            lab_SDT.Size = new Size(26, 15);
            lab_SDT.TabIndex = 3;
            lab_SDT.Text = "SDT";
            lab_SDT.Click += label3_Click;
            // 
            // txt_ID
            // 
            txt_ID.Location = new Point(289, 124);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(212, 23);
            txt_ID.TabIndex = 4;
            // 
            // txt_sdt
            // 
            txt_sdt.Location = new Point(289, 215);
            txt_sdt.Name = "txt_sdt";
            txt_sdt.Size = new Size(212, 23);
            txt_sdt.TabIndex = 6;
            txt_sdt.KeyPress += txt_sdt_KeyPress;
            // 
            // txt_Pass
            // 
            txt_Pass.Location = new Point(289, 168);
            txt_Pass.Name = "txt_Pass";
            txt_Pass.Size = new Size(212, 23);
            txt_Pass.TabIndex = 5;
            txt_Pass.KeyPress += txt_Pass_KeyPress;
            // 
            // txt_diachi
            // 
            txt_diachi.Location = new Point(289, 266);
            txt_diachi.Name = "txt_diachi";
            txt_diachi.Size = new Size(212, 23);
            txt_diachi.TabIndex = 8;
            // 
            // lab_Diachi
            // 
            lab_Diachi.AutoSize = true;
            lab_Diachi.Location = new Point(151, 269);
            lab_Diachi.Name = "lab_Diachi";
            lab_Diachi.Size = new Size(43, 15);
            lab_Diachi.TabIndex = 7;
            lab_Diachi.Text = "Dia chi";
            // 
            // Form1
            // 
            AcceptButton = btn_Dangky;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_diachi);
            Controls.Add(lab_Diachi);
            Controls.Add(txt_Pass);
            Controls.Add(txt_sdt);
            Controls.Add(txt_ID);
            Controls.Add(lab_SDT);
            Controls.Add(lab_Pass);
            Controls.Add(lab_ID);
            Controls.Add(btn_Dangky);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Dangky;
        private Label lab_ID;
        private Label lab_Pass;
        private Label lab_SDT;
        private TextBox txt_ID;
        private TextBox txt_sdt;
        private TextBox txt_Pass;
        private TextBox txt_diachi;
        private Label lab_Diachi;
    }
}