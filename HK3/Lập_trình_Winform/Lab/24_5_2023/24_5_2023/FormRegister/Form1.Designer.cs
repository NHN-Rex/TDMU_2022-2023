namespace FormRegister
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
            BTNLOGIN = new Button();
            BTNREGISTER = new Button();
            LBUSERNAME = new Label();
            LBPASS = new Label();
            txtUserName = new TextBox();
            txtPASS = new TextBox();
            dataGridView1 = new DataGridView();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // BTNLOGIN
            // 
            BTNLOGIN.Location = new Point(76, 312);
            BTNLOGIN.Name = "BTNLOGIN";
            BTNLOGIN.Size = new Size(105, 40);
            BTNLOGIN.TabIndex = 0;
            BTNLOGIN.Text = "LOGIN";
            BTNLOGIN.UseVisualStyleBackColor = true;
            BTNLOGIN.Click += BTNLOGIN_Click;
            // 
            // BTNREGISTER
            // 
            BTNREGISTER.Location = new Point(238, 312);
            BTNREGISTER.Name = "BTNREGISTER";
            BTNREGISTER.Size = new Size(105, 40);
            BTNREGISTER.TabIndex = 1;
            BTNREGISTER.Text = "REGISTER";
            BTNREGISTER.UseVisualStyleBackColor = true;
            // 
            // LBUSERNAME
            // 
            LBUSERNAME.AutoSize = true;
            LBUSERNAME.Location = new Point(76, 155);
            LBUSERNAME.Name = "LBUSERNAME";
            LBUSERNAME.Size = new Size(68, 15);
            LBUSERNAME.TabIndex = 2;
            LBUSERNAME.Text = "USERNAME";
            // 
            // LBPASS
            // 
            LBPASS.AutoSize = true;
            LBPASS.Location = new Point(76, 208);
            LBPASS.Name = "LBPASS";
            LBPASS.Size = new Size(68, 15);
            LBPASS.TabIndex = 3;
            LBPASS.Text = "PASSWORD";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(184, 152);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(159, 23);
            txtUserName.TabIndex = 4;
            // 
            // txtPASS
            // 
            txtPASS.Location = new Point(184, 205);
            txtPASS.Name = "txtPASS";
            txtPASS.Size = new Size(159, 23);
            txtPASS.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(436, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(352, 311);
            dataGridView1.TabIndex = 6;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(154, 367);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(105, 40);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEdit);
            Controls.Add(dataGridView1);
            Controls.Add(txtPASS);
            Controls.Add(txtUserName);
            Controls.Add(LBPASS);
            Controls.Add(LBUSERNAME);
            Controls.Add(BTNREGISTER);
            Controls.Add(BTNLOGIN);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
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
        private Button btnEdit;
    }
}