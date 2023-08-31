namespace MDI_Form.ChilForm
{
    partial class Form_Fraction
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
            btnCal = new Button();
            btnRetry = new Button();
            btnClose = new Button();
            groupBox3 = new GroupBox();
            lbkq = new Label();
            groupBox2 = new GroupBox();
            txtTu = new TextBox();
            txtMau = new TextBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCal
            // 
            btnCal.Anchor = AnchorStyles.None;
            btnCal.BackColor = Color.FromArgb(0, 192, 0);
            btnCal.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnCal.Location = new Point(223, 22);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(139, 99);
            btnCal.TabIndex = 2;
            btnCal.Text = "Calculate";
            btnCal.UseVisualStyleBackColor = false;
            btnCal.Click += btnCal_Click;
            // 
            // btnRetry
            // 
            btnRetry.Anchor = AnchorStyles.None;
            btnRetry.BackColor = Color.FromArgb(0, 192, 192);
            btnRetry.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnRetry.Location = new Point(38, 22);
            btnRetry.Name = "btnRetry";
            btnRetry.Size = new Size(139, 99);
            btnRetry.TabIndex = 3;
            btnRetry.Text = "Retry";
            btnRetry.UseVisualStyleBackColor = false;
            btnRetry.Click += btnRetry_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.None;
            btnClose.BackColor = Color.FromArgb(192, 0, 0);
            btnClose.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(395, 22);
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
            groupBox3.Location = new Point(48, 301);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(580, 127);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            // 
            // lbkq
            // 
            lbkq.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbkq.AutoSize = true;
            lbkq.Location = new Point(143, 52);
            lbkq.Name = "lbkq";
            lbkq.Size = new Size(39, 20);
            lbkq.TabIndex = 0;
            lbkq.Text = "......";
            lbkq.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(lbkq);
            groupBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(188, 170);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(309, 116);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Phân số tối giản";
            // 
            // txtTu
            // 
            txtTu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTu.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTu.Location = new Point(143, 40);
            txtTu.Name = "txtTu";
            txtTu.Size = new Size(146, 26);
            txtTu.TabIndex = 0;
            // 
            // txtMau
            // 
            txtMau.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMau.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMau.Location = new Point(143, 85);
            txtMau.Name = "txtMau";
            txtMau.Size = new Size(146, 26);
            txtMau.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(35, 42);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 1;
            label1.Text = "Tử:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(35, 87);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 1;
            label2.Text = "Mẫu:";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtMau);
            groupBox1.Controls.Add(txtTu);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(188, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(309, 135);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Phân số";
            // 
            // Form_Fraction
            // 
            AcceptButton = btnCal;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form_Fraction";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form_Fraction";
            Load += Form_Fraction_Load;
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCal;
        private Button btnRetry;
        private Button btnClose;
        private GroupBox groupBox3;
        private Label lbkq;
        private GroupBox groupBox2;
        private TextBox txtTu;
        private TextBox txtMau;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
    }
}