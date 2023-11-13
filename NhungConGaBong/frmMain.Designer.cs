namespace NhungConGaBong
{
    partial class frmMain
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
            btnNhanVien = new Button();
            btnKhachhang = new Button();
            btnHopDong = new Button();
            SuspendLayout();
            // 
            // btnNhanVien
            // 
            btnNhanVien.Location = new Point(49, 71);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(94, 29);
            btnNhanVien.TabIndex = 0;
            btnNhanVien.Text = "Nhân Viên";
            btnNhanVien.UseVisualStyleBackColor = true;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // btnKhachhang
            // 
            btnKhachhang.Location = new Point(216, 71);
            btnKhachhang.Name = "btnKhachhang";
            btnKhachhang.Size = new Size(94, 29);
            btnKhachhang.TabIndex = 0;
            btnKhachhang.Text = "Khách hàng";
            btnKhachhang.UseVisualStyleBackColor = true;
            btnKhachhang.Click += btnKhachhang_Click;
            // 
            // btnHopDong
            // 
            btnHopDong.Location = new Point(378, 71);
            btnHopDong.Name = "btnHopDong";
            btnHopDong.Size = new Size(94, 29);
            btnHopDong.TabIndex = 0;
            btnHopDong.Text = "Hợp đồng";
            btnHopDong.UseVisualStyleBackColor = true;
            btnHopDong.Click += btnHopDong_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 211);
            Controls.Add(btnHopDong);
            Controls.Add(btnKhachhang);
            Controls.Add(btnNhanVien);
            Name = "frmMain";
            Text = "frmMain";
            ResumeLayout(false);
        }

        #endregion

        private Button btnNhanVien;
        private Button btnKhachhang;
        private Button btnHopDong;
    }
}