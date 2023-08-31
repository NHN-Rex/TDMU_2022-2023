namespace App1
{
    partial class App1
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
            panel_Login = new Panel();
            textBox_Pass_Word = new TextBox();
            textBox_User_Name = new TextBox();
            label_Pass_Word = new Label();
            label_User_Name = new Label();
            button_login = new Button();
            panel3 = new Panel();
            panel_Login.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Login
            // 
            panel_Login.Controls.Add(panel3);
            panel_Login.Controls.Add(textBox_Pass_Word);
            panel_Login.Controls.Add(textBox_User_Name);
            panel_Login.Controls.Add(label_Pass_Word);
            panel_Login.Controls.Add(label_User_Name);
            panel_Login.Controls.Add(button_login);
            panel_Login.Location = new Point(247, 79);
            panel_Login.Name = "panel_Login";
            panel_Login.Size = new Size(369, 229);
            panel_Login.TabIndex = 0;
            // 
            // textBox_Pass_Word
            // 
            textBox_Pass_Word.Location = new Point(164, 137);
            textBox_Pass_Word.Name = "textBox_Pass_Word";
            textBox_Pass_Word.Size = new Size(100, 23);
            textBox_Pass_Word.TabIndex = 4;
            textBox_Pass_Word.UseSystemPasswordChar = true;
            textBox_Pass_Word.TextChanged += textBox_Pass_Word_TextChanged;
            // 
            // textBox_User_Name
            // 
            textBox_User_Name.Location = new Point(164, 103);
            textBox_User_Name.Name = "textBox_User_Name";
            textBox_User_Name.Size = new Size(100, 23);
            textBox_User_Name.TabIndex = 3;
            textBox_User_Name.TextChanged += textBox_User_Name_TextChanged;
            // 
            // label_Pass_Word
            // 
            label_Pass_Word.AutoSize = true;
            label_Pass_Word.Location = new Point(85, 140);
            label_Pass_Word.Name = "label_Pass_Word";
            label_Pass_Word.Size = new Size(62, 15);
            label_Pass_Word.TabIndex = 2;
            label_Pass_Word.Text = "Pass Word";
            // 
            // label_User_Name
            // 
            label_User_Name.AutoSize = true;
            label_User_Name.Location = new Point(85, 106);
            label_User_Name.Name = "label_User_Name";
            label_User_Name.Size = new Size(65, 15);
            label_User_Name.TabIndex = 1;
            label_User_Name.Text = "User Name";
            // 
            // button_login
            // 
            button_login.Location = new Point(173, 176);
            button_login.Name = "button_login";
            button_login.Size = new Size(82, 26);
            button_login.TabIndex = 0;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.BackgroundImage = Properties.Resources._272866399_698453377986526_3524689443294892643_n;
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Location = new Point(103, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(152, 97);
            panel3.TabIndex = 5;
            // 
            // App1
            // 
            AcceptButton = button_login;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 450);
            Controls.Add(panel_Login);
            Name = "App1";
            Text = "App1";
            panel_Login.ResumeLayout(false);
            panel_Login.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button BTdangnhap;
        private Label matkhau;
        private Label tendangnhap;
        private TextBox TBmatkhau;
        private TextBox TBtendangnhap;
        private Button BTdangky;
        private Panel panel_Login;
        private TextBox textBox_Pass_Word;
        private TextBox textBox_User_Name;
        private Label label_Pass_Word;
        private Label label_User_Name;
        private Button button_login;
        private Panel panel3;
    }
}