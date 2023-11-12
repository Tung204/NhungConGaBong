namespace NhungConGaBong
{
    partial class frmHopDong
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
            cboNhanVien = new ComboBox();
            dgvDanhSachHD = new DataGridView();
            MaHD = new DataGridViewTextBoxColumn();
            MaNV = new DataGridViewTextBoxColumn();
            MaKH = new DataGridViewTextBoxColumn();
            TenHD = new DataGridViewTextBoxColumn();
            LoaiDat = new DataGridViewTextBoxColumn();
            DienTich = new DataGridViewTextBoxColumn();
            TriGia = new DataGridViewTextBoxColumn();
            SoTo = new DataGridViewTextBoxColumn();
            SoThua = new DataGridViewTextBoxColumn();
            NgayLap = new DataGridViewTextBoxColumn();
            btnTimKiem = new Button();
            cboHopDong = new ComboBox();
            btnXoa = new Button();
            btnAdd = new Button();
            btnLuu = new Button();
            txtMaHD = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            rdbDatPhiNpngNghiep = new RadioButton();
            rdbDatChuaSuDung = new RadioButton();
            cbbNongNghiep = new ComboBox();
            cbbPhiNongNghiep = new ComboBox();
            cbbChuaSuDung = new ComboBox();
            label4 = new Label();
            txtDienTich = new TextBox();
            label6 = new Label();
            txtTriGia = new TextBox();
            dtpNgayLap = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label5 = new Label();
            txtSoTo = new TextBox();
            label10 = new Label();
            txtSoThua = new TextBox();
            btnSua = new Button();
            cboKhachHang = new ComboBox();
            lblKhachHang = new Label();
            lblNhanVien = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            rdbDatNongNghiep = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachHD).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // cboNhanVien
            // 
            cboNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(125, 91);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(237, 28);
            cboNhanVien.TabIndex = 28;
            cboNhanVien.SelectedIndexChanged += cboNhanVien_SelectedIndexChanged;
            // 
            // dgvDanhSachHD
            // 
            dgvDanhSachHD.AllowUserToAddRows = false;
            dgvDanhSachHD.AllowUserToDeleteRows = false;
            dgvDanhSachHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachHD.Columns.AddRange(new DataGridViewColumn[] { MaHD, MaNV, MaKH, TenHD, LoaiDat, DienTich, TriGia, SoTo, SoThua, NgayLap });
            dgvDanhSachHD.Dock = DockStyle.Fill;
            dgvDanhSachHD.Location = new Point(3, 173);
            dgvDanhSachHD.Name = "dgvDanhSachHD";
            dgvDanhSachHD.ReadOnly = true;
            dgvDanhSachHD.RowHeadersWidth = 51;
            dgvDanhSachHD.RowTemplate.Height = 29;
            dgvDanhSachHD.Size = new Size(1617, 655);
            dgvDanhSachHD.TabIndex = 19;
            dgvDanhSachHD.CellClick += dgvDanhSachHD_CellClick;
            dgvDanhSachHD.CellContentClick += dgvDanhSachHD_CellContentClick;
            // 
            // MaHD
            // 
            MaHD.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MaHD.DataPropertyName = "MaHD";
            MaHD.HeaderText = "Mã hợp đồng";
            MaHD.MinimumWidth = 6;
            MaHD.Name = "MaHD";
            MaHD.ReadOnly = true;
            MaHD.Width = 118;
            // 
            // MaNV
            // 
            MaNV.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MaNV.DataPropertyName = "MaNV";
            MaNV.HeaderText = "Mã nhân viên";
            MaNV.MinimumWidth = 6;
            MaNV.Name = "MaNV";
            MaNV.ReadOnly = true;
            MaNV.Width = 116;
            // 
            // MaKH
            // 
            MaKH.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MaKH.DataPropertyName = "MaKH";
            MaKH.FillWeight = 130F;
            MaKH.HeaderText = "Mã khách hàng";
            MaKH.MinimumWidth = 6;
            MaKH.Name = "MaKH";
            MaKH.ReadOnly = true;
            MaKH.Width = 127;
            // 
            // TenHD
            // 
            TenHD.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TenHD.DataPropertyName = "TenHD";
            TenHD.HeaderText = "Tên hợp đồng";
            TenHD.MinimumWidth = 6;
            TenHD.Name = "TenHD";
            TenHD.ReadOnly = true;
            TenHD.Width = 119;
            // 
            // LoaiDat
            // 
            LoaiDat.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            LoaiDat.DataPropertyName = "LoaiDat";
            LoaiDat.HeaderText = "Loại đất";
            LoaiDat.MinimumWidth = 6;
            LoaiDat.Name = "LoaiDat";
            LoaiDat.ReadOnly = true;
            LoaiDat.Width = 85;
            // 
            // DienTich
            // 
            DienTich.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DienTich.DataPropertyName = "DienTich";
            DienTich.HeaderText = "Diện tích";
            DienTich.MinimumWidth = 6;
            DienTich.Name = "DienTich";
            DienTich.ReadOnly = true;
            DienTich.Width = 90;
            // 
            // TriGia
            // 
            TriGia.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TriGia.DataPropertyName = "TriGia";
            TriGia.HeaderText = "Trị giá";
            TriGia.MinimumWidth = 6;
            TriGia.Name = "TriGia";
            TriGia.ReadOnly = true;
            TriGia.Width = 74;
            // 
            // SoTo
            // 
            SoTo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SoTo.DataPropertyName = "SoTo";
            SoTo.HeaderText = "Số tờ";
            SoTo.MinimumWidth = 6;
            SoTo.Name = "SoTo";
            SoTo.ReadOnly = true;
            SoTo.Width = 56;
            // 
            // SoThua
            // 
            SoThua.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SoThua.DataPropertyName = "SoThua";
            SoThua.HeaderText = "Số thửa";
            SoThua.MinimumWidth = 6;
            SoThua.Name = "SoThua";
            SoThua.ReadOnly = true;
            SoThua.Width = 83;
            // 
            // NgayLap
            // 
            NgayLap.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NgayLap.DataPropertyName = "NgayLap";
            NgayLap.FillWeight = 200F;
            NgayLap.HeaderText = "Ngày lập hợp đồng";
            NgayLap.MinimumWidth = 6;
            NgayLap.Name = "NgayLap";
            NgayLap.ReadOnly = true;
            NgayLap.Width = 121;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(1364, 50);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 18;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // cboHopDong
            // 
            cboHopDong.FormattingEnabled = true;
            cboHopDong.Location = new Point(125, 51);
            cboHopDong.Name = "cboHopDong";
            cboHopDong.Size = new Size(237, 28);
            cboHopDong.TabIndex = 16;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(12, 48);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 15;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 87);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(12, 125);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 14;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // txtMaHD
            // 
            txtMaHD.Location = new Point(125, 12);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(237, 27);
            txtMaHD.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 15);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 10;
            label1.Text = "Mã hợp đồng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 55);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 10;
            label2.Text = "Tên hợp đồng:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(11, 16);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 20;
            label3.Text = "Chọn loại đất";
            // 
            // rdbDatPhiNpngNghiep
            // 
            rdbDatPhiNpngNghiep.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rdbDatPhiNpngNghiep.AutoSize = true;
            rdbDatPhiNpngNghiep.Location = new Point(116, 53);
            rdbDatPhiNpngNghiep.Name = "rdbDatPhiNpngNghiep";
            rdbDatPhiNpngNghiep.Size = new Size(210, 24);
            rdbDatPhiNpngNghiep.TabIndex = 21;
            rdbDatPhiNpngNghiep.Text = "Nhóm đất phi nông nghiệp";
            rdbDatPhiNpngNghiep.UseVisualStyleBackColor = true;
            rdbDatPhiNpngNghiep.CheckedChanged += rdbDatPhiNpngNghiep_CheckedChanged;
            // 
            // rdbDatChuaSuDung
            // 
            rdbDatChuaSuDung.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rdbDatChuaSuDung.AutoSize = true;
            rdbDatChuaSuDung.Location = new Point(116, 91);
            rdbDatChuaSuDung.Name = "rdbDatChuaSuDung";
            rdbDatChuaSuDung.Size = new Size(190, 24);
            rdbDatChuaSuDung.TabIndex = 21;
            rdbDatChuaSuDung.Text = "Nhóm đất chưa sử dụng";
            rdbDatChuaSuDung.UseVisualStyleBackColor = true;
            rdbDatChuaSuDung.CheckedChanged += rdbDatChuaSuDung_CheckedChanged;
            // 
            // cbbNongNghiep
            // 
            cbbNongNghiep.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbbNongNghiep.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbNongNghiep.FormattingEnabled = true;
            cbbNongNghiep.Location = new Point(332, 10);
            cbbNongNghiep.Name = "cbbNongNghiep";
            cbbNongNghiep.Size = new Size(379, 28);
            cbbNongNghiep.TabIndex = 22;
            // 
            // cbbPhiNongNghiep
            // 
            cbbPhiNongNghiep.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbbPhiNongNghiep.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbPhiNongNghiep.FormattingEnabled = true;
            cbbPhiNongNghiep.Location = new Point(332, 49);
            cbbPhiNongNghiep.Name = "cbbPhiNongNghiep";
            cbbPhiNongNghiep.Size = new Size(379, 28);
            cbbPhiNongNghiep.TabIndex = 22;
            // 
            // cbbChuaSuDung
            // 
            cbbChuaSuDung.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbbChuaSuDung.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbChuaSuDung.FormattingEnabled = true;
            cbbChuaSuDung.Location = new Point(332, 90);
            cbbChuaSuDung.Name = "cbbChuaSuDung";
            cbbChuaSuDung.Size = new Size(379, 28);
            cbbChuaSuDung.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 13);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 10;
            label4.Text = "Diện tích:";
            // 
            // txtDienTich
            // 
            txtDienTich.Location = new Point(89, 9);
            txtDienTich.Name = "txtDienTich";
            txtDienTich.Size = new Size(143, 27);
            txtDienTich.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 51);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 10;
            label6.Text = "Trị giá:";
            // 
            // txtTriGia
            // 
            txtTriGia.Location = new Point(89, 49);
            txtTriGia.Name = "txtTriGia";
            txtTriGia.Size = new Size(143, 27);
            txtTriGia.TabIndex = 12;
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.Format = DateTimePickerFormat.Custom;
            dtpNgayLap.Location = new Point(1523, 12);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(250, 27);
            dtpNgayLap.TabIndex = 23;
            dtpNgayLap.Value = new DateTime(2023, 10, 29, 0, 0, 0, 0);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1364, 19);
            label7.Name = "label7";
            label7.Size = new Size(138, 20);
            label7.TabIndex = 24;
            label7.Text = "Ngày lập hợp đồng";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 96);
            label8.Name = "label8";
            label8.Size = new Size(100, 20);
            label8.TabIndex = 25;
            label8.Text = "Mã nhân viên:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(9, 134);
            label9.Name = "label9";
            label9.Size = new Size(112, 20);
            label9.TabIndex = 27;
            label9.Text = "Mã khách hàng:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 91);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 10;
            label5.Text = "Số tờ:";
            // 
            // txtSoTo
            // 
            txtSoTo.Location = new Point(89, 88);
            txtSoTo.Name = "txtSoTo";
            txtSoTo.Size = new Size(143, 27);
            txtSoTo.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(20, 128);
            label10.Name = "label10";
            label10.Size = new Size(63, 20);
            label10.TabIndex = 10;
            label10.Text = "Số thửa:";
            // 
            // txtSoThua
            // 
            txtSoThua.Location = new Point(89, 125);
            txtSoThua.Name = "txtSoThua";
            txtSoThua.Size = new Size(143, 27);
            txtSoThua.TabIndex = 12;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(12, 8);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 18;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // cboKhachHang
            // 
            cboKhachHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(125, 131);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(237, 28);
            cboKhachHang.TabIndex = 28;
            cboKhachHang.SelectedIndexChanged += cboKhachHang_SelectedIndexChanged;
            // 
            // lblKhachHang
            // 
            lblKhachHang.AutoSize = true;
            lblKhachHang.Location = new Point(365, 136);
            lblKhachHang.Name = "lblKhachHang";
            lblKhachHang.Size = new Size(18, 20);
            lblKhachHang.TabIndex = 29;
            lblKhachHang.Text = "...";
            // 
            // lblNhanVien
            // 
            lblNhanVien.AutoSize = true;
            lblNhanVien.Location = new Point(365, 95);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(18, 20);
            lblNhanVien.TabIndex = 30;
            lblNhanVien.Text = "...";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvDanhSachHD, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.4572811F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 79.54272F));
            tableLayoutPanel1.Size = new Size(1623, 831);
            tableLayoutPanel1.TabIndex = 31;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1617, 164);
            panel1.TabIndex = 32;
            // 
            // panel5
            // 
            panel5.Controls.Add(cboHopDong);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(txtMaHD);
            panel5.Controls.Add(lblNhanVien);
            panel5.Controls.Add(cboNhanVien);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(cboKhachHang);
            panel5.Controls.Add(lblKhachHang);
            panel5.Controls.Add(label2);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(530, 164);
            panel5.TabIndex = 34;
            // 
            // panel4
            // 
            panel4.Controls.Add(cbbNongNghiep);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(rdbDatNongNghiep);
            panel4.Controls.Add(cbbPhiNongNghiep);
            panel4.Controls.Add(rdbDatPhiNpngNghiep);
            panel4.Controls.Add(rdbDatChuaSuDung);
            panel4.Controls.Add(cbbChuaSuDung);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(530, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(717, 164);
            panel4.TabIndex = 33;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtTriGia);
            panel3.Controls.Add(txtSoThua);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(txtSoTo);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(txtDienTich);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1247, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 164);
            panel3.TabIndex = 32;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(btnLuu);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1497, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(120, 164);
            panel2.TabIndex = 31;
            // 
            // rdbDatNongNghiep
            // 
            rdbDatNongNghiep.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rdbDatNongNghiep.AutoSize = true;
            rdbDatNongNghiep.Location = new Point(116, 14);
            rdbDatNongNghiep.Name = "rdbDatNongNghiep";
            rdbDatNongNghiep.Size = new Size(185, 24);
            rdbDatNongNghiep.TabIndex = 21;
            rdbDatNongNghiep.Text = "Nhóm đất nông nghiệp";
            rdbDatNongNghiep.UseVisualStyleBackColor = true;
            rdbDatNongNghiep.CheckedChanged += rdbDatNongNghiep_CheckedChanged;
            // 
            // frmHopDong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1623, 831);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label7);
            Controls.Add(dtpNgayLap);
            Controls.Add(btnTimKiem);
            Name = "frmHopDong";
            Text = "Hợp đồng";
            Load += frmHopDong_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachHD).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDanhSachHD;
        private Button btnTimKiem;
        private ComboBox cboHopDong;
        private Button btnXoa;
        private Button btnAdd;
        private Button btnLuu;
        private TextBox txtMaHD;
        private Label label1;
        private Label label2;
        private Label label3;
        private RadioButton rdbDatPhiNpngNghiep;
        private RadioButton rdbDatChuaSuDung;
        private ComboBox cbbNongNghiep;
        private ComboBox cbbPhiNongNghiep;
        private ComboBox cbbChuaSuDung;
        private Label label4;
        private TextBox txtDienTich;
        private Label label6;
        private TextBox txtTriGia;
        private DateTimePicker dtpNgayLap;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label5;
        private TextBox txtSoTo;
        private Label label10;
        private TextBox txtSoThua;
        private Button btnSua;
        private ComboBox cboNhanVien;
        private ComboBox cboKhachHang;
        private Label lblKhachHang;
        private Label lblNhanVien;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel5;
        private DataGridViewTextBoxColumn MaHD;
        private DataGridViewTextBoxColumn MaNV;
        private DataGridViewTextBoxColumn MaKH;
        private DataGridViewTextBoxColumn TenHD;
        private DataGridViewTextBoxColumn LoaiDat;
        private DataGridViewTextBoxColumn DienTich;
        private DataGridViewTextBoxColumn TriGia;
        private DataGridViewTextBoxColumn SoTo;
        private DataGridViewTextBoxColumn SoThua;
        private DataGridViewTextBoxColumn NgayLap;
        private RadioButton rdbDatNongNghiep;
    }
}