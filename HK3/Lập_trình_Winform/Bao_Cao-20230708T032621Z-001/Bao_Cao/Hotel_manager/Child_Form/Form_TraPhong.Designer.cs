namespace Hotel_manager.Child_Form
{
    partial class Form_TraPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_TraPhong));
            btnXacnhan = new Button();
            btnHuy = new Button();
            lbHovaten = new Label();
            lbCCCD = new Label();
            lbQuequan = new Label();
            lbHKTT = new Label();
            lbNgaythue = new Label();
            lbNgaytra = new Label();
            lbThoigianthue = new Label();
            lbSotiencantra = new Label();
            lbHovaten1 = new Label();
            lbQuequan1 = new Label();
            lbNgaythue1 = new Label();
            lbNgaytra1 = new Label();
            lbThoigianthue1 = new Label();
            lbHKTT1 = new Label();
            lbCCCD1 = new Label();
            lbSotiencantra1 = new Label();
            grvThuephong = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)grvThuephong).BeginInit();
            SuspendLayout();
            // 
            // btnXacnhan
            // 
            btnXacnhan.Location = new Point(246, 347);
            btnXacnhan.Name = "btnXacnhan";
            btnXacnhan.Size = new Size(97, 32);
            btnXacnhan.TabIndex = 0;
            btnXacnhan.Text = "Xác Nhận";
            btnXacnhan.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(458, 347);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(97, 32);
            btnHuy.TabIndex = 0;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // lbHovaten
            // 
            lbHovaten.AutoSize = true;
            lbHovaten.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbHovaten.Location = new Point(74, 61);
            lbHovaten.Name = "lbHovaten";
            lbHovaten.Size = new Size(147, 20);
            lbHovaten.TabIndex = 1;
            lbHovaten.Text = "Tên Khách Hàng:";
            // 
            // lbCCCD
            // 
            lbCCCD.AutoSize = true;
            lbCCCD.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbCCCD.Location = new Point(500, 61);
            lbCCCD.Name = "lbCCCD";
            lbCCCD.Size = new Size(119, 20);
            lbCCCD.TabIndex = 1;
            lbCCCD.Text = "CCCD/CMND:";
            // 
            // lbQuequan
            // 
            lbQuequan.AutoSize = true;
            lbQuequan.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbQuequan.Location = new Point(122, 206);
            lbQuequan.Name = "lbQuequan";
            lbQuequan.Size = new Size(95, 20);
            lbQuequan.TabIndex = 1;
            lbQuequan.Text = "Quê Quán:";
            // 
            // lbHKTT
            // 
            lbHKTT.AutoSize = true;
            lbHKTT.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbHKTT.Location = new Point(42, 244);
            lbHKTT.Name = "lbHKTT";
            lbHKTT.Size = new Size(179, 20);
            lbHKTT.TabIndex = 1;
            lbHKTT.Text = "Hộ Khẩu Thường Trú:";
            // 
            // lbNgaythue
            // 
            lbNgaythue.AutoSize = true;
            lbNgaythue.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbNgaythue.Location = new Point(121, 103);
            lbNgaythue.Name = "lbNgaythue";
            lbNgaythue.Size = new Size(104, 20);
            lbNgaythue.TabIndex = 1;
            lbNgaythue.Text = "Ngày Thuê: ";
            // 
            // lbNgaytra
            // 
            lbNgaytra.AutoSize = true;
            lbNgaytra.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbNgaytra.Location = new Point(135, 139);
            lbNgaytra.Name = "lbNgaytra";
            lbNgaytra.Size = new Size(90, 20);
            lbNgaytra.TabIndex = 1;
            lbNgaytra.Text = "Ngày Trả: ";
            // 
            // lbThoigianthue
            // 
            lbThoigianthue.AutoSize = true;
            lbThoigianthue.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbThoigianthue.Location = new Point(17, 172);
            lbThoigianthue.Name = "lbThoigianthue";
            lbThoigianthue.Size = new Size(208, 20);
            lbThoigianthue.TabIndex = 1;
            lbThoigianthue.Text = "Thời Gian Thuê (Tháng): ";
            // 
            // lbSotiencantra
            // 
            lbSotiencantra.AutoSize = true;
            lbSotiencantra.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbSotiencantra.Location = new Point(389, 103);
            lbSotiencantra.Name = "lbSotiencantra";
            lbSotiencantra.Size = new Size(230, 20);
            lbSotiencantra.TabIndex = 1;
            lbSotiencantra.Text = "Tổng Tiền Cần Thanh Toán:";
            // 
            // lbHovaten1
            // 
            lbHovaten1.AutoSize = true;
            lbHovaten1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbHovaten1.Location = new Point(227, 61);
            lbHovaten1.Name = "lbHovaten1";
            lbHovaten1.Size = new Size(154, 20);
            lbHovaten1.TabIndex = 1;
            lbHovaten1.Text = ".............................";
            // 
            // lbQuequan1
            // 
            lbQuequan1.AutoSize = true;
            lbQuequan1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbQuequan1.Location = new Point(223, 206);
            lbQuequan1.Name = "lbQuequan1";
            lbQuequan1.Size = new Size(554, 20);
            lbQuequan1.TabIndex = 1;
            lbQuequan1.Text = ".............................................................................................................";
            // 
            // lbNgaythue1
            // 
            lbNgaythue1.AutoSize = true;
            lbNgaythue1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbNgaythue1.Location = new Point(227, 103);
            lbNgaythue1.Name = "lbNgaythue1";
            lbNgaythue1.Size = new Size(154, 20);
            lbNgaythue1.TabIndex = 1;
            lbNgaythue1.Text = ".............................";
            // 
            // lbNgaytra1
            // 
            lbNgaytra1.AutoSize = true;
            lbNgaytra1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbNgaytra1.Location = new Point(227, 139);
            lbNgaytra1.Name = "lbNgaytra1";
            lbNgaytra1.Size = new Size(154, 20);
            lbNgaytra1.TabIndex = 1;
            lbNgaytra1.Text = ".............................";
            // 
            // lbThoigianthue1
            // 
            lbThoigianthue1.AutoSize = true;
            lbThoigianthue1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbThoigianthue1.Location = new Point(227, 172);
            lbThoigianthue1.Name = "lbThoigianthue1";
            lbThoigianthue1.Size = new Size(154, 20);
            lbThoigianthue1.TabIndex = 1;
            lbThoigianthue1.Text = ".............................";
            // 
            // lbHKTT1
            // 
            lbHKTT1.AutoSize = true;
            lbHKTT1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbHKTT1.Location = new Point(223, 244);
            lbHKTT1.Name = "lbHKTT1";
            lbHKTT1.Size = new Size(554, 20);
            lbHKTT1.TabIndex = 1;
            lbHKTT1.Text = ".............................................................................................................";
            // 
            // lbCCCD1
            // 
            lbCCCD1.AutoSize = true;
            lbCCCD1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbCCCD1.Location = new Point(623, 61);
            lbCCCD1.Name = "lbCCCD1";
            lbCCCD1.Size = new Size(154, 20);
            lbCCCD1.TabIndex = 1;
            lbCCCD1.Text = ".............................";
            // 
            // lbSotiencantra1
            // 
            lbSotiencantra1.AutoSize = true;
            lbSotiencantra1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbSotiencantra1.Location = new Point(623, 103);
            lbSotiencantra1.Name = "lbSotiencantra1";
            lbSotiencantra1.Size = new Size(154, 20);
            lbSotiencantra1.TabIndex = 1;
            lbSotiencantra1.Text = ".............................";
            // 
            // grvThuephong
            // 
            grvThuephong.AllowUserToOrderColumns = true;
            grvThuephong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grvThuephong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grvThuephong.BackgroundColor = SystemColors.ButtonFace;
            grvThuephong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grvThuephong.Location = new Point(12, 84);
            grvThuephong.MultiSelect = false;
            grvThuephong.Name = "grvThuephong";
            grvThuephong.RowTemplate.Height = 25;
            grvThuephong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grvThuephong.Size = new Size(776, 220);
            grvThuephong.TabIndex = 88;
            grvThuephong.CellContentClick += grvThuephong_CellContentClick;
            // 
            // Form_TraPhong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 153, 204);
            ClientSize = new Size(800, 450);
            Controls.Add(grvThuephong);
            Controls.Add(lbNgaytra);
            Controls.Add(lbNgaythue);
            Controls.Add(lbQuequan);
            Controls.Add(lbHKTT);
            Controls.Add(lbThoigianthue);
            Controls.Add(lbSotiencantra);
            Controls.Add(lbSotiencantra1);
            Controls.Add(lbCCCD1);
            Controls.Add(lbCCCD);
            Controls.Add(lbHKTT1);
            Controls.Add(lbThoigianthue1);
            Controls.Add(lbNgaytra1);
            Controls.Add(lbNgaythue1);
            Controls.Add(lbQuequan1);
            Controls.Add(lbHovaten1);
            Controls.Add(lbHovaten);
            Controls.Add(btnHuy);
            Controls.Add(btnXacnhan);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_TraPhong";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Trả Phòng";
            Load += Form_TraPhong_Load;
            ((System.ComponentModel.ISupportInitialize)grvThuephong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnXacnhan;
        private Button btnHuy;
        private Label lbHovaten;
        private Label lbCCCD;
        private Label lbQuequan;
        private Label lbHKTT;
        private Label lbNgaythue;
        private Label lbNgaytra;
        private Label lbThoigianthue;
        private Label lbSotiencantra;
        private Label lbHovaten1;
        private Label lbQuequan1;
        private Label lbNgaythue1;
        private Label lbNgaytra1;
        private Label lbThoigianthue1;
        private Label lbHKTT1;
        private Label lbCCCD1;
        private Label lbSotiencantra1;
        private DataGridView grvThuephong;
    }
}