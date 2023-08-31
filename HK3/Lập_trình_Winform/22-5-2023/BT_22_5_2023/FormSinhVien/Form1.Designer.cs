namespace FormSinhVien
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
            txthoten = new TextBox();
            txtmssv = new TextBox();
            txtsdt = new TextBox();
            txtngaysinh = new TextBox();
            txtlop = new TextBox();
            txtadress = new TextBox();
            txtemail = new TextBox();
            txtnienkhoa = new TextBox();
            lbhoten = new Label();
            lbmssv = new Label();
            lbsdt = new Label();
            lbngaysinh = new Label();
            lbLop = new Label();
            lbadress = new Label();
            lbemail = new Label();
            lbnienkhoa = new Label();
            btnadd = new Button();
            btnedit = new Button();
            btnremove = new Button();
            listView1 = new ListView();
            clmssv = new ColumnHeader();
            clname = new ColumnHeader();
            clsdt = new ColumnHeader();
            clngaysinh = new ColumnHeader();
            clclass = new ColumnHeader();
            cladress = new ColumnHeader();
            clemail = new ColumnHeader();
            clnienkhoa = new ColumnHeader();
            btnNhap = new Button();
            SuspendLayout();
            // 
            // txthoten
            // 
            txthoten.Location = new Point(106, 58);
            txthoten.Name = "txthoten";
            txthoten.Size = new Size(100, 23);
            txthoten.TabIndex = 0;
            // 
            // txtmssv
            // 
            txtmssv.Location = new Point(106, 102);
            txtmssv.Name = "txtmssv";
            txtmssv.Size = new Size(100, 23);
            txtmssv.TabIndex = 1;
            txtmssv.TextChanged += textBox2_TextChanged;
            // 
            // txtsdt
            // 
            txtsdt.Location = new Point(106, 145);
            txtsdt.Name = "txtsdt";
            txtsdt.Size = new Size(100, 23);
            txtsdt.TabIndex = 2;
            // 
            // txtngaysinh
            // 
            txtngaysinh.Location = new Point(106, 186);
            txtngaysinh.Name = "txtngaysinh";
            txtngaysinh.Size = new Size(100, 23);
            txtngaysinh.TabIndex = 3;
            txtngaysinh.TextChanged += textBox4_TextChanged;
            // 
            // txtlop
            // 
            txtlop.Location = new Point(106, 232);
            txtlop.Name = "txtlop";
            txtlop.Size = new Size(100, 23);
            txtlop.TabIndex = 4;
            // 
            // txtadress
            // 
            txtadress.Location = new Point(106, 279);
            txtadress.Name = "txtadress";
            txtadress.Size = new Size(100, 23);
            txtadress.TabIndex = 5;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(106, 320);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(100, 23);
            txtemail.TabIndex = 6;
            // 
            // txtnienkhoa
            // 
            txtnienkhoa.Location = new Point(106, 364);
            txtnienkhoa.Name = "txtnienkhoa";
            txtnienkhoa.Size = new Size(100, 23);
            txtnienkhoa.TabIndex = 7;
            // 
            // lbhoten
            // 
            lbhoten.AutoSize = true;
            lbhoten.Location = new Point(15, 60);
            lbhoten.Name = "lbhoten";
            lbhoten.Size = new Size(43, 15);
            lbhoten.TabIndex = 8;
            lbhoten.Text = "Họ tên";
            // 
            // lbmssv
            // 
            lbmssv.AutoSize = true;
            lbmssv.Location = new Point(12, 110);
            lbmssv.Name = "lbmssv";
            lbmssv.Size = new Size(34, 15);
            lbmssv.TabIndex = 9;
            lbmssv.Text = "Mssv";
            // 
            // lbsdt
            // 
            lbsdt.AutoSize = true;
            lbsdt.Location = new Point(12, 153);
            lbsdt.Name = "lbsdt";
            lbsdt.Size = new Size(27, 15);
            lbsdt.TabIndex = 10;
            lbsdt.Text = "SĐT";
            // 
            // lbngaysinh
            // 
            lbngaysinh.AutoSize = true;
            lbngaysinh.Location = new Point(12, 194);
            lbngaysinh.Name = "lbngaysinh";
            lbngaysinh.Size = new Size(61, 15);
            lbngaysinh.TabIndex = 11;
            lbngaysinh.Text = "Ngày Sinh";
            // 
            // lbLop
            // 
            lbLop.AutoSize = true;
            lbLop.Location = new Point(12, 240);
            lbLop.Name = "lbLop";
            lbLop.Size = new Size(27, 15);
            lbLop.TabIndex = 12;
            lbLop.Text = "Lớp";
            lbLop.Click += label5_Click;
            // 
            // lbadress
            // 
            lbadress.AutoSize = true;
            lbadress.Location = new Point(12, 287);
            lbadress.Name = "lbadress";
            lbadress.Size = new Size(43, 15);
            lbadress.TabIndex = 13;
            lbadress.Text = "Địa chỉ";
            // 
            // lbemail
            // 
            lbemail.AutoSize = true;
            lbemail.Location = new Point(15, 328);
            lbemail.Name = "lbemail";
            lbemail.Size = new Size(36, 15);
            lbemail.TabIndex = 14;
            lbemail.Text = "Email";
            // 
            // lbnienkhoa
            // 
            lbnienkhoa.AutoSize = true;
            lbnienkhoa.Location = new Point(15, 372);
            lbnienkhoa.Name = "lbnienkhoa";
            lbnienkhoa.Size = new Size(61, 15);
            lbnienkhoa.TabIndex = 15;
            lbnienkhoa.Text = "Niên khoá";
            // 
            // btnadd
            // 
            btnadd.Location = new Point(238, 74);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(75, 51);
            btnadd.TabIndex = 16;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // btnedit
            // 
            btnedit.Location = new Point(238, 158);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(75, 51);
            btnedit.TabIndex = 17;
            btnedit.Text = "Edit";
            btnedit.UseVisualStyleBackColor = true;
            // 
            // btnremove
            // 
            btnremove.Location = new Point(238, 320);
            btnremove.Name = "btnremove";
            btnremove.Size = new Size(75, 51);
            btnremove.TabIndex = 18;
            btnremove.Text = "Remove";
            btnremove.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { clmssv, clname, clsdt, clngaysinh, clclass, cladress, clemail, clnienkhoa });
            listView1.Location = new Point(340, 58);
            listView1.Name = "listView1";
            listView1.Size = new Size(537, 329);
            listView1.TabIndex = 19;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // clmssv
            // 
            clmssv.Text = "Mssv";
            // 
            // clname
            // 
            clname.Text = "Họ Tên";
            // 
            // clsdt
            // 
            clsdt.Text = "SĐT";
            // 
            // clngaysinh
            // 
            clngaysinh.Text = "Ngày Sinh";
            // 
            // clclass
            // 
            clclass.Text = "Lớp";
            // 
            // cladress
            // 
            cladress.Text = "Địa chỉ";
            // 
            // clemail
            // 
            clemail.Text = "Email";
            // 
            // clnienkhoa
            // 
            clnienkhoa.Text = "Niên khoá";
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(238, 240);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(75, 50);
            btnNhap.TabIndex = 20;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AcceptButton = btnadd;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 429);
            Controls.Add(btnNhap);
            Controls.Add(listView1);
            Controls.Add(btnremove);
            Controls.Add(btnedit);
            Controls.Add(btnadd);
            Controls.Add(lbnienkhoa);
            Controls.Add(lbemail);
            Controls.Add(lbadress);
            Controls.Add(lbLop);
            Controls.Add(lbngaysinh);
            Controls.Add(lbsdt);
            Controls.Add(lbmssv);
            Controls.Add(lbhoten);
            Controls.Add(txtnienkhoa);
            Controls.Add(txtemail);
            Controls.Add(txtadress);
            Controls.Add(txtlop);
            Controls.Add(txtngaysinh);
            Controls.Add(txtsdt);
            Controls.Add(txtmssv);
            Controls.Add(txthoten);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txthoten;
        private TextBox txtmssv;
        private TextBox txtsdt;
        private TextBox txtngaysinh;
        private TextBox txtlop;
        private TextBox txtadress;
        private TextBox txtemail;
        private TextBox txtnienkhoa;
        private Label lbhoten;
        private Label lbmssv;
        private Label lbsdt;
        private Label lbngaysinh;
        private Label lbLop;
        private Label lbadress;
        private Label lbemail;
        private Label lbnienkhoa;
        private Button btnadd;
        private Button btnedit;
        private Button btnremove;
        private ListView listView1;
        private ColumnHeader clname;
        private ColumnHeader clmssv;
        private ColumnHeader clsdt;
        private ColumnHeader clngaysinh;
        private ColumnHeader clclass;
        private ColumnHeader cladress;
        private ColumnHeader clemail;
        private ColumnHeader clnienkhoa;
        private Button btnNhap;
    }
}