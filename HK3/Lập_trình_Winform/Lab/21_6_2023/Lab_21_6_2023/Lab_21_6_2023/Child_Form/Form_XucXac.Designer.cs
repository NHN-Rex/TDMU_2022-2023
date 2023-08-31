namespace Lab_21_6_2023.Child_Form
{
    partial class Form_XucXac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_XucXac));
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            button8 = new Button();
            button7 = new Button();
            button5 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox2 = new GroupBox();
            pictureBox3 = new PictureBox();
            btReset = new Button();
            btPlay = new Button();
            groupBox3 = new GroupBox();
            lbLose = new Label();
            lbWin = new Label();
            lbCount = new Label();
            listResult = new ListView();
            label1 = new Label();
            btnThoat = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(button8);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(358, 243);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đoán số";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(120, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button8
            // 
            button8.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(260, 174);
            button8.Name = "button8";
            button8.Size = new Size(72, 43);
            button8.TabIndex = 1;
            button8.Text = "6";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button1_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(16, 174);
            button7.Name = "button7";
            button7.Size = new Size(72, 43);
            button7.TabIndex = 1;
            button7.Text = "5";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button1_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(260, 104);
            button5.Name = "button5";
            button5.Size = new Size(72, 43);
            button5.TabIndex = 1;
            button5.Text = "4";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button1_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(260, 34);
            button4.Name = "button4";
            button4.Size = new Size(72, 43);
            button4.TabIndex = 1;
            button4.Text = "2";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(16, 104);
            button2.Name = "button2";
            button2.Size = new Size(72, 43);
            button2.TabIndex = 1;
            button2.Text = "3";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(16, 34);
            button1.Name = "button1";
            button1.Size = new Size(72, 43);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Controls.Add(btnThoat);
            groupBox2.Controls.Add(btReset);
            groupBox2.Controls.Add(btPlay);
            groupBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 261);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(358, 234);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Quay số (Sinh số ngẫu nhiên)";
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(120, 51);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(117, 113);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // btReset
            // 
            btReset.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btReset.Location = new Point(231, 175);
            btReset.Name = "btReset";
            btReset.Size = new Size(101, 43);
            btReset.TabIndex = 1;
            btReset.Text = "Reset";
            btReset.UseVisualStyleBackColor = true;
            btReset.Click += btReset_Click;
            // 
            // btPlay
            // 
            btPlay.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btPlay.Location = new Point(16, 175);
            btPlay.Name = "btPlay";
            btPlay.Size = new Size(104, 43);
            btPlay.TabIndex = 1;
            btPlay.Text = "Quay Số (Enter)";
            btPlay.UseVisualStyleBackColor = true;
            btPlay.Click += btPlay_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lbLose);
            groupBox3.Controls.Add(lbWin);
            groupBox3.Controls.Add(lbCount);
            groupBox3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(12, 501);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(358, 188);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thống kê";
            // 
            // lbLose
            // 
            lbLose.ForeColor = Color.FromArgb(192, 0, 0);
            lbLose.Location = new Point(13, 112);
            lbLose.Name = "lbLose";
            lbLose.Size = new Size(339, 20);
            lbLose.TabIndex = 0;
            lbLose.Text = "Lần thua";
            // 
            // lbWin
            // 
            lbWin.ForeColor = Color.FromArgb(0, 192, 0);
            lbWin.Location = new Point(16, 77);
            lbWin.Name = "lbWin";
            lbWin.Size = new Size(336, 20);
            lbWin.TabIndex = 0;
            lbWin.Text = "Lần thắng";
            // 
            // lbCount
            // 
            lbCount.ForeColor = Color.FromArgb(0, 0, 192);
            lbCount.Location = new Point(16, 44);
            lbCount.Name = "lbCount";
            lbCount.Size = new Size(336, 21);
            lbCount.TabIndex = 0;
            lbCount.Text = "Lần Đoán";
            // 
            // listResult
            // 
            listResult.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            listResult.Location = new Point(396, 12);
            listResult.Name = "listResult";
            listResult.Size = new Size(414, 653);
            listResult.TabIndex = 1;
            listResult.UseCompatibleStateImageBehavior = false;
            listResult.View = View.List;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(396, 668);
            label1.Name = "label1";
            label1.Size = new Size(414, 24);
            label1.TabIndex = 3;
            label1.Text = "Nguyễn Hữu Nghĩa_2124802050013_D21TTNT01";
            label1.TextAlign = ContentAlignment.BottomRight;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.Location = new Point(126, 175);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(101, 43);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form_XucXac
            // 
            AcceptButton = btPlay;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 701);
            Controls.Add(label1);
            Controls.Add(listResult);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_XucXac";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Xúc Xắc";
            Load += Form_XucXac_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button button1;
        private Button btReset;
        private Button button5;
        private Button button4;
        private Button btPlay;
        private Button button2;
        private PictureBox pictureBox1;
        private Button button8;
        private Button button7;
        private PictureBox pictureBox3;
        private Label lbLose;
        private Label lbWin;
        private Label lbCount;
        private ListView listResult;
        private Label label1;
        private Button btnThoat;
    }
}