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
            cboHopDong = new ComboBox();
            btnXoa = new Button();
            btnAdd = new Button();
            btnLuu = new Button();
            txtMaHD = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            rdbDatNongNghiep = new RadioButton();
            rdbDatPhiNpngNghiep = new RadioButton();
            rdbDatChuaSuDung = new RadioButton();
            cbbNongNghiep = new ComboBox();
            cbbPhiNongNghiep = new ComboBox();
            cbbChuaSuDung = new ComboBox();
            label4 = new Label();
            txtDienTich = new TextBox();
            label6 = new Label();
            txtTriGia = new TextBox();
            label5 = new Label();
            txtSoTo = new TextBox();
            label10 = new Label();
            txtSoThua = new TextBox();
            btnSua = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            txtTenKhachHang = new TextBox();
            txtTenNhanVien = new TextBox();
            label13 = new Label();
            label12 = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            dtpNgayLap = new DateTimePicker();
            panel3 = new Panel();
            panel2 = new Panel();
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
            panel7 = new Panel();
            label9 = new Label();
            txtTimNhanVien = new TextBox();
            panel8 = new Panel();
            label8 = new Label();
            txtTimKhachHang = new TextBox();
            dgvNhanVienView = new DataGridView();
            mnvName = new DataGridViewTextBoxColumn();
            HoDem = new DataGridViewTextBoxColumn();
            Ten = new DataGridViewTextBoxColumn();
            dgvKhachHangView = new DataGridView();
            makhachang = new DataGridViewTextBoxColumn();
            HoDemKH = new DataGridViewTextBoxColumn();
            TenKH = new DataGridViewTextBoxColumn();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            dgvHopDongview = new DataGridView();
            IDhopDong = new DataGridViewTextBoxColumn();
            IDNhanVIen = new DataGridViewTextBoxColumn();
            TenNhanVien = new DataGridViewTextBoxColumn();
            IDKhachHang = new DataGridViewTextBoxColumn();
            TenKHachHang = new DataGridViewTextBoxColumn();
            TenHopDong = new DataGridViewTextBoxColumn();
            LoaiDatMua = new DataGridViewTextBoxColumn();
            DienTichDat = new DataGridViewTextBoxColumn();
            TriGiaDat = new DataGridViewTextBoxColumn();
            sotoDat = new DataGridViewTextBoxColumn();
            SoThuaDat = new DataGridViewTextBoxColumn();
            NgayLapHD = new DataGridViewTextBoxColumn();
            panel6 = new Panel();
            btnXoaDS = new Button();
            label11 = new Label();
            btnXuat = new Button();
            txtNhap = new TextBox();
            MaHopDong = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachHD).BeginInit();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVienView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHangView).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHopDongview).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // cboHopDong
            // 
            cboHopDong.FormattingEnabled = true;
            cboHopDong.Items.AddRange(new object[] { "Hợp đồng Mua bán đất", "Hợp đồng Cho thuê đất", "Hợp đồng Thuê đất", "Hợp đồng Môi giới đất", "Hợp đồng Sử dụng đất theo mục đích", "Hợp đồng Chuyển quyền sở hữu đất", "Hợp đồng Trồng trọt đất", "Hợp đồng Thừa kế đất" });
            cboHopDong.Location = new Point(118, 9);
            cboHopDong.Name = "cboHopDong";
            cboHopDong.Size = new Size(237, 28);
            cboHopDong.TabIndex = 16;
            // 
            // btnXoa
            // 
            btnXoa.ImageAlign = ContentAlignment.MiddleRight;
            btnXoa.Location = new Point(12, 60);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(85, 29);
            btnXoa.TabIndex = 15;
            btnXoa.Text = "Xoá";
            btnXoa.TextAlign = ContentAlignment.MiddleLeft;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnAdd
            // 
            btnAdd.ImageAlign = ContentAlignment.MiddleRight;
            btnAdd.Location = new Point(12, 99);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(85, 29);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "ADD";
            btnAdd.TextAlign = ContentAlignment.MiddleLeft;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnLuu
            // 
            btnLuu.ImageAlign = ContentAlignment.MiddleRight;
            btnLuu.Location = new Point(12, 137);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(85, 29);
            btnLuu.TabIndex = 14;
            btnLuu.Text = "Lưu";
            btnLuu.TextAlign = ContentAlignment.MiddleLeft;
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // txtMaHD
            // 
            txtMaHD.Enabled = false;
            txtMaHD.Location = new Point(502, 10);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(237, 27);
            txtMaHD.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(386, 13);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 10;
            label1.Text = "Mã hợp đồng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 13);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 10;
            label2.Text = "Tên hợp đồng:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(1, 51);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 20;
            label3.Text = "Chọn loại đất";
            // 
            // rdbDatNongNghiep
            // 
            rdbDatNongNghiep.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rdbDatNongNghiep.AutoSize = true;
            rdbDatNongNghiep.Location = new Point(106, 49);
            rdbDatNongNghiep.Name = "rdbDatNongNghiep";
            rdbDatNongNghiep.Size = new Size(185, 24);
            rdbDatNongNghiep.TabIndex = 21;
            rdbDatNongNghiep.Text = "Nhóm đất nông nghiệp";
            rdbDatNongNghiep.UseVisualStyleBackColor = true;
            rdbDatNongNghiep.CheckedChanged += rdbDatNongNghiep_CheckedChanged;
            // 
            // rdbDatPhiNpngNghiep
            // 
            rdbDatPhiNpngNghiep.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rdbDatPhiNpngNghiep.AutoSize = true;
            rdbDatPhiNpngNghiep.Location = new Point(107, 84);
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
            rdbDatChuaSuDung.Location = new Point(107, 125);
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
            cbbNongNghiep.Items.AddRange(new object[] { "Đất chuyên trồng lúa nước", "Đất trồng lúa nước còn lại", "Đất lúa nương\t", "Đất bằng trồng cây hàng năm khác", "Đất nương rẫy trồng cây hàng năm khác", "Đất trồng cây lâu năm", "Đất rừng sản xuất", "Đất rừng phòng hộ", "Đất rừng đặc dụng\t", "Đất nuôi trồng thủy sản", "Đất làm muối\t", "Đất nông nghiệp khác" });
            cbbNongNghiep.Location = new Point(322, 45);
            cbbNongNghiep.Name = "cbbNongNghiep";
            cbbNongNghiep.Size = new Size(417, 28);
            cbbNongNghiep.TabIndex = 22;
            // 
            // cbbPhiNongNghiep
            // 
            cbbPhiNongNghiep.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbbPhiNongNghiep.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbPhiNongNghiep.FormattingEnabled = true;
            cbbPhiNongNghiep.Items.AddRange(new object[] { "Đất ở tại nông thôn", "Đất ở tại đô thị", "Đất xây dựng trụ sở cơ quan", "Đất xây dựng trụ sở của tổ chức sự nghiệp", "Đất xây dựng cơ sở văn hóa", "Đất xây dựng cơ sở y tế", "Đất xây dựng cơ sở giáo dục và đào tạo\t", "Đất xây dựng cơ sở thể dục thể thao", "Đất xây dựng cơ sở khoa học và công nghệ", "Đất xây dựng cơ sở dịch vụ xã hội", "Đất xây dựng cơ sở ngoại giao", "Đất xây dựng công trình sự nghiệp khác", "Đất quốc phòng", "Đất an ninh", "Đất khu công nghiệp", "Đất khu công nghiệp", "Đất khu chế xuất", "Đất cụm công nghiệp", "Đất cơ sở sản xuất phi nông nghiệp", "Đất thương mại, dịch vụ", "Đất sử dụng cho hoạt động khoáng sản", "Đất sản xuất vật liệu xây dựng, làm đồ gốm", "Đất giao thông", "Đất thủy lợi", "Đất công trình năng lượng", "Đất công trình bưu chính, viễn thông", "Đất sinh hoạt cộng đồng", "Đất khu vui chơi, giải trí công cộng", "Đất chợ", "Đất có di tích lịch sử - văn hóa", "Đất danh lam thắng cảnh", "Đất bãi thải, xử lý chất thải", "Đất công trình công cộng khác", "Đất cơ sở tôn giáo", "Đất cơ sở tín ngưỡng", "Đất làm nghĩa trang, nghĩa địa, nhà tang lễ, nhà hỏa táng", "Đất sông, ngòi, kênh, rạch, suối", "Đất có mặt nước chuyên dùng", "Đất phi nông nghiệp khác" });
            cbbPhiNongNghiep.Location = new Point(323, 83);
            cbbPhiNongNghiep.Name = "cbbPhiNongNghiep";
            cbbPhiNongNghiep.Size = new Size(417, 28);
            cbbPhiNongNghiep.TabIndex = 22;
            // 
            // cbbChuaSuDung
            // 
            cbbChuaSuDung.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbbChuaSuDung.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbChuaSuDung.FormattingEnabled = true;
            cbbChuaSuDung.Items.AddRange(new object[] { "", "Đất bằng chưa sử dụng", "Đất đồi núi chưa sử dụng", "Núi đá không có rừng cây" });
            cbbChuaSuDung.Location = new Point(323, 124);
            cbbChuaSuDung.Name = "cbbChuaSuDung";
            cbbChuaSuDung.Size = new Size(417, 28);
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
            txtDienTich.KeyPress += txtDienTich_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 61);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 10;
            label6.Text = "Trị giá:";
            // 
            // txtTriGia
            // 
            txtTriGia.Location = new Point(89, 59);
            txtTriGia.Name = "txtTriGia";
            txtTriGia.Size = new Size(143, 27);
            txtTriGia.TabIndex = 12;
            txtTriGia.KeyPress += txtTriGia_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 114);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 10;
            label5.Text = "Số tờ:";
            // 
            // txtSoTo
            // 
            txtSoTo.Location = new Point(89, 111);
            txtSoTo.Name = "txtSoTo";
            txtSoTo.Size = new Size(143, 27);
            txtSoTo.TabIndex = 12;
            txtSoTo.KeyPress += txtSoTo_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(20, 163);
            label10.Name = "label10";
            label10.Size = new Size(63, 20);
            label10.TabIndex = 10;
            label10.Text = "Số thửa:";
            // 
            // txtSoThua
            // 
            txtSoThua.Location = new Point(89, 160);
            txtSoThua.Name = "txtSoThua";
            txtSoThua.Size = new Size(143, 27);
            txtSoThua.TabIndex = 12;
            txtSoThua.KeyPress += txtSoThua_KeyPress;
            // 
            // btnSua
            // 
            btnSua.ImageAlign = ContentAlignment.MiddleRight;
            btnSua.Location = new Point(12, 20);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(85, 29);
            btnSua.TabIndex = 18;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleLeft;
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.6963348F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.4083767F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.8952885F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvDanhSachHD, 0, 1);
            tableLayoutPanel1.Controls.Add(panel7, 1, 0);
            tableLayoutPanel1.Controls.Add(panel8, 2, 0);
            tableLayoutPanel1.Controls.Add(dgvNhanVienView, 1, 1);
            tableLayoutPanel1.Controls.Add(dgvKhachHangView, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 31.060606F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 68.93939F));
            tableLayoutPanel1.Size = new Size(1910, 792);
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
            panel1.Size = new Size(1096, 240);
            panel1.TabIndex = 32;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(0, 240);
            panel5.TabIndex = 34;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtTenKhachHang);
            panel4.Controls.Add(txtTenNhanVien);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(cboHopDong);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(txtMaHD);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(dtpNgayLap);
            panel4.Controls.Add(cbbNongNghiep);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(rdbDatNongNghiep);
            panel4.Controls.Add(cbbPhiNongNghiep);
            panel4.Controls.Add(rdbDatPhiNpngNghiep);
            panel4.Controls.Add(rdbDatChuaSuDung);
            panel4.Controls.Add(cbbChuaSuDung);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(755, 240);
            panel4.TabIndex = 33;
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Location = new Point(516, 202);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(189, 27);
            txtTenKhachHang.TabIndex = 29;
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Location = new Point(145, 202);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(189, 27);
            txtTenNhanVien.TabIndex = 29;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(386, 205);
            label13.Name = "label13";
            label13.Size = new Size(111, 20);
            label13.TabIndex = 28;
            label13.Text = "Tên khách hàng";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(17, 205);
            label12.Name = "label12";
            label12.Size = new Size(99, 20);
            label12.TabIndex = 28;
            label12.Text = "Tên nhân viên";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(264, 164);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 26);
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(107, 164);
            label7.Name = "label7";
            label7.Size = new Size(138, 20);
            label7.TabIndex = 26;
            label7.Text = "Ngày lập hợp đồng";
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.Format = DateTimePickerFormat.Custom;
            dtpNgayLap.Location = new Point(322, 163);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(250, 27);
            dtpNgayLap.TabIndex = 25;
            dtpNgayLap.Value = new DateTime(2023, 10, 29, 0, 0, 0, 0);
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
            panel3.Location = new Point(755, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(233, 240);
            panel3.TabIndex = 32;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(btnLuu);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(988, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(108, 240);
            panel2.TabIndex = 31;
            // 
            // dgvDanhSachHD
            // 
            dgvDanhSachHD.AllowUserToAddRows = false;
            dgvDanhSachHD.AllowUserToDeleteRows = false;
            dgvDanhSachHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachHD.Columns.AddRange(new DataGridViewColumn[] { MaHD, MaNV, MaKH, TenHD, LoaiDat, DienTich, TriGia, SoTo, SoThua, NgayLap });
            dgvDanhSachHD.Dock = DockStyle.Fill;
            dgvDanhSachHD.Location = new Point(3, 249);
            dgvDanhSachHD.Name = "dgvDanhSachHD";
            dgvDanhSachHD.ReadOnly = true;
            dgvDanhSachHD.RowHeadersWidth = 51;
            dgvDanhSachHD.RowTemplate.Height = 29;
            dgvDanhSachHD.Size = new Size(1096, 540);
            dgvDanhSachHD.TabIndex = 19;
            dgvDanhSachHD.CellClick += dgvDanhSachHD_CellClick;
            dgvDanhSachHD.CellContentClick += dgvDanhSachHD_CellContentClick;
            dgvDanhSachHD.RowPostPaint += dgvDanhSachHD_RowPostPaint;
            // 
            // MaHD
            // 
            MaHD.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MaHD.DataPropertyName = "MaHD";
            MaHD.FillWeight = 150F;
            MaHD.HeaderText = "Mã hợp đồng";
            MaHD.MinimumWidth = 6;
            MaHD.Name = "MaHD";
            MaHD.ReadOnly = true;
            MaHD.Width = 128;
            // 
            // MaNV
            // 
            MaNV.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MaNV.DataPropertyName = "MaNV";
            MaNV.HeaderText = "Mã nhân viên";
            MaNV.MinimumWidth = 6;
            MaNV.Name = "MaNV";
            MaNV.ReadOnly = true;
            MaNV.Width = 126;
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
            MaKH.Width = 138;
            // 
            // TenHD
            // 
            TenHD.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TenHD.DataPropertyName = "TenHD";
            TenHD.HeaderText = "Tên hợp đồng";
            TenHD.MinimumWidth = 6;
            TenHD.Name = "TenHD";
            TenHD.ReadOnly = true;
            TenHD.Width = 130;
            // 
            // LoaiDat
            // 
            LoaiDat.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            LoaiDat.DataPropertyName = "LoaiDat";
            LoaiDat.HeaderText = "Loại đất";
            LoaiDat.MinimumWidth = 6;
            LoaiDat.Name = "LoaiDat";
            LoaiDat.ReadOnly = true;
            LoaiDat.Width = 92;
            // 
            // DienTich
            // 
            DienTich.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DienTich.DataPropertyName = "DienTich";
            DienTich.HeaderText = "Diện tích";
            DienTich.MinimumWidth = 6;
            DienTich.Name = "DienTich";
            DienTich.ReadOnly = true;
            DienTich.Width = 97;
            // 
            // TriGia
            // 
            TriGia.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TriGia.DataPropertyName = "TriGia";
            TriGia.HeaderText = "Trị giá";
            TriGia.MinimumWidth = 6;
            TriGia.Name = "TriGia";
            TriGia.ReadOnly = true;
            TriGia.Width = 79;
            // 
            // SoTo
            // 
            SoTo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SoTo.DataPropertyName = "SoTo";
            SoTo.HeaderText = "Số tờ";
            SoTo.MinimumWidth = 6;
            SoTo.Name = "SoTo";
            SoTo.ReadOnly = true;
            SoTo.Width = 73;
            // 
            // SoThua
            // 
            SoThua.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SoThua.DataPropertyName = "SoThua";
            SoThua.HeaderText = "Số thửa";
            SoThua.MinimumWidth = 6;
            SoThua.Name = "SoThua";
            SoThua.ReadOnly = true;
            SoThua.Width = 89;
            // 
            // NgayLap
            // 
            NgayLap.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NgayLap.DataPropertyName = "NgayLap";
            NgayLap.FillWeight = 200F;
            NgayLap.HeaderText = "Ngày lập";
            NgayLap.MinimumWidth = 6;
            NgayLap.Name = "NgayLap";
            NgayLap.ReadOnly = true;
            NgayLap.Width = 98;
            // 
            // panel7
            // 
            panel7.Controls.Add(label9);
            panel7.Controls.Add(txtTimNhanVien);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(1105, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(422, 240);
            panel7.TabIndex = 33;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(27, 115);
            label9.Name = "label9";
            label9.Size = new Size(101, 20);
            label9.TabIndex = 1;
            label9.Text = "Tìm nhân viên";
            // 
            // txtTimNhanVien
            // 
            txtTimNhanVien.Location = new Point(179, 111);
            txtTimNhanVien.Name = "txtTimNhanVien";
            txtTimNhanVien.Size = new Size(178, 27);
            txtTimNhanVien.TabIndex = 0;
            txtTimNhanVien.TextChanged += txtTimNhanVien_TextChanged;
            // 
            // panel8
            // 
            panel8.Controls.Add(label8);
            panel8.Controls.Add(txtTimKhachHang);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(1533, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(374, 240);
            panel8.TabIndex = 34;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 111);
            label8.Name = "label8";
            label8.Size = new Size(115, 20);
            label8.TabIndex = 1;
            label8.Text = "Tìm Khách hàng";
            // 
            // txtTimKhachHang
            // 
            txtTimKhachHang.Location = new Point(169, 108);
            txtTimKhachHang.Name = "txtTimKhachHang";
            txtTimKhachHang.Size = new Size(178, 27);
            txtTimKhachHang.TabIndex = 0;
            txtTimKhachHang.TextChanged += txtTimKhachHang_TextChanged;
            // 
            // dgvNhanVienView
            // 
            dgvNhanVienView.AllowUserToAddRows = false;
            dgvNhanVienView.AllowUserToDeleteRows = false;
            dgvNhanVienView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVienView.Columns.AddRange(new DataGridViewColumn[] { mnvName, HoDem, Ten });
            dgvNhanVienView.Dock = DockStyle.Fill;
            dgvNhanVienView.Location = new Point(1105, 249);
            dgvNhanVienView.Name = "dgvNhanVienView";
            dgvNhanVienView.ReadOnly = true;
            dgvNhanVienView.RowHeadersWidth = 51;
            dgvNhanVienView.RowTemplate.Height = 29;
            dgvNhanVienView.Size = new Size(422, 540);
            dgvNhanVienView.TabIndex = 35;
            dgvNhanVienView.CellClick += dgvNhanVienView_CellClick;
            dgvNhanVienView.RowPostPaint += dgvNhanVienView_RowPostPaint;
            // 
            // mnvName
            // 
            mnvName.DataPropertyName = "MaNV";
            mnvName.HeaderText = "Mã Nhân Viên";
            mnvName.MinimumWidth = 6;
            mnvName.Name = "mnvName";
            mnvName.ReadOnly = true;
            mnvName.Width = 125;
            // 
            // HoDem
            // 
            HoDem.DataPropertyName = "HoDem";
            HoDem.HeaderText = "Họ đệm";
            HoDem.MinimumWidth = 6;
            HoDem.Name = "HoDem";
            HoDem.ReadOnly = true;
            HoDem.Width = 125;
            // 
            // Ten
            // 
            Ten.DataPropertyName = "Ten";
            Ten.HeaderText = "Tên";
            Ten.MinimumWidth = 6;
            Ten.Name = "Ten";
            Ten.ReadOnly = true;
            Ten.Width = 125;
            // 
            // dgvKhachHangView
            // 
            dgvKhachHangView.AllowUserToAddRows = false;
            dgvKhachHangView.AllowUserToDeleteRows = false;
            dgvKhachHangView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHangView.Columns.AddRange(new DataGridViewColumn[] { makhachang, HoDemKH, TenKH });
            dgvKhachHangView.Dock = DockStyle.Fill;
            dgvKhachHangView.Location = new Point(1533, 249);
            dgvKhachHangView.Name = "dgvKhachHangView";
            dgvKhachHangView.ReadOnly = true;
            dgvKhachHangView.RowHeadersWidth = 51;
            dgvKhachHangView.RowTemplate.Height = 29;
            dgvKhachHangView.Size = new Size(374, 540);
            dgvKhachHangView.TabIndex = 36;
            dgvKhachHangView.CellClick += dgvKhachHangView_CellClick;
            dgvKhachHangView.RowPostPaint += dgvKhachHangView_RowPostPaint;
            // 
            // makhachang
            // 
            makhachang.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            makhachang.DataPropertyName = "MaKH";
            makhachang.HeaderText = "Mã Khách Hàng";
            makhachang.MinimumWidth = 6;
            makhachang.Name = "makhachang";
            makhachang.ReadOnly = true;
            makhachang.Width = 143;
            // 
            // HoDemKH
            // 
            HoDemKH.DataPropertyName = "HoDemKH";
            HoDemKH.HeaderText = "Họ đệm ";
            HoDemKH.MinimumWidth = 6;
            HoDemKH.Name = "HoDemKH";
            HoDemKH.ReadOnly = true;
            HoDemKH.Width = 125;
            // 
            // TenKH
            // 
            TenKH.DataPropertyName = "TenKH";
            TenKH.HeaderText = "Tên Khách Hàng";
            TenKH.MinimumWidth = 6;
            TenKH.Name = "TenKH";
            TenKH.ReadOnly = true;
            TenKH.Width = 125;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1924, 831);
            tabControl1.TabIndex = 32;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1916, 798);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Nhập hợp đồng";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tableLayoutPanel2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1916, 798);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Xuất hợp đồng";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(dgvHopDongview, 0, 1);
            tableLayoutPanel2.Controls.Add(panel6, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.7482014F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 85.2518F));
            tableLayoutPanel2.Size = new Size(1910, 792);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // dgvHopDongview
            // 
            dgvHopDongview.AllowUserToAddRows = false;
            dgvHopDongview.AllowUserToDeleteRows = false;
            dgvHopDongview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHopDongview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHopDongview.Columns.AddRange(new DataGridViewColumn[] { IDhopDong, IDNhanVIen, TenNhanVien, IDKhachHang, TenKHachHang, TenHopDong, LoaiDatMua, DienTichDat, TriGiaDat, sotoDat, SoThuaDat, NgayLapHD });
            dgvHopDongview.Dock = DockStyle.Fill;
            dgvHopDongview.Location = new Point(3, 119);
            dgvHopDongview.Name = "dgvHopDongview";
            dgvHopDongview.ReadOnly = true;
            dgvHopDongview.RowHeadersWidth = 51;
            dgvHopDongview.RowTemplate.Height = 29;
            dgvHopDongview.Size = new Size(1904, 670);
            dgvHopDongview.TabIndex = 20;
            dgvHopDongview.RowPostPaint += dgvHopDongview_RowPostPaint;
            // 
            // IDhopDong
            // 
            IDhopDong.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            IDhopDong.DataPropertyName = "MaHD";
            IDhopDong.FillWeight = 150F;
            IDhopDong.HeaderText = "Mã hợp đồng";
            IDhopDong.MinimumWidth = 6;
            IDhopDong.Name = "IDhopDong";
            IDhopDong.ReadOnly = true;
            IDhopDong.Width = 128;
            // 
            // IDNhanVIen
            // 
            IDNhanVIen.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            IDNhanVIen.DataPropertyName = "MaNV";
            IDNhanVIen.HeaderText = "Mã nhân viên";
            IDNhanVIen.MinimumWidth = 6;
            IDNhanVIen.Name = "IDNhanVIen";
            IDNhanVIen.ReadOnly = true;
            IDNhanVIen.Width = 126;
            // 
            // TenNhanVien
            // 
            TenNhanVien.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TenNhanVien.DataPropertyName = "hotennv";
            TenNhanVien.HeaderText = "Tên Nhân Viên";
            TenNhanVien.MinimumWidth = 6;
            TenNhanVien.Name = "TenNhanVien";
            TenNhanVien.ReadOnly = true;
            TenNhanVien.Width = 133;
            // 
            // IDKhachHang
            // 
            IDKhachHang.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            IDKhachHang.DataPropertyName = "MaKH";
            IDKhachHang.FillWeight = 130F;
            IDKhachHang.HeaderText = "Mã khách hàng";
            IDKhachHang.MinimumWidth = 6;
            IDKhachHang.Name = "IDKhachHang";
            IDKhachHang.ReadOnly = true;
            IDKhachHang.Width = 138;
            // 
            // TenKHachHang
            // 
            TenKHachHang.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TenKHachHang.DataPropertyName = "hotenkh";
            TenKHachHang.HeaderText = "Tên Khách Hàng";
            TenKHachHang.MinimumWidth = 6;
            TenKHachHang.Name = "TenKHachHang";
            TenKHachHang.ReadOnly = true;
            TenKHachHang.Width = 145;
            // 
            // TenHopDong
            // 
            TenHopDong.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TenHopDong.DataPropertyName = "TenHD";
            TenHopDong.HeaderText = "Tên hợp đồng";
            TenHopDong.MinimumWidth = 6;
            TenHopDong.Name = "TenHopDong";
            TenHopDong.ReadOnly = true;
            TenHopDong.Width = 130;
            // 
            // LoaiDatMua
            // 
            LoaiDatMua.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            LoaiDatMua.DataPropertyName = "LoaiDat";
            LoaiDatMua.HeaderText = "Loại đất";
            LoaiDatMua.MinimumWidth = 6;
            LoaiDatMua.Name = "LoaiDatMua";
            LoaiDatMua.ReadOnly = true;
            LoaiDatMua.Width = 92;
            // 
            // DienTichDat
            // 
            DienTichDat.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DienTichDat.DataPropertyName = "DienTich";
            DienTichDat.HeaderText = "Diện tích";
            DienTichDat.MinimumWidth = 6;
            DienTichDat.Name = "DienTichDat";
            DienTichDat.ReadOnly = true;
            DienTichDat.Width = 97;
            // 
            // TriGiaDat
            // 
            TriGiaDat.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TriGiaDat.DataPropertyName = "TriGia";
            TriGiaDat.HeaderText = "Trị giá";
            TriGiaDat.MinimumWidth = 6;
            TriGiaDat.Name = "TriGiaDat";
            TriGiaDat.ReadOnly = true;
            TriGiaDat.Width = 79;
            // 
            // sotoDat
            // 
            sotoDat.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            sotoDat.DataPropertyName = "SoTo";
            sotoDat.HeaderText = "Số tờ";
            sotoDat.MinimumWidth = 6;
            sotoDat.Name = "sotoDat";
            sotoDat.ReadOnly = true;
            sotoDat.Width = 73;
            // 
            // SoThuaDat
            // 
            SoThuaDat.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SoThuaDat.DataPropertyName = "SoThua";
            SoThuaDat.HeaderText = "Số thửa";
            SoThuaDat.MinimumWidth = 6;
            SoThuaDat.Name = "SoThuaDat";
            SoThuaDat.ReadOnly = true;
            SoThuaDat.Width = 89;
            // 
            // NgayLapHD
            // 
            NgayLapHD.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NgayLapHD.DataPropertyName = "NgayLap";
            NgayLapHD.FillWeight = 200F;
            NgayLapHD.HeaderText = "Ngày lập";
            NgayLapHD.MinimumWidth = 6;
            NgayLapHD.Name = "NgayLapHD";
            NgayLapHD.ReadOnly = true;
            NgayLapHD.Width = 98;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnXoaDS);
            panel6.Controls.Add(label11);
            panel6.Controls.Add(btnXuat);
            panel6.Controls.Add(txtNhap);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(1904, 110);
            panel6.TabIndex = 0;
            // 
            // btnXoaDS
            // 
            btnXoaDS.Location = new Point(746, 44);
            btnXoaDS.Name = "btnXoaDS";
            btnXoaDS.Size = new Size(94, 29);
            btnXoaDS.TabIndex = 3;
            btnXoaDS.Text = "Xoá";
            btnXoaDS.UseVisualStyleBackColor = true;
            btnXoaDS.Click += btnXoaDS_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(324, 47);
            label11.Name = "label11";
            label11.Size = new Size(70, 20);
            label11.TabIndex = 2;
            label11.Text = "Tìm kiếm";
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(123, 32);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(147, 51);
            btnXuat.TabIndex = 1;
            btnXuat.Text = "Xuất danh sách";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // txtNhap
            // 
            txtNhap.Location = new Point(442, 44);
            txtNhap.Name = "txtNhap";
            txtNhap.Size = new Size(234, 27);
            txtNhap.TabIndex = 0;
            txtNhap.TextChanged += txtNhap_TextChanged;
            // 
            // MaHopDong
            // 
            MaHopDong.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MaHopDong.DataPropertyName = "MaHD";
            MaHopDong.FillWeight = 150F;
            MaHopDong.HeaderText = "Mã hợp đồng";
            MaHopDong.MinimumWidth = 6;
            MaHopDong.Name = "MaHopDong";
            MaHopDong.Width = 125;
            // 
            // frmHopDong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 831);
            Controls.Add(tabControl1);
            Name = "frmHopDong";
            Text = "Hợp đồng";
            Load += frmHopDong_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachHD).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVienView).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHangView).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHopDongview).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox cboHopDong;
        private Button btnXoa;
        private Button btnAdd;
        private Button btnLuu;
        private TextBox txtMaHD;
        private Label label1;
        private Label label2;
        private Label label3;
        private RadioButton rdbDatNongNghiep;
        private RadioButton rdbDatPhiNpngNghiep;
        private RadioButton rdbDatChuaSuDung;
        private ComboBox cbbNongNghiep;
        private ComboBox cbbPhiNongNghiep;
        private ComboBox cbbChuaSuDung;
        private Label label4;
        private TextBox txtDienTich;
        private Label label6;
        private TextBox txtTriGia;
        private Label label5;
        private TextBox txtSoTo;
        private Label label10;
        private TextBox txtSoThua;
        private Button btnSua;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel5;
        private Label label7;
        private DateTimePicker dtpNgayLap;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel6;
        private Button btnXuat;
        private TextBox txtNhap;
        private Label label11;
        private DataGridView dgvDanhSachHD;
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
        private Button btnXoaDS;
        private PictureBox pictureBox1;
        private Panel panel7;
        private Panel panel8;
        private DataGridView dgvNhanVienView;
        private DataGridView dgvKhachHangView;
        private Label label13;
        private Label label12;
        private TextBox txtTenNhanVien;
        private TextBox txtTenKhachHang;
        private DataGridViewTextBoxColumn makhachang;
        private DataGridViewTextBoxColumn HoDemKH;
        private DataGridViewTextBoxColumn TenKH;
        private DataGridViewTextBoxColumn mnvName;
        private DataGridViewTextBoxColumn HoDem;
        private DataGridViewTextBoxColumn Ten;
        private DataGridViewTextBoxColumn MaHopDong;
        private DataGridView dgvHopDongview;
        private DataGridViewTextBoxColumn IDhopDong;
        private DataGridViewTextBoxColumn IDNhanVIen;
        private DataGridViewTextBoxColumn TenNhanVien;
        private DataGridViewTextBoxColumn IDKhachHang;
        private DataGridViewTextBoxColumn TenKHachHang;
        private DataGridViewTextBoxColumn TenHopDong;
        private DataGridViewTextBoxColumn LoaiDatMua;
        private DataGridViewTextBoxColumn DienTichDat;
        private DataGridViewTextBoxColumn TriGiaDat;
        private DataGridViewTextBoxColumn sotoDat;
        private DataGridViewTextBoxColumn SoThuaDat;
        private DataGridViewTextBoxColumn NgayLapHD;
        private Label label9;
        private TextBox txtTimNhanVien;
        private Label label8;
        private TextBox txtTimKhachHang;
    }
}