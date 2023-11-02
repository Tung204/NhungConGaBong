using System;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace NhungConGaBong
{
    public partial class FrmNhanVien : Form
    {
        List<NhanVien> nvList = new List<NhanVien>();
        //List<NhanVien> nhanVienList = new List<NhanVien>();
        int rowIndex = -1;
        int index;
        public FrmNhanVien()
        {
            InitializeComponent();
            dgvNhanVienView.AutoGenerateColumns = false;
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = path + @"\FileNhanVien.csv";
            nvList = NhanVien.ReadFromFile(fileName);

            //Tim va hien thi ma nv moi truoc khi nhap
            string maxMaNV = nvList.Select(nv => nv.MaNV)
                         .Where(maNV => maNV.StartsWith("NV"))
                         .OrderByDescending(maNV => maNV)
                         .FirstOrDefault();
            if (maxMaNV != null)
            {
                int currentNumber = int.Parse(maxMaNV.Substring(2));
                string newMaNV = "NV" + (currentNumber + 1).ToString("D2");
                txtMaNV.Text = newMaNV;
            }

        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            //dgvNhanVien.AutoGenerateColumns = false;
            //NhanVien nv = new NhanVien();

            //nv.MaNV = txtMaNV.Text;
            //nv.HoDem = txtHoDem.Text;
            //nv.Ten = txtTen.Text;
            //nv.NgaySinh = dtpNgaySinh.Text;
            //nv.GioiTinh = cboGioiTinh.Text;
            //nv.DiaChi = txtDiaChi.Text;
            //nv.SDT = txtSDT.Text;

            //nvList.Add(nv);

            //dgvNhanVien.DataSource = nvList;
            //dgvNhanVien.AutoGenerateColumns = true;
            dgvNhanVien.AutoGenerateColumns = false;
            NhanVien nv = new NhanVien();

            string newMaNV = txtMaNV.Text;

            nv.MaNV = newMaNV;
            nv.HoDem = txtHoDem.Text;
            nv.Ten = txtTen.Text;
            nv.NgaySinh = dtpNgaySinh.Text;
            nv.GioiTinh = cboGioiTinh.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.SDT = txtSDT.Text;

            nvList.Add(nv);

            //hien thi ma nhan vien tiep theo
            int currentNumber = int.Parse(newMaNV.Substring(2));
            string nextMaNV = "NV" + (currentNumber + 1).ToString("D2");
            txtMaNV.Text = nextMaNV;

            dgvNhanVien.DataSource = nvList;
            dgvNhanVien.AutoGenerateColumns = true;
        }

        private void btnSaveToFile_Click_1(object sender, EventArgs e)
        {
            string _Path = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = _Path + @"\FileNhanVien.csv";
            List<NhanVien> existingData = NhanVien.ReadFromFile(fileName);
            foreach (var nv in existingData)
            {
                if (!nvList.Any(item => item.MaNV == nv.MaNV))
                {
                    nvList.Add(nv);
                }
            }
            var newData = existingData.Where(nv => !nvList.Any(item => item.MaNV == nv.MaNV)).ToList();
            nvList.AddRange(newData);

            NhanVien.SaveToFile(nvList, fileName, false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<NhanVien> nvDelete = new List<NhanVien>();

            foreach (DataGridViewRow row in dgvNhanVien.Rows)
            {
                if (row.Cells["Xoa"].Value != null && (bool)row.Cells["Xoa"].Value == true)
                {
                    string maNV = row.Cells["MaNV"].Value.ToString();
                    NhanVien NhanvienDelete = nvList.FirstOrDefault(nv => nv.MaNV == maNV);

                    if (NhanvienDelete != null)
                    {
                        nvDelete.Add(NhanvienDelete);
                    }
                }
            }

            foreach (var Nhanvien in nvDelete)
            {
                nvList.Remove(Nhanvien);
            }

            dgvNhanVien.DataSource = null;
            dgvNhanVien.DataSource = nvList;

            string _Path = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = _Path + @"\FileNhanVien.csv";
            NhanVien.SaveToFile(nvList, fileName, false);
            //if (index >= 0)
            //{

            //    nvList[index].MaNV = txtMaNV.Text;
            //    nvList[index].HoDem = txtHoDem.Text;
            //    nvList[index].Ten = txtTen.Text;
            //    nvList[index].GioiTinh = cboGioiTinh.Text;
            //    nvList[index].NgaySinh = dtpNgaySinh.Text;
            //    nvList[index].DiaChi = txtDiaChi.Text;
            //    nvList[index].SDT = txtSDT.Text;
            //    nvList.Sort((a, b) => a.MaNV.CompareTo(b.MaNV));
            //    dgvNhanVien.DataSource = null;
            //    dgvNhanVien.DataSource = nvList;
            //}
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvNhanVien.SelectedRows[0];

                txtMaNV.Text = selectedRow.Cells["MaNV"].Value.ToString();
                txtHoDem.Text = selectedRow.Cells["HoDem"].Value.ToString();
                txtTen.Text = selectedRow.Cells["Ten"].Value.ToString();
                dtpNgaySinh.Text = selectedRow.Cells["NgaySinh"].Value.ToString();
                cboGioiTinh.Text = selectedRow.Cells["GioiTinh"].Value.ToString();
                txtDiaChi.Text = selectedRow.Cells["DiaChi"].Value.ToString();
                txtSDT.Text = selectedRow.Cells["SDT"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvNhanVien.SelectedRows[0];

                string selectedMaNV = selectedRow.Cells["MaNV"].Value.ToString();

                // Find the NhanVien object in the list with the same MaNV
                NhanVien nhanVienToUpdate = nvList.FirstOrDefault(nv => nv.MaNV == selectedMaNV);

                if (nhanVienToUpdate != null)
                {
                    // Update the NhanVien object with the data from the textboxes
                    nhanVienToUpdate.MaNV = txtMaNV.Text;
                    nhanVienToUpdate.HoDem = txtHoDem.Text;
                    nhanVienToUpdate.Ten = txtTen.Text;
                    nhanVienToUpdate.NgaySinh = dtpNgaySinh.Text;
                    nhanVienToUpdate.GioiTinh = cboGioiTinh.Text;
                    nhanVienToUpdate.DiaChi = txtDiaChi.Text;
                    nhanVienToUpdate.SDT = txtSDT.Text;

                    // Refresh the DataGridView to reflect the changes
                    dgvNhanVien.Refresh();

                    // Optionally, save the updated data to the CSV file if needed
                    string _Path = AppDomain.CurrentDomain.BaseDirectory;
                    string fileName = _Path + @"\FileNhanVien.csv";
                    NhanVien.SaveToFile(nvList, fileName, false);
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            string _Path = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = _Path + @"\FileNhanVien.csv";
            List<NhanVien> nhanVienList = NhanVien.ReadFromFile(fileName);

            //dgvNhanVienView.AutoGenerateColumns = false;
            //dgvNhanVienView.DataSource = nhanVienList;
            //dgvNhanVienView.Columns["Mã nhân viên"].DataPropertyName = "MaNV";
            //dgvNhanVienView.Columns["H? ??m"].DataPropertyName = "HoDem";
            //dgvNhanVienView.Columns["Tên"].DataPropertyName = "Ten";
            //dgvNhanVienView.Columns["Ngày sinh"].DataPropertyName = "NgaySinh";
            //dgvNhanVienView.Columns["Gi?i tính"].DataPropertyName = "GioiTinh";
            //dgvNhanVienView.Columns["??a ch?"].DataPropertyName = "DiaChi";
            //dgvNhanVienView.Columns["S? ?i?n tho?i"].DataPropertyName = "SDT";
            dgvNhanVienView.DataSource = nhanVienList;
            dgvNhanVienView.Columns["MaNhanVien"].DataPropertyName = "MaNV";
            dgvNhanVienView.Columns["HoDemNV"].DataPropertyName = "HoDem";
            dgvNhanVienView.Columns["TenNV"].DataPropertyName = "Ten";
            dgvNhanVienView.Columns["NgaySinhNV"].DataPropertyName = "NgaySinh";
            dgvNhanVienView.Columns["GioiTinhNV"].DataPropertyName = "GioiTinh";
            dgvNhanVienView.Columns["DiaChiNV"].DataPropertyName = "DiaChi";
            dgvNhanVienView.Columns["SDTnv"].DataPropertyName = "SDT";

            dgvNhanVienView.AutoGenerateColumns = true;
        }

        private void FilterNhanVienLinQ2(string text)
        {
            text = text.ToUpper();
            var filtered = from n in nvList
                           where n.MaNV.ToUpper().Contains(text) || n.HoDem.ToUpper().Contains(text) || n.Ten.ToUpper().Contains(text) ||
                           n.SDT.ToUpper().Contains(text) || n.NgaySinh.ToUpper().Contains(text) || n.GioiTinh.ToUpper().Contains(text) || n.DiaChi.ToUpper().Contains(text)
                           select n;
            dgvNhanVienView.DataSource = filtered.ToList();

        }
        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            string text = txtFind.Text.Trim();
            FilterNhanVienLinQ2(text);
        }
    }

}