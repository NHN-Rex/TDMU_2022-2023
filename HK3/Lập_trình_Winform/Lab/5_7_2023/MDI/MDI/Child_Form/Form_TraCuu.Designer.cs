namespace MDI.Child_Form
{
    partial class Form_TraCuu
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
            label1 = new Label();
            panel1 = new Panel();
            cbbDsp = new ComboBox();
            cbbHsx = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            lstCpt = new ListView();
            panel3 = new Panel();
            txtSum = new TextBox();
            label4 = new Label();
            btnThoat = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(226, 9);
            label1.Name = "label1";
            label1.Size = new Size(421, 37);
            label1.TabIndex = 0;
            label1.Text = "Tra Cứu Thông Tin Laptop";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(cbbDsp);
            panel1.Controls.Add(cbbHsx);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(851, 66);
            panel1.TabIndex = 1;
            // 
            // cbbDsp
            // 
            cbbDsp.Anchor = AnchorStyles.None;
            cbbDsp.FormattingEnabled = true;
            cbbDsp.Location = new Point(591, 20);
            cbbDsp.Name = "cbbDsp";
            cbbDsp.Size = new Size(190, 23);
            cbbDsp.TabIndex = 17;
            cbbDsp.SelectedIndexChanged += cbbDsp_SelectedIndexChanged;
            // 
            // cbbHsx
            // 
            cbbHsx.Anchor = AnchorStyles.None;
            cbbHsx.FormattingEnabled = true;
            cbbHsx.Items.AddRange(new object[] { "Tất Cả", "HP", "DELL" });
            cbbHsx.Location = new Point(186, 21);
            cbbHsx.Name = "cbbHsx";
            cbbHsx.Size = new Size(190, 23);
            cbbHsx.TabIndex = 17;
            cbbHsx.Text = "Tất Cả";
            cbbHsx.SelectedIndexChanged += cbbHsx_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(424, 20);
            label2.Name = "label2";
            label2.Size = new Size(161, 24);
            label2.TabIndex = 15;
            label2.Text = "Dòng Sản Phẩm";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(20, 20);
            label3.Name = "label3";
            label3.Size = new Size(151, 24);
            label3.TabIndex = 16;
            label3.Text = "Hãng Sản Xuất";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(lstCpt);
            panel2.Location = new Point(12, 121);
            panel2.Name = "panel2";
            panel2.Size = new Size(851, 234);
            panel2.TabIndex = 10;
            // 
            // lstCpt
            // 
            lstCpt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstCpt.AutoArrange = false;
            lstCpt.GridLines = true;
            lstCpt.Location = new Point(3, 3);
            lstCpt.Name = "lstCpt";
            lstCpt.Size = new Size(845, 228);
            lstCpt.TabIndex = 0;
            lstCpt.UseCompatibleStateImageBehavior = false;
            lstCpt.View = View.Details;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(txtSum);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(btnThoat);
            panel3.Location = new Point(12, 361);
            panel3.Name = "panel3";
            panel3.Size = new Size(851, 88);
            panel3.TabIndex = 11;
            // 
            // txtSum
            // 
            txtSum.Anchor = AnchorStyles.None;
            txtSum.Location = new Point(291, 36);
            txtSum.Name = "txtSum";
            txtSum.Size = new Size(110, 23);
            txtSum.TabIndex = 11;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(8, 32);
            label4.Name = "label4";
            label4.Size = new Size(277, 24);
            label4.TabIndex = 12;
            label4.Text = "Tổng số sản phẩm tìm được:";
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.None;
            btnThoat.BackColor = Color.Red;
            btnThoat.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(728, 6);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(114, 77);
            btnThoat.TabIndex = 10;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form_TraCuu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form_TraCuu";
            Text = "Form_TraCuu";
            Load += Form_TraCuu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private ComboBox cbbDsp;
        private ComboBox cbbHsx;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtSum;
        private Label label4;
        private Button btnThoat;
        private ListView lstCpt;
    }
}