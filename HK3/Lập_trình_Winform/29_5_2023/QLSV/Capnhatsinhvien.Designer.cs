namespace QLSV
{
    partial class Form_Capnhatsinhvien
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
            lb_Quanlysinhiven = new Label();
            grvsinhvien = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtmasv = new TextBox();
            txttensv = new TextBox();
            cbogioitinh = new ComboBox();
            txtquequan = new TextBox();
            cbolop = new ComboBox();
            dtngaysinh = new DateTimePicker();
            btnthem = new Button();
            btnsua = new Button();
            btnxoa = new Button();
            btnluu = new Button();
            btnthoat = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)grvsinhvien).BeginInit();
            SuspendLayout();
            // 
            // lb_Quanlysinhiven
            // 
            lb_Quanlysinhiven.AutoSize = true;
            lb_Quanlysinhiven.Location = new Point(213, 26);
            lb_Quanlysinhiven.Name = "lb_Quanlysinhiven";
            lb_Quanlysinhiven.Size = new Size(114, 15);
            lb_Quanlysinhiven.TabIndex = 0;
            lb_Quanlysinhiven.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // grvsinhvien
            // 
            grvsinhvien.AllowUserToAddRows = false;
            grvsinhvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grvsinhvien.Location = new Point(26, 67);
            grvsinhvien.Name = "grvsinhvien";
            grvsinhvien.RowTemplate.Height = 25;
            grvsinhvien.Size = new Size(497, 259);
            grvsinhvien.TabIndex = 1;
            grvsinhvien.CellContentClick += grvsinhvien_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(556, 67);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 2;
            label1.Text = "Mã sinh viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(556, 112);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 3;
            label2.Text = "Tên sinh viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(556, 153);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 4;
            label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(556, 201);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 5;
            label4.Text = "Giới tính";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(556, 249);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 6;
            label5.Text = "Quê quán";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(556, 298);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 7;
            label6.Text = "Lớp";
            // 
            // txtmasv
            // 
            txtmasv.Location = new Point(655, 61);
            txtmasv.Name = "txtmasv";
            txtmasv.Size = new Size(188, 23);
            txtmasv.TabIndex = 8;
            // 
            // txttensv
            // 
            txttensv.Location = new Point(655, 101);
            txttensv.Name = "txttensv";
            txttensv.Size = new Size(188, 23);
            txttensv.TabIndex = 9;
            // 
            // cbogioitinh
            // 
            cbogioitinh.FormattingEnabled = true;
            cbogioitinh.Location = new Point(655, 190);
            cbogioitinh.Name = "cbogioitinh";
            cbogioitinh.Size = new Size(188, 23);
            cbogioitinh.TabIndex = 11;
            // 
            // txtquequan
            // 
            txtquequan.Location = new Point(655, 243);
            txtquequan.Name = "txtquequan";
            txtquequan.Size = new Size(188, 23);
            txtquequan.TabIndex = 12;
            // 
            // cbolop
            // 
            cbolop.FormattingEnabled = true;
            cbolop.Location = new Point(655, 295);
            cbolop.Name = "cbolop";
            cbolop.Size = new Size(188, 23);
            cbolop.TabIndex = 13;
            // 
            // dtngaysinh
            // 
            dtngaysinh.Format = DateTimePickerFormat.Short;
            dtngaysinh.Location = new Point(655, 147);
            dtngaysinh.Name = "dtngaysinh";
            dtngaysinh.Size = new Size(188, 23);
            dtngaysinh.TabIndex = 14;
            // 
            // btnthem
            // 
            btnthem.Location = new Point(42, 360);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(75, 23);
            btnthem.TabIndex = 15;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // btnsua
            // 
            btnsua.Location = new Point(196, 360);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(75, 23);
            btnsua.TabIndex = 16;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(385, 360);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(75, 23);
            btnxoa.TabIndex = 17;
            btnxoa.Text = "Xoá";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnluu
            // 
            btnluu.Location = new Point(572, 360);
            btnluu.Name = "btnluu";
            btnluu.Size = new Size(75, 23);
            btnluu.TabIndex = 18;
            btnluu.Text = "Lưu";
            btnluu.UseVisualStyleBackColor = true;
            btnluu.Click += btnluu_Click;
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(736, 360);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(75, 23);
            btnthoat.TabIndex = 19;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // Form_Capnhatsinhvien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 416);
            Controls.Add(btnthoat);
            Controls.Add(btnluu);
            Controls.Add(btnxoa);
            Controls.Add(btnsua);
            Controls.Add(btnthem);
            Controls.Add(dtngaysinh);
            Controls.Add(cbolop);
            Controls.Add(txtquequan);
            Controls.Add(cbogioitinh);
            Controls.Add(txttensv);
            Controls.Add(txtmasv);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(grvsinhvien);
            Controls.Add(lb_Quanlysinhiven);
            Name = "Form_Capnhatsinhvien";
            Text = "Cập Nhật Sinh Viên";
            Load += Capnhatsinhvien_Load;
            ((System.ComponentModel.ISupportInitialize)grvsinhvien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_Quanlysinhiven;
        private DataGridView grvsinhvien;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtmasv;
        private TextBox txttensv;
        private ComboBox cbogioitinh;
        private TextBox txtquequan;
        private ComboBox cbolop;
        private DateTimePicker dtngaysinh;
        private Button btnthem;
        private Button btnsua;
        private Button btnxoa;
        private Button btnluu;
        private Button btnthoat;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}