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
            lbfullname = new Label();
            lbmssv = new Label();
            lbsdt = new Label();
            lbclass = new Label();
            lbkhoa = new Label();
            lbhometown = new Label();
            lbdiachi = new Label();
            lbNienkhoa = new Label();
            txt_fullname = new TextBox();
            txt_mssv = new TextBox();
            txt_sdt = new TextBox();
            txt_lop = new TextBox();
            txt_khoa_vien = new TextBox();
            txt_que = new TextBox();
            txt_dia_chi = new TextBox();
            txt_nien_khoa = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lbfullname
            // 
            lbfullname.AutoSize = true;
            lbfullname.Location = new Point(12, 65);
            lbfullname.Name = "lbfullname";
            lbfullname.Size = new Size(59, 15);
            lbfullname.TabIndex = 0;
            lbfullname.Text = "Họ Và Tên";
            // 
            // lbmssv
            // 
            lbmssv.AutoSize = true;
            lbmssv.Location = new Point(12, 100);
            lbmssv.Name = "lbmssv";
            lbmssv.Size = new Size(92, 15);
            lbmssv.TabIndex = 1;
            lbmssv.Text = "Mã Số Sinh Viên";
            // 
            // lbsdt
            // 
            lbsdt.AutoSize = true;
            lbsdt.Location = new Point(12, 137);
            lbsdt.Name = "lbsdt";
            lbsdt.Size = new Size(79, 15);
            lbsdt.TabIndex = 2;
            lbsdt.Text = "Số Điện Thoại";
            // 
            // lbclass
            // 
            lbclass.AutoSize = true;
            lbclass.Location = new Point(12, 183);
            lbclass.Name = "lbclass";
            lbclass.Size = new Size(27, 15);
            lbclass.TabIndex = 3;
            lbclass.Text = "Lớp";
            lbclass.Click += label4_Click;
            // 
            // lbkhoa
            // 
            lbkhoa.AutoSize = true;
            lbkhoa.Location = new Point(12, 229);
            lbkhoa.Name = "lbkhoa";
            lbkhoa.Size = new Size(62, 15);
            lbkhoa.TabIndex = 4;
            lbkhoa.Text = "Khoa-Viện";
            // 
            // lbhometown
            // 
            lbhometown.AutoSize = true;
            lbhometown.Location = new Point(12, 270);
            lbhometown.Name = "lbhometown";
            lbhometown.Size = new Size(61, 15);
            lbhometown.TabIndex = 5;
            lbhometown.Text = "Quê Quán";
            // 
            // lbdiachi
            // 
            lbdiachi.AutoSize = true;
            lbdiachi.Location = new Point(12, 317);
            lbdiachi.Name = "lbdiachi";
            lbdiachi.Size = new Size(43, 15);
            lbdiachi.TabIndex = 6;
            lbdiachi.Text = "Địa chỉ";
            // 
            // lbNienkhoa
            // 
            lbNienkhoa.AutoSize = true;
            lbNienkhoa.Location = new Point(12, 370);
            lbNienkhoa.Name = "lbNienkhoa";
            lbNienkhoa.Size = new Size(61, 15);
            lbNienkhoa.TabIndex = 7;
            lbNienkhoa.Text = "Niên khoá";
            lbNienkhoa.Click += label1_Click;
            // 
            // txt_fullname
            // 
            txt_fullname.Location = new Point(116, 62);
            txt_fullname.Name = "txt_fullname";
            txt_fullname.Size = new Size(155, 23);
            txt_fullname.TabIndex = 0;
            txt_fullname.TextChanged += txt_fullname_TextChanged;
            txt_fullname.KeyPress += txt_fullname_KeyPress;
            // 
            // txt_mssv
            // 
            txt_mssv.Location = new Point(116, 97);
            txt_mssv.Name = "txt_mssv";
            txt_mssv.Size = new Size(155, 23);
            txt_mssv.TabIndex = 1;
            txt_mssv.TextChanged += txt_mssv_TextChanged;
            txt_mssv.KeyPress += txt_mssv_KeyPress;
            // 
            // txt_sdt
            // 
            txt_sdt.Location = new Point(116, 134);
            txt_sdt.Name = "txt_sdt";
            txt_sdt.Size = new Size(155, 23);
            txt_sdt.TabIndex = 2;
            // 
            // txt_lop
            // 
            txt_lop.Location = new Point(116, 180);
            txt_lop.Name = "txt_lop";
            txt_lop.Size = new Size(155, 23);
            txt_lop.TabIndex = 3;
            // 
            // txt_khoa_vien
            // 
            txt_khoa_vien.Location = new Point(116, 226);
            txt_khoa_vien.Name = "txt_khoa_vien";
            txt_khoa_vien.Size = new Size(155, 23);
            txt_khoa_vien.TabIndex = 4;
            // 
            // txt_que
            // 
            txt_que.Location = new Point(116, 267);
            txt_que.Name = "txt_que";
            txt_que.Size = new Size(155, 23);
            txt_que.TabIndex = 5;
            // 
            // txt_dia_chi
            // 
            txt_dia_chi.Location = new Point(116, 314);
            txt_dia_chi.Name = "txt_dia_chi";
            txt_dia_chi.Size = new Size(155, 23);
            txt_dia_chi.TabIndex = 6;
            // 
            // txt_nien_khoa
            // 
            txt_nien_khoa.Location = new Point(116, 367);
            txt_nien_khoa.Name = "txt_nien_khoa";
            txt_nien_khoa.Size = new Size(155, 23);
            txt_nien_khoa.TabIndex = 7;
            txt_nien_khoa.TextChanged += txt_nien_khoa_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(289, 57);
            button1.Name = "button1";
            button1.Size = new Size(95, 328);
            button1.TabIndex = 9;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 450);
            Controls.Add(button1);
            Controls.Add(txt_nien_khoa);
            Controls.Add(txt_dia_chi);
            Controls.Add(txt_que);
            Controls.Add(txt_khoa_vien);
            Controls.Add(txt_lop);
            Controls.Add(txt_sdt);
            Controls.Add(txt_mssv);
            Controls.Add(txt_fullname);
            Controls.Add(lbNienkhoa);
            Controls.Add(lbdiachi);
            Controls.Add(lbhometown);
            Controls.Add(lbkhoa);
            Controls.Add(lbclass);
            Controls.Add(lbsdt);
            Controls.Add(lbmssv);
            Controls.Add(lbfullname);
            Name = "Form1";
            Text = "Sinh Viên";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbfullname;
        private Label lbmssv;
        private Label lbsdt;
        private Label lbclass;
        private Label lbkhoa;
        private Label lbhometown;
        private Label lbdiachi;
        private Label lbNienkhoa;
        private TextBox txt_fullname;
        private TextBox txt_mssv;
        private TextBox txt_sdt;
        private TextBox txt_lop;
        private TextBox txt_khoa_vien;
        private TextBox txt_que;
        private TextBox txt_dia_chi;
        private TextBox txt_nien_khoa;
        private Button button1;
    }
}