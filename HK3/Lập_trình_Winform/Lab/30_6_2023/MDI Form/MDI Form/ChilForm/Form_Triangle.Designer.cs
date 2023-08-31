namespace MDI_Form.ChilForm
{
    partial class Form_Triangle
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
            label5 = new Label();
            label4 = new Label();
            txtS = new TextBox();
            txtP = new TextBox();
            btnRetry = new Button();
            btnCal = new Button();
            btnClose = new Button();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtC);
            groupBox1.Controls.Add(txtB);
            groupBox1.Controls.Add(txtA);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(75, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(357, 191);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Số đo ba cạnh tam giác";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(35, 135);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 1;
            label3.Text = "Cạnh C: ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(35, 87);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 1;
            label2.Text = "Cạnh B: ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(35, 42);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 1;
            label1.Text = "Cạnh A: ";
            // 
            // txtC
            // 
            txtC.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtC.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtC.Location = new Point(143, 129);
            txtC.Name = "txtC";
            txtC.Size = new Size(208, 26);
            txtC.TabIndex = 2;
            // 
            // txtB
            // 
            txtB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtB.Location = new Point(143, 85);
            txtB.Name = "txtB";
            txtB.Size = new Size(208, 26);
            txtB.TabIndex = 1;
            // 
            // txtA
            // 
            txtA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtA.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtA.Location = new Point(143, 40);
            txtA.Name = "txtA";
            txtA.Size = new Size(208, 26);
            txtA.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtS);
            groupBox2.Controls.Add(txtP);
            groupBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(75, 224);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(357, 191);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kết quả tính toán";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(28, 112);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 1;
            label5.Text = "Diện tích:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(28, 71);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 1;
            label4.Text = "Chu vi:";
            // 
            // txtS
            // 
            txtS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtS.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtS.Location = new Point(143, 112);
            txtS.Name = "txtS";
            txtS.Size = new Size(208, 26);
            txtS.TabIndex = 4;
            // 
            // txtP
            // 
            txtP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtP.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtP.Location = new Point(143, 70);
            txtP.Name = "txtP";
            txtP.Size = new Size(208, 26);
            txtP.TabIndex = 3;
            // 
            // btnRetry
            // 
            btnRetry.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnRetry.BackColor = Color.FromArgb(0, 192, 192);
            btnRetry.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnRetry.Location = new Point(1, 20);
            btnRetry.Name = "btnRetry";
            btnRetry.Size = new Size(139, 99);
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
            btnCal.Size = new Size(139, 99);
            btnCal.TabIndex = 2;
            btnCal.Text = "Calculate";
            btnCal.UseVisualStyleBackColor = false;
            btnCal.Click += btnCal_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnClose.BackColor = Color.FromArgb(192, 0, 0);
            btnClose.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(358, 20);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(139, 99);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Bottom;
            groupBox3.Controls.Add(btnClose);
            groupBox3.Controls.Add(btnRetry);
            groupBox3.Controls.Add(btnCal);
            groupBox3.Location = new Point(23, 430);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(507, 131);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            // 
            // Form_Triangle
            // 
            AcceptButton = btnCal;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 573);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form_Triangle";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form_Triangle";
            Load += Form_Triangle_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox txtC;
        private TextBox txtB;
        private TextBox txtA;
        private TextBox txtS;
        private TextBox txtP;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label4;
        private Button btnRetry;
        private Button btnCal;
        private Button btnClose;
        private GroupBox groupBox3;
    }
}