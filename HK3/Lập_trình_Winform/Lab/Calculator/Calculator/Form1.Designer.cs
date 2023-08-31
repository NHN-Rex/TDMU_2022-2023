namespace Calculator
{
    partial class Form_calculator
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
            txtResult = new TextBox();
            btnOP = new Button();
            btnCal = new Button();
            btnClear = new Button();
            btnNumber = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            btnDot = new Button();
            btnDn = new Button();
            btnMn = new Button();
            SuspendLayout();
            // 
            // txtResult
            // 
            txtResult.Location = new Point(15, 25);
            txtResult.MinimumSize = new Size(0, 70);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(231, 70);
            txtResult.TabIndex = 0;
            // 
            // btnOP
            // 
            btnOP.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnOP.Location = new Point(193, 152);
            btnOP.Name = "btnOP";
            btnOP.Size = new Size(53, 42);
            btnOP.TabIndex = 1;
            btnOP.Text = "+";
            btnOP.UseVisualStyleBackColor = true;
            btnOP.Click += btnOP_Click;
            // 
            // btnCal
            // 
            btnCal.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCal.Location = new Point(252, 294);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(53, 42);
            btnCal.TabIndex = 5;
            btnCal.Text = "=";
            btnCal.UseVisualStyleBackColor = true;
            btnCal.Click += btnCal_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(75, 294);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(53, 42);
            btnClear.TabIndex = 6;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnNumber
            // 
            btnNumber.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnNumber.Location = new Point(15, 248);
            btnNumber.Name = "btnNumber";
            btnNumber.Size = new Size(53, 42);
            btnNumber.TabIndex = 7;
            btnNumber.Text = "1";
            btnNumber.UseVisualStyleBackColor = true;
            btnNumber.Click += btnNumber_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(74, 248);
            button1.Name = "button1";
            button1.Size = new Size(53, 42);
            button1.TabIndex = 8;
            button1.Text = "2";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnNumber_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(133, 248);
            button2.Name = "button2";
            button2.Size = new Size(53, 42);
            button2.TabIndex = 9;
            button2.Text = "3";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnNumber_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(134, 200);
            button3.Name = "button3";
            button3.Size = new Size(53, 42);
            button3.TabIndex = 10;
            button3.Text = "6";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnNumber_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(74, 200);
            button4.Name = "button4";
            button4.Size = new Size(53, 42);
            button4.TabIndex = 11;
            button4.Text = "5";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnNumber_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(15, 200);
            button5.Name = "button5";
            button5.Size = new Size(53, 42);
            button5.TabIndex = 12;
            button5.Text = "4";
            button5.UseVisualStyleBackColor = true;
            button5.Click += btnNumber_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(134, 152);
            button6.Name = "button6";
            button6.Size = new Size(53, 42);
            button6.TabIndex = 13;
            button6.Text = "9";
            button6.UseVisualStyleBackColor = true;
            button6.Click += btnNumber_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(75, 152);
            button7.Name = "button7";
            button7.Size = new Size(53, 42);
            button7.TabIndex = 14;
            button7.Text = "8";
            button7.UseVisualStyleBackColor = true;
            button7.Click += btnNumber_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(15, 152);
            button8.Name = "button8";
            button8.Size = new Size(53, 42);
            button8.TabIndex = 15;
            button8.Text = "7";
            button8.UseVisualStyleBackColor = true;
            button8.Click += btnNumber_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(15, 294);
            button9.Name = "button9";
            button9.Size = new Size(53, 42);
            button9.TabIndex = 16;
            button9.Text = "0";
            button9.UseVisualStyleBackColor = true;
            button9.Click += btnNumber_Click;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button10.Location = new Point(193, 200);
            button10.Name = "button10";
            button10.Size = new Size(53, 42);
            button10.TabIndex = 17;
            button10.Text = "-";
            button10.UseVisualStyleBackColor = true;
            button10.Click += btnOP_Click;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button11.Location = new Point(192, 248);
            button11.Name = "button11";
            button11.Size = new Size(53, 42);
            button11.TabIndex = 18;
            button11.Text = "*";
            button11.UseVisualStyleBackColor = true;
            button11.Click += btnOP_Click;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button12.Location = new Point(193, 294);
            button12.Name = "button12";
            button12.Size = new Size(53, 42);
            button12.TabIndex = 19;
            button12.Text = "/";
            button12.UseVisualStyleBackColor = true;
            button12.Click += btnOP_Click;
            // 
            // btnDot
            // 
            btnDot.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDot.Location = new Point(134, 294);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(53, 42);
            btnDot.TabIndex = 20;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnNumber_Click;
            // 
            // btnDn
            // 
            btnDn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDn.Location = new Point(251, 246);
            btnDn.Name = "btnDn";
            btnDn.Size = new Size(53, 42);
            btnDn.TabIndex = 21;
            btnDn.Text = ")";
            btnDn.UseVisualStyleBackColor = true;
            btnDn.Click += btnNumber_Click;
            // 
            // btnMn
            // 
            btnMn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnMn.Location = new Point(251, 198);
            btnMn.Name = "btnMn";
            btnMn.Size = new Size(53, 42);
            btnMn.TabIndex = 22;
            btnMn.Text = "(";
            btnMn.UseVisualStyleBackColor = true;
            btnMn.Click += btnNumber_Click;
            // 
            // Form_calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 350);
            Controls.Add(btnMn);
            Controls.Add(btnDn);
            Controls.Add(btnDot);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnNumber);
            Controls.Add(btnClear);
            Controls.Add(btnCal);
            Controls.Add(btnOP);
            Controls.Add(txtResult);
            Name = "Form_calculator";
            Text = "Calculator";
            Load += Form_calculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResult;
        private Button btnOP;
        private Button btnCal;
        private Button btnClear;
        private Button btnNumber;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button btnDot;
        private Button btnDn;
        private Button btnMn;
    }
}