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
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            button1 = new Button();
            btnremove = new Button();
            cb1 = new ComboBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Nguyen Huu Nghia", "Luc Tan Khoa", "Pham Tuan Vu", "Phan Thuy Thanh", "Nguyen Thi Thanh Hang", "Tran Trung Nguyen" });
            listBox1.Location = new Point(27, 116);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(278, 304);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(27, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(675, 23);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(708, 60);
            button1.Name = "button1";
            button1.Size = new Size(109, 23);
            button1.TabIndex = 2;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnremove
            // 
            btnremove.Location = new Point(711, 90);
            btnremove.Name = "btnremove";
            btnremove.Size = new Size(106, 23);
            btnremove.TabIndex = 3;
            btnremove.Text = "remove";
            btnremove.UseVisualStyleBackColor = true;
            btnremove.Click += btnremove_Click;
            // 
            // cb1
            // 
            cb1.FormattingEnabled = true;
            cb1.Items.AddRange(new object[] { "Nguyen Huu Nghia", "Luc Tan Khoa", "Pham Tuan Vu", "Phan Thuy Thanh", "Nguyen Thi Thanh Hang", "Tran Trung Nguyen" });
            cb1.Location = new Point(532, 181);
            cb1.Name = "cb1";
            cb1.Size = new Size(170, 23);
            cb1.TabIndex = 4;
            cb1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 450);
            Controls.Add(cb1);
            Controls.Add(btnremove);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox textBox1;
        private Button button1;
        private Button btnremove;
        private ComboBox cb1;
    }
}