namespace Hotel_manager.Child_Form
{
    partial class Form_GiaHan_Dialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_GiaHan_Dialog));
            label2 = new Label();
            btnXacnhan = new Button();
            btnHuy = new Button();
            dtpNgaygiahan = new DateTimePicker();
            label4 = new Label();
            label7 = new Label();
            txtThoigianthue = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(63, 18);
            label2.Name = "label2";
            label2.Size = new Size(223, 25);
            label2.TabIndex = 92;
            label2.Text = "GIA HẠN THUÊ PHÒNG";
            // 
            // btnXacnhan
            // 
            btnXacnhan.Location = new Point(63, 179);
            btnXacnhan.Name = "btnXacnhan";
            btnXacnhan.Size = new Size(75, 23);
            btnXacnhan.TabIndex = 93;
            btnXacnhan.Text = "Xác Nhận";
            btnXacnhan.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(206, 179);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(75, 23);
            btnHuy.TabIndex = 93;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // dtpNgaygiahan
            // 
            dtpNgaygiahan.Format = DateTimePickerFormat.Short;
            dtpNgaygiahan.Location = new Point(186, 72);
            dtpNgaygiahan.Name = "dtpNgaygiahan";
            dtpNgaygiahan.Size = new Size(95, 23);
            dtpNgaygiahan.TabIndex = 99;
            dtpNgaygiahan.Value = new DateTime(2023, 6, 20, 1, 44, 27, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(63, 72);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 98;
            label4.Text = "Ngày Gia Hạn";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(63, 115);
            label7.Name = "label7";
            label7.Size = new Size(176, 20);
            label7.TabIndex = 101;
            label7.Text = "Thời Gian Thuê (Tháng)";
            // 
            // txtThoigianthue
            // 
            txtThoigianthue.Location = new Point(251, 116);
            txtThoigianthue.Name = "txtThoigianthue";
            txtThoigianthue.Size = new Size(30, 23);
            txtThoigianthue.TabIndex = 100;
            // 
            // Form_GiaHan_Dialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 153, 204);
            ClientSize = new Size(364, 222);
            Controls.Add(label7);
            Controls.Add(txtThoigianthue);
            Controls.Add(dtpNgaygiahan);
            Controls.Add(label4);
            Controls.Add(btnHuy);
            Controls.Add(btnXacnhan);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_GiaHan_Dialog";
            Text = "Form_GiaHan_Dialog";
            Load += Form_GiaHan_Dialog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button btnXacnhan;
        private Button btnHuy;
        private DateTimePicker dtpNgaygiahan;
        private Label label4;
        private Label label7;
        private TextBox txtThoigianthue;
    }
}