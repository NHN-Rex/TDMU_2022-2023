namespace Hotel_manager.Child_Form
{
    partial class Form_ViTri
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
            panel1 = new Panel();
            label4 = new Label();
            label1 = new Label();
            txtTenvitri = new TextBox();
            btnTim = new Button();
            txtMavitri = new TextBox();
            panel2 = new Panel();
            btnXoa = new Button();
            btnXacnhan = new Button();
            btnThem = new Button();
            label2 = new Label();
            grvVitri = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grvVitri).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtTenvitri);
            panel1.Controls.Add(btnTim);
            panel1.Controls.Add(txtMavitri);
            panel1.Location = new Point(12, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(365, 134);
            panel1.TabIndex = 107;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 107);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 111;
            label4.Text = "Tên vị trí";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(8, 74);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 111;
            label1.Text = "Mã vị trí";
            // 
            // txtTenvitri
            // 
            txtTenvitri.Location = new Point(76, 104);
            txtTenvitri.Name = "txtTenvitri";
            txtTenvitri.Size = new Size(116, 23);
            txtTenvitri.TabIndex = 110;
            // 
            // btnTim
            // 
            btnTim.ImageAlign = ContentAlignment.MiddleLeft;
            btnTim.Location = new Point(131, 74);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(61, 23);
            btnTim.TabIndex = 100;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            // 
            // txtMavitri
            // 
            txtMavitri.Location = new Point(76, 75);
            txtMavitri.Name = "txtMavitri";
            txtMavitri.Size = new Size(43, 23);
            txtMavitri.TabIndex = 101;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnXacnhan);
            panel2.Controls.Add(btnThem);
            panel2.Location = new Point(383, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(405, 100);
            panel2.TabIndex = 108;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(248, 64);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(74, 36);
            btnXoa.TabIndex = 104;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnXacnhan
            // 
            btnXacnhan.Enabled = false;
            btnXacnhan.Location = new Point(328, 63);
            btnXacnhan.Name = "btnXacnhan";
            btnXacnhan.Size = new Size(74, 36);
            btnXacnhan.TabIndex = 105;
            btnXacnhan.Text = "Xác Nhận";
            btnXacnhan.UseVisualStyleBackColor = true;
            btnXacnhan.Click += btnXacnhan_Click;
            // 
            // btnThem
            // 
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(168, 64);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(74, 36);
            btnThem.TabIndex = 107;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(257, 5);
            label2.Name = "label2";
            label2.Size = new Size(317, 25);
            label2.TabIndex = 106;
            label2.Text = "Quản Lý Danh Sách Vị Trí Làm Việc";
            // 
            // grvVitri
            // 
            grvVitri.AllowUserToOrderColumns = true;
            grvVitri.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grvVitri.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grvVitri.BackgroundColor = SystemColors.ButtonFace;
            grvVitri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grvVitri.Location = new Point(12, 183);
            grvVitri.MultiSelect = false;
            grvVitri.Name = "grvVitri";
            grvVitri.ReadOnly = true;
            grvVitri.RowTemplate.Height = 25;
            grvVitri.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grvVitri.Size = new Size(776, 263);
            grvVitri.TabIndex = 105;
            // 
            // Form_ViTri
            // 
            AcceptButton = btnXacnhan;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 153, 204);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(grvVitri);
            Name = "Form_ViTri";
            Text = "Form_ViTri";
            Load += Form_ViTri_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grvVitri).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnTim;
        private TextBox txtMavitri;
        private Panel panel2;
        private Button btnXoa;
        private Button btnXacnhan;
        private Button btnThem;
        private Label label2;
        private DataGridView grvVitri;
        private TextBox txtTenvitri;
        private Label label4;
        private Label label1;
    }
}