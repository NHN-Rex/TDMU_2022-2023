namespace FormRegister
{
    partial class Register_Admin_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register_Admin_Form));
            BTNLOGIN = new Button();
            BTNREGISTER = new Button();
            LBUSERNAME = new Label();
            LBPASS = new Label();
            txtUserName = new TextBox();
            txtPASS = new TextBox();
            dataGridView1 = new DataGridView();
            btnRemove = new Button();
            checkBox_ShowPassword = new CheckBox();
            panel1 = new Panel();
            btnExit = new Button();
            btnUpdate = new Button();
            btnFind = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // BTNLOGIN
            // 
            BTNLOGIN.Location = new Point(13, 278);
            BTNLOGIN.Name = "BTNLOGIN";
            BTNLOGIN.Size = new Size(64, 40);
            BTNLOGIN.TabIndex = 3;
            BTNLOGIN.Text = "LOGIN";
            BTNLOGIN.UseVisualStyleBackColor = true;
            BTNLOGIN.Click += BTNLOGIN_Click;
            // 
            // BTNREGISTER
            // 
            BTNREGISTER.Location = new Point(83, 278);
            BTNREGISTER.Name = "BTNREGISTER";
            BTNREGISTER.Size = new Size(64, 40);
            BTNREGISTER.TabIndex = 4;
            BTNREGISTER.Text = "REGISTER";
            BTNREGISTER.UseVisualStyleBackColor = true;
            BTNREGISTER.Click += BTNREGISTER_Click;
            // 
            // LBUSERNAME
            // 
            LBUSERNAME.AutoSize = true;
            LBUSERNAME.Location = new Point(42, 156);
            LBUSERNAME.Name = "LBUSERNAME";
            LBUSERNAME.Size = new Size(68, 15);
            LBUSERNAME.TabIndex = 2;
            LBUSERNAME.Text = "USERNAME";
            // 
            // LBPASS
            // 
            LBPASS.AutoSize = true;
            LBPASS.Location = new Point(42, 209);
            LBPASS.Name = "LBPASS";
            LBPASS.Size = new Size(68, 15);
            LBPASS.TabIndex = 3;
            LBPASS.Text = "PASSWORD";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(150, 153);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(159, 23);
            txtUserName.TabIndex = 0;
            // 
            // txtPASS
            // 
            txtPASS.Location = new Point(150, 206);
            txtPASS.Name = "txtPASS";
            txtPASS.Size = new Size(159, 23);
            txtPASS.TabIndex = 1;
            txtPASS.UseSystemPasswordChar = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowDrop = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(377, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(213, 311);
            dataGridView1.TabIndex = 6;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(153, 278);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(64, 40);
            btnRemove.TabIndex = 5;
            btnRemove.Text = "REMOVE";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // checkBox_ShowPassword
            // 
            checkBox_ShowPassword.AutoSize = true;
            checkBox_ShowPassword.Location = new Point(150, 235);
            checkBox_ShowPassword.Name = "checkBox_ShowPassword";
            checkBox_ShowPassword.Size = new Size(108, 19);
            checkBox_ShowPassword.TabIndex = 2;
            checkBox_ShowPassword.Text = "Show Password";
            checkBox_ShowPassword.UseVisualStyleBackColor = true;
            checkBox_ShowPassword.CheckedChanged += checkBox_ShowPassword_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources._272866399_698453377986526_3524689443294892643_n;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(132, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(126, 109);
            panel1.TabIndex = 10;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(293, 279);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(64, 40);
            btnExit.TabIndex = 11;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(223, 278);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(64, 41);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(315, 153);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(42, 23);
            btnFind.TabIndex = 13;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // Register_Admin_Form
            // 
            AcceptButton = BTNLOGIN;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 358);
            Controls.Add(btnFind);
            Controls.Add(btnUpdate);
            Controls.Add(btnExit);
            Controls.Add(panel1);
            Controls.Add(checkBox_ShowPassword);
            Controls.Add(btnRemove);
            Controls.Add(dataGridView1);
            Controls.Add(txtPASS);
            Controls.Add(txtUserName);
            Controls.Add(LBPASS);
            Controls.Add(LBUSERNAME);
            Controls.Add(BTNREGISTER);
            Controls.Add(BTNLOGIN);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Register_Admin_Form";
            Text = "Register Admin";
            Load += Register_Admin_Form_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTNLOGIN;
        private Button BTNREGISTER;
        private Label LBUSERNAME;
        private Label LBPASS;
        private TextBox txtUserName;
        private TextBox txtPASS;
        private DataGridView dataGridView1;
        private Button btnRemove;
        private CheckBox checkBox_ShowPassword;
        private Panel panel1;
        private Button btnExit;
        private Button btnUpdate;
        private Button btnFind;
    }
}