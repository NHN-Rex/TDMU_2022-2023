namespace MDI_Form.ChilForm
{
    partial class Form_Quadratic
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
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtC = new TextBox();
            txtB = new TextBox();
            txtA = new TextBox();
            groupBox2 = new GroupBox();
            lbkq = new Label();
            btnClose = new Button();
            btnRetry = new Button();
            btnCal = new Button();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtC);
            groupBox1.Controls.Add(txtB);
            groupBox1.Controls.Add(txtA);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(171, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(435, 175);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hệ số phương trình bậc hai";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(62, 136);
            label3.Name = "label3";
            label3.Size = new Size(21, 20);
            label3.TabIndex = 1;
            label3.Text = "C";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(62, 88);
            label2.Name = "label2";
            label2.Size = new Size(21, 20);
            label2.TabIndex = 1;
            label2.Text = "B";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(62, 43);
            label1.Name = "label1";
            label1.Size = new Size(21, 20);
            label1.TabIndex = 1;
            label1.Text = "A";
            // 
            // txtC
            // 
            txtC.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtC.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtC.Location = new Point(114, 129);
            txtC.Name = "txtC";
            txtC.Size = new Size(275, 26);
            txtC.TabIndex = 2;
            // 
            // txtB
            // 
            txtB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtB.Location = new Point(114, 85);
            txtB.Name = "txtB";
            txtB.Size = new Size(275, 26);
            txtB.TabIndex = 1;
            // 
            // txtA
            // 
            txtA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtA.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtA.Location = new Point(114, 40);
            txtA.Name = "txtA";
            txtA.Size = new Size(275, 26);
            txtA.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(lbkq);
            groupBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(171, 255);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(435, 140);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kết quả tính toán";
            // 
            // lbkq
            // 
            lbkq.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbkq.AutoSize = true;
            lbkq.Location = new Point(6, 66);
            lbkq.Name = "lbkq";
            lbkq.Size = new Size(39, 20);
            lbkq.TabIndex = 9;
            lbkq.Text = "......";
            lbkq.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnClose.BackColor = Color.FromArgb(192, 0, 0);
            btnClose.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(358, 20);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(143, 96);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnRetry
            // 
            btnRetry.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnRetry.BackColor = Color.FromArgb(0, 192, 192);
            btnRetry.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnRetry.Location = new Point(1, 20);
            btnRetry.Name = "btnRetry";
            btnRetry.Size = new Size(143, 96);
            btnRetry.TabIndex = 3;
            btnRetry.Text = "Retry";
            btnRetry.UseVisualStyleBackColor = false;
            btnRetry.Click += btnRetry_Click;
            // 
            // btnCal
            // 
            btnCal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCal.BackColor = Color.FromArgb(0, 192, 0);
            btnCal.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnCal.Location = new Point(186, 20);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(143, 96);
            btnCal.TabIndex = 2;
            btnCal.Text = "Calculate";
            btnCal.UseVisualStyleBackColor = false;
            btnCal.Click += btnCal_Click;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Bottom;
            groupBox3.Controls.Add(btnClose);
            groupBox3.Controls.Add(btnRetry);
            groupBox3.Controls.Add(btnCal);
            groupBox3.Location = new Point(109, 419);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(507, 131);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            // 
            // Form_Quadratic
            // 
            AcceptButton = btnCal;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 574);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Name = "Form_Quadratic";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form_Quadratic";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtC;
        private TextBox txtB;
        private TextBox txtA;
        private GroupBox groupBox2;
        private Button btnClose;
        private Button btnRetry;
        private Button btnCal;
        private GroupBox groupBox3;
        private Label lbkq;
    }
}