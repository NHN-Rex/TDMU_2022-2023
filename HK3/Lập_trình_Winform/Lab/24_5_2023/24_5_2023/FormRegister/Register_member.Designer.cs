namespace FormRegister
{
    partial class Register_Member_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register_Member_Form));
            panel1 = new Panel();
            checkBox_ShowPassword = new CheckBox();
            txtPASS = new TextBox();
            txtUserName = new TextBox();
            LBPASS = new Label();
            LBUSERNAME = new Label();
            BTNREGISTER = new Button();
            BTNLOGIN = new Button();
            btnExit = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources._272866399_698453377986526_3524689443294892643_n;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(198, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(199, 170);
            panel1.TabIndex = 20;
            // 
            // checkBox_ShowPassword
            // 
            checkBox_ShowPassword.AutoSize = true;
            checkBox_ShowPassword.Location = new Point(264, 279);
            checkBox_ShowPassword.Name = "checkBox_ShowPassword";
            checkBox_ShowPassword.Size = new Size(108, 19);
            checkBox_ShowPassword.TabIndex = 2;
            checkBox_ShowPassword.Text = "Show Password";
            checkBox_ShowPassword.UseVisualStyleBackColor = true;
            checkBox_ShowPassword.CheckedChanged += checkBox_ShowPassword_CheckedChanged;
            // 
            // txtPASS
            // 
            txtPASS.Location = new Point(264, 250);
            txtPASS.Name = "txtPASS";
            txtPASS.Size = new Size(159, 23);
            txtPASS.TabIndex = 1;
            txtPASS.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(264, 197);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(159, 23);
            txtUserName.TabIndex = 0;
            // 
            // LBPASS
            // 
            LBPASS.AutoSize = true;
            LBPASS.Location = new Point(156, 253);
            LBPASS.Name = "LBPASS";
            LBPASS.Size = new Size(68, 15);
            LBPASS.TabIndex = 14;
            LBPASS.Text = "PASSWORD";
            // 
            // LBUSERNAME
            // 
            LBUSERNAME.AutoSize = true;
            LBUSERNAME.Location = new Point(156, 200);
            LBUSERNAME.Name = "LBUSERNAME";
            LBUSERNAME.Size = new Size(68, 15);
            LBUSERNAME.TabIndex = 13;
            LBUSERNAME.Text = "USERNAME";
            // 
            // BTNREGISTER
            // 
            BTNREGISTER.Location = new Point(244, 304);
            BTNREGISTER.Name = "BTNREGISTER";
            BTNREGISTER.Size = new Size(105, 40);
            BTNREGISTER.TabIndex = 4;
            BTNREGISTER.Text = "REGISTER";
            BTNREGISTER.UseVisualStyleBackColor = true;
            BTNREGISTER.Click += BTNREGISTER_Click;
            // 
            // BTNLOGIN
            // 
            BTNLOGIN.Location = new Point(133, 304);
            BTNLOGIN.Name = "BTNLOGIN";
            BTNLOGIN.Size = new Size(105, 40);
            BTNLOGIN.TabIndex = 3;
            BTNLOGIN.Text = "LOGIN";
            BTNLOGIN.UseVisualStyleBackColor = true;
            BTNLOGIN.Click += BTNLOGIN_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(355, 304);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(105, 40);
            btnExit.TabIndex = 21;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(156, 352);
            label1.Name = "label1";
            label1.Size = new Size(299, 15);
            label1.TabIndex = 22;
            label1.Text = "Login to Admin account with user: admin, pass: admin.";
            // 
            // Register_Member_Form
            // 
            AcceptButton = BTNLOGIN;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 376);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(panel1);
            Controls.Add(checkBox_ShowPassword);
            Controls.Add(txtPASS);
            Controls.Add(txtUserName);
            Controls.Add(LBPASS);
            Controls.Add(LBUSERNAME);
            Controls.Add(BTNREGISTER);
            Controls.Add(BTNLOGIN);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Register_Member_Form";
            Text = "Register Member";
            Load += Register_Member_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private CheckBox checkBox_ShowPassword;
        private TextBox txtPASS;
        private TextBox txtUserName;
        private Label LBPASS;
        private Label LBUSERNAME;
        private Button BTNREGISTER;
        private Button BTNLOGIN;
        private Button btnExit;
        private Label label1;
    }
}