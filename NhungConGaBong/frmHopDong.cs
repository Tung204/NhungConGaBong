using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhungConGaBong
{
    public partial class frmHopDong : Form
    {
        List<HopDong> hdList = new List<HopDong>();
        List<NhanVien> nvList = new List<NhanVien>();
        List<KhachHang> khList = new List<KhachHang>();
        public int selectedIndex;
        public frmHopDong()
        {
            InitializeComponent();
            dgvDanhSachHD.RowsDefaultCellStyle.BackColor = Color.MintCream;
            dgvDanhSachHD.AlternatingRowsDefaultCellStyle.BackColor = Color.OldLace;
        }
        public void frmHopDong_Load(object sender, EventArgs e)
        {
            ComBoBoxDatNongNghiep();
            ComBoBoxChonTenHD();
            ComBoBoxDatChuaSuDung();
            ComBoBoxDatPhiNongNghiep();
            cbbChuaSuDung.Enabled = false;
            cbbNongNghiep.Enabled = false;
            cbbPhiNongNghiep.Enabled = false;
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = path + @"FileKhachHang.csv";
            khList = KhachHang.ReadFromFile(fileName);
            cboKhachHang.DataSource = khList;
            cboKhachHang.DisplayMember = "MaKH";
            cboKhachHang.SelectedIndex = 0;
            fileName = path + @"FileNhanVien.csv";
            nvList = NhanVien.ReadFromFile(fileName);
            cboNhanVien.DataSource = nvList;
            cboNhanVien.DisplayMember = "MaNV";
            hdList.Clear();

        }
        void ComBoBoxChonTenHD()
        {
            cboHopDong.Items.Add("Đăng kí quyền sở hữu đất");
            cboHopDong.Items.Add("Chuyển nhượng quyền sử đụng đất");
            cboHopDong.Items.Add("Đấu giá đất");
            cboHopDong.Items.Add("Quyền sửa chữa nhà");
        }
        void ComBoBoxDatNongNghiep()
        {
            cbbNongNghiep.Items.Add("1. Đất chuyên trồng lúa nước");
            cbbNongNghiep.Items.Add("2. Đất trồng lúa nước còn lại");
            cbbNongNghiep.Items.Add("3. Đất lúa nương");
            cbbNongNghiep.Items.Add("4. Đất bằng trồng cây hàng năm khác");
            cbbNongNghiep.Items.Add("5. Đất nương rẫy trồng cây hàng năm khác");
            cbbNongNghiep.Items.Add("6. Đất trồng cây lâu năm");
            cbbNongNghiep.Items.Add("7. Đất rừng sản xuất");
            cbbNongNghiep.Items.Add("8. Đất rừng phòng hộ");
            cbbNongNghiep.Items.Add("9. Đất rừng đặc dụng");
            cbbNongNghiep.Items.Add("10. Đất nuôi trồng thủy sản");
            cbbNongNghiep.Items.Add("11. Đất làm muối");
            cbbNongNghiep.Items.Add("12. Đất nông nghiệp khác");
        }
        void ComBoBoxDatPhiNongNghiep()
        {
            cbbPhiNongNghiep.Items.Add("1. Đất ở tại nông thôn");
            cbbPhiNongNghiep.Items.Add("2.Đất ở tại đô thị");
            cbbPhiNongNghiep.Items.Add("3. Đất xây dựng cơ sở giáo dục và đào tạo");
            cbbPhiNongNghiep.Items.Add("4. Đất xây dựng cơ sở thể dục thể thao");
            cbbPhiNongNghiep.Items.Add("5. Đất xây dựng cơ sở khoa học và công nghệ");
            cbbPhiNongNghiep.Items.Add("6. Đất an ninh");
            cbbPhiNongNghiep.Items.Add("7. Đất khu công nghiệp");
            cbbPhiNongNghiep.Items.Add("8. Đất khu vui chơi, giải trí công cộng");
            cbbPhiNongNghiep.Items.Add("9. Đất chợ");
            cbbPhiNongNghiep.Items.Add("10. Đất công trình năng lượng");
            cbbPhiNongNghiep.Items.Add("11. Đất công trình bưu chính, viễn thông");
            cbbPhiNongNghiep.Items.Add("12. Đất có di tích lịch sử - văn hóa");
            cbbPhiNongNghiep.Items.Add("13. Đất danh lam thắng cảnh");
            cbbPhiNongNghiep.Items.Add("14. Đất cơ sở tôn giáo");
            cbbPhiNongNghiep.Items.Add("15. Đất sông, ngòi, kênh, rạch, suối");
            cbbPhiNongNghiep.Items.Add("16. Đất làm nghĩa trang, nghĩa địa, nhà tang lễ, nhà hỏa táng");
        }
        void ComBoBoxDatChuaSuDung()
        {
            cbbChuaSuDung.Items.Add("1. Đất bằng chưa sử dụng");
            cbbChuaSuDung.Items.Add("2. Đất đồi núi chưa sử dụng");
            cbbChuaSuDung.Items.Add("3. Núi đá không có rừng cây");

        }
        public void btnAdd_Click(object sender, EventArgs e)
        {
            dgvDanhSachHD.AutoGenerateColumns = false;

            HopDong hd = new HopDong();
            hd.MaHD = txtMaHD.Text;
            hd.TenHD = cboHopDong.Text;
            if (rdbDatNongNghiep.Checked == true)
                hd.LoaiDat = cbbPhiNongNghiep.Text;

            if (rdbDatPhiNpngNghiep.Checked == true)
                hd.LoaiDat = cbbPhiNongNghiep.Text;
            if (rdbDatChuaSuDung.Checked == true)
                hd.LoaiDat = cbbChuaSuDung.Text;
            hd.MaNV = cboNhanVien.Text;
            hd.MaKH = cboKhachHang.Text;
            hd.DienTich = txtDienTich.Text;
            hd.SoTo = Convert.ToInt32(txtSoTo.Text);
            hd.SoThua = Convert.ToInt32(txtSoThua.Text);
            hd.TriGia = txtTriGia.Text;
            hd.NgayLap = Convert.ToDateTime(dtpNgayLap.Value);

            hdList.Add(hd);
            dgvDanhSachHD.DataSource = hdList;
            dgvDanhSachHD.AutoGenerateColumns = true;
        }


        private void rdbDatChuaSuDung_CheckedChanged(object sender, EventArgs e)
        {
            cbbChuaSuDung.Enabled = true;
            cbbNongNghiep.SelectedIndex = -1;
            cbbPhiNongNghiep.SelectedIndex = -1;
            cbbNongNghiep.Enabled = false;
            cbbPhiNongNghiep.Enabled = false;
        }

        private void rdbDatNongNghiep_CheckedChanged(object sender, EventArgs e)
        {
            cbbNongNghiep.Enabled = true;
            cbbChuaSuDung.SelectedIndex = -1;
            cbbPhiNongNghiep.SelectedIndex = -1;
            cbbChuaSuDung.Enabled = false;
            cbbPhiNongNghiep.Enabled = false;
        }

        private void rdbDatPhiNpngNghiep_CheckedChanged(object sender, EventArgs e)
        {
            cbbPhiNongNghiep.Enabled = true;
            cbbNongNghiep.SelectedIndex = -1;
            cbbChuaSuDung.SelectedIndex = -1;
            cbbChuaSuDung.Enabled = false;
            cbbNongNghiep.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string _Path = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = _Path + @"\FileHopDong.csv";
            HopDong.SaveToFile(hdList, fileName, true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dgvDanhSachHD.AutoGenerateColumns = false;
            int selectedIndex = dgvDanhSachHD.SelectedCells[0].RowIndex;
            if (selectedIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá khách hàng này?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); hdList.RemoveAt(selectedIndex);
                dgvDanhSachHD.DataSource = null;
                dgvDanhSachHD.DataSource = hdList;
                dgvDanhSachHD.AutoGenerateColumns = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dgvDanhSachHD.AutoGenerateColumns = false;
            string MaKH = cboKhachHang.Text;
            string MaNV = cboNhanVien.Text;
            string MaHD = txtMaHD.Text;
            string TenHD = cboHopDong.Text;
            string LoaiDat = "";
            if (rdbDatNongNghiep.Checked == true)
                LoaiDat = cbbPhiNongNghiep.Text;
            if (rdbDatPhiNpngNghiep.Checked == true)
                LoaiDat = cbbPhiNongNghiep.Text;
            if (rdbDatChuaSuDung.Checked == true)
                LoaiDat = cbbChuaSuDung.Text;
            string DienTich = txtDienTich.Text;
            int SoTo = Convert.ToInt32(txtSoTo.Text);
            int SoThua = Convert.ToInt32(txtSoThua.Text);
            string TriGia = txtTriGia.Text;
            DateTime NgayLap;
            NgayLap = DateTime.Now;
            HopDong hopDong = hdList.FirstOrDefault(hd => hd.MaHD == MaHD);
            if (hopDong != null)
            {
                hopDong.MaHD = MaHD;
                hopDong.MaNV = MaNV;
                hopDong.MaKH = MaKH;
                hopDong.LoaiDat = LoaiDat;
                hopDong.TenHD = TenHD;
                hopDong.DienTich = DienTich;
                hopDong.SoTo = SoTo;
                hopDong.SoThua = SoThua;
                hopDong.TriGia = TriGia;
                hopDong.NgayLap = NgayLap;

                dgvDanhSachHD.DataSource = null;
                dgvDanhSachHD.DataSource = hdList;
                dgvDanhSachHD.AutoGenerateColumns = true;
            }
        }

        private void dgvDanhSachHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSachHD.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvDanhSachHD.Rows[e.RowIndex];

                txtMaHD.Text = selectedRow.Cells["MaHD"].Value.ToString();
                cboNhanVien.Text = selectedRow.Cells["MaNV"].Value.ToString();
                cboKhachHang.Text = selectedRow.Cells["MaKH"].Value.ToString();
                cboHopDong.Text = selectedRow.Cells["TenHD"].Value.ToString();
                txtDienTich.Text = selectedRow.Cells["DienTich"].Value.ToString();
                txtSoTo.Text = selectedRow.Cells["SoTo"].Value.ToString();
                txtSoThua.Text = selectedRow.Cells["SoThua"].Value.ToString();
                txtTriGia.Text = selectedRow.Cells["TriGia"].Value.ToString();
                dtpNgayLap.Text = selectedRow.Cells["NgayLap"].Value.ToString();
                if (rdbDatNongNghiep.Checked == true)
                    cbbPhiNongNghiep.SelectedValue = selectedRow.Cells["LoaiDat"].Value.ToString();
                if (rdbDatPhiNpngNghiep.Checked == true)
                    cbbPhiNongNghiep.SelectedValue = selectedRow.Cells["LoaiDat"].Value.ToString();
                if (rdbDatChuaSuDung.Checked == true)
                    cbbChuaSuDung.SelectedValue = selectedRow.Cells["LoaiDat"].Value.ToString();
            }

        }
        private void cboKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboKhachHang.ValueMember = "HoDemKH";
            if (cboKhachHang.SelectedIndex >= 0)
            {
                lblKhachHang.Text = cboKhachHang.SelectedValue.ToString();
                cboKhachHang.ValueMember = "TenKH";
                lblKhachHang.Text += " " + cboKhachHang.SelectedValue.ToString();
            }
            else
                lblKhachHang.Text = "";
        }
        private void cboNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboNhanVien.ValueMember = "HoDem";
            if (cboNhanVien.SelectedIndex >= 0)
            {
                lblNhanVien.Text = cboNhanVien.SelectedValue.ToString();
                cboNhanVien.ValueMember = "Ten";
                lblNhanVien.Text += " " + cboNhanVien.SelectedValue.ToString();
            }
            else
                lblNhanVien.Text = "";
        }

        private void dgvDanhSachHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
