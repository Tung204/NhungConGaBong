namespace NhungConGaBong
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            pictureBox1 = new PictureBox();
            lalTieuDe = new Label();
            panel1 = new Panel();
            btnThoat = new Button();
            btnDangNhap = new Button();
            ckHienMK = new CheckBox();
            txtMatKhau = new TextBox();
            label3 = new Label();
            txtTenDangNhap = new TextBox();
            label2 = new Label();
            label1 = new Label();
            elipseControl1 = new ElipseControl();
            elipseControl2 = new ElipseControl();
            elipseControl3 = new ElipseControl();
            elipseControl5 = new ElipseControl();
            elipseControl6 = new ElipseControl();
            elipseControl4 = new ElipseControl();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(145, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lalTieuDe
            // 
            lalTieuDe.AutoSize = true;
            lalTieuDe.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lalTieuDe.ForeColor = Color.FromArgb(0, 0, 64);
            lalTieuDe.Location = new Point(36, 110);
            lalTieuDe.Name = "lalTieuDe";
            lalTieuDe.Size = new Size(300, 29);
            lalTieuDe.TabIndex = 1;
            lalTieuDe.Text = "Hệ thống quản lý khách hàng";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnDangNhap);
            panel1.Controls.Add(ckHienMK);
            panel1.Controls.Add(txtMatKhau);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtTenDangNhap);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(26, 146);
            panel1.Name = "panel1";
            panel1.Size = new Size(315, 239);
            panel1.TabIndex = 2;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.HotTrack;
            btnThoat.FlatAppearance.BorderColor = SystemColors.Highlight;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.ForeColor = SystemColors.ControlLightLight;
            btnThoat.Location = new Point(169, 171);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(126, 41);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = SystemColors.HotTrack;
            btnDangNhap.BackgroundImageLayout = ImageLayout.None;
            btnDangNhap.FlatAppearance.BorderColor = SystemColors.Highlight;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangNhap.ForeColor = SystemColors.ControlLightLight;
            btnDangNhap.Location = new Point(21, 171);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(126, 41);
            btnDangNhap.TabIndex = 3;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // ckHienMK
            // 
            ckHienMK.AutoSize = true;
            ckHienMK.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ckHienMK.ForeColor = Color.FromArgb(0, 0, 64);
            ckHienMK.Location = new Point(21, 137);
            ckHienMK.Name = "ckHienMK";
            ckHienMK.Size = new Size(119, 22);
            ckHienMK.TabIndex = 2;
            ckHienMK.Text = "Hiện mật khẩu";
            ckHienMK.UseVisualStyleBackColor = true;
            ckHienMK.CheckedChanged += ckHienMK_CheckedChanged;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(21, 101);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PlaceholderText = "Mật khẩu";
            txtMatKhau.Size = new Size(274, 27);
            txtMatKhau.TabIndex = 1;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 0, 64);
            label3.Location = new Point(15, 78);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(21, 35);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.PlaceholderText = "Tên đăng nhập";
            txtTenDangNhap.Size = new Size(274, 27);
            txtTenDangNhap.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(15, 10);
            label2.Name = "label2";
            label2.Size = new Size(110, 21);
            label2.TabIndex = 0;
            label2.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(126, 78);
            label1.Name = "label1";
            label1.Size = new Size(127, 31);
            label1.TabIndex = 3;
            label1.Text = "Đăng Nhập";
            // 
            // elipseControl1
            // 
            elipseControl1.CornerRadius = 30;
            elipseControl1.TargetControl = panel1;
            // 
            // elipseControl2
            // 
            elipseControl2.CornerRadius = 15;
            elipseControl2.TargetControl = txtMatKhau;
            // 
            // elipseControl3
            // 
            elipseControl3.CornerRadius = 15;
            elipseControl3.TargetControl = txtTenDangNhap;
            // 
            // elipseControl5
            // 
            elipseControl5.CornerRadius = 8;
            elipseControl5.TargetControl = btnDangNhap;
            // 
            // elipseControl6
            // 
            elipseControl6.CornerRadius = 8;
            elipseControl6.TargetControl = btnThoat;
            // 
            // elipseControl4
            // 
            elipseControl4.CornerRadius = 30;
            elipseControl4.TargetControl = this;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(369, 404);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(lalTieuDe);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUẢN LÝ KHÁCH HÀNG";
            FormClosing += frmDangNhap_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lalTieuDe;
        private Panel panel1;
        private TextBox txtMatKhau;
        private Label label3;
        private TextBox txtTenDangNhap;
        private Label label2;
        private Button btnDangNhap;
        private CheckBox ckHienMK;
        private Button btnThoat;
        private Label label1;
        private ElipseControl elipseControl1;
        private ElipseControl elipseControl2;
        private ElipseControl elipseControl3;
        private ElipseControl elipseControl5;
        private ElipseControl elipseControl6;
        private ElipseControl elipseControl4;
    }
}