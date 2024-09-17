using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace NhungConGaBong
{
    public partial class frmKhachHang : Form
    {
        List<KhachHang> khachhangList = new List<KhachHang>();
        List<KhachHang> khList = new List<KhachHang>();
        List<NganHang> nganhangList = new List<NganHang>();
        int maxMakh;
        public frmKhachHang()
        {
            InitializeComponent();
            dgvKhachHang.RowsDefaultCellStyle.BackColor = Color.MintCream;
            dgvKhachHang.AlternatingRowsDefaultCellStyle.BackColor = Color.OldLace;
            dgvXuatKH.RowsDefaultCellStyle.BackColor = Color.MintCream;
            dgvXuatKH.AlternatingRowsDefaultCellStyle.BackColor = Color.OldLace;
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = path + @"\FileNganHang.csv";
            nganhangList = NganHang.ReadFromFile(fileName);
            cboNH.DataSource = nganhangList;
            cboNH.DisplayMember = "TenGD";
            cboNH.ValueMember = "ID";
            cboNH.SelectedIndex = -1;

            cboTimNganHang.DataSource = nganhangList;
            cboTimNganHang.DisplayMember = "TenGD";
            cboTimNganHang.ValueMember = "ID";
            cboTimNganHang.SelectedIndex = -1;

            fileName = path + @"\FileKhachHang.csv";
            khachhangList = KhachHang.ReadFromFile(fileName);

            gpbThongTin.Hide();
            if (khachhangList.Count == 0)
            {
                Random random = new Random();
                maxMakh = random.Next(100000000, 999999999);
                txtMaKH.Text = "KH" + maxMakh.ToString("D2");
            }
            else
            {
                if (khachhangList.Any(kh => kh.MaKH.StartsWith("KH")))
                {
                    khachhangList.ForEach(kh => kh.MaKH = kh.MaKH.Replace("KH", ""));
                }
                maxMakh = khachhangList.Select(kh => Convert.ToInt32(kh.MaKH)).Max();
                txtMaKH.Text = "KH" + (maxMakh + 1).ToString("D2");
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvKhachHang.Rows.Count)
            {
                btnHienSua.Enabled = true;
                btnXoa.Enabled = true;

                DataGridViewRow selectedRow = dgvKhachHang.Rows[e.RowIndex];
                txtMaKH.Text = selectedRow.Cells["MaKH"].Value.ToString()!;
                txtHoDem.Text = selectedRow.Cells["HoDem"].Value.ToString();
                txtTen.Text = selectedRow.Cells["tenKH"].Value.ToString();
                txtSDT.Text = selectedRow.Cells["Dienthoai"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                txtMaSoThue.Text = selectedRow.Cells["MaSoThue"].Value.ToString();
                txtSoTK.Text = selectedRow.Cells["stk"].Value.ToString();
                cboNH.SelectedValue = Convert.ToInt32(selectedRow.Cells["NganHangID"].Value);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dgvKhachHang.AutoGenerateColumns = false;

            KhachHang kh = new KhachHang();
            kh.MaKH = txtMaKH.Text;
            if(txtHoDem.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập họ đệm","Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoDem.Focus();
                return;
            }    
            kh.HoDemKH = GetString.Proper(txtHoDem.Text);
            if (txtTen.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoDem.Focus();
                return;
            }
            kh.TenKH = GetString.Proper(txtTen.Text);
            if (txtSDT.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoDem.Focus();
                return;
            }
            kh.DienThoai = txtSDT.Text;
            if (!Input.IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ email hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            kh.Email = txtEmail.Text;
            kh.MaSoThue = txtMaSoThue.Text;
            kh.STK = txtSoTK.Text;
            kh.NgayLap = DateTime.Now.Date;
            kh.NganHangID = Convert.ToInt32(cboNH.SelectedValue);
            khList.Add(kh);

            maxMakh++;
            txtMaKH.Text = "KH" + (maxMakh + 1).ToString("D2");

            dgvKhachHang.DataSource = null;
            dgvKhachHang.DataSource = khList;
            dgvKhachHang.AutoGenerateColumns = true;

            btnLuu.Enabled = true;

            Input.ClearTextBoxes(this, txtMaKH);
            cboNH.SelectedIndex = -1;
            txtHoDem.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string _Path = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = _Path + @"\FileKhachHang.csv";
            KhachHang.SaveToFile(khList, fileName, true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dgvKhachHang.AutoGenerateColumns = false;

            KhachHang kh = khList.FirstOrDefault(kh => kh.MaKH == txtMaKH.Text);
            if (kh != null)
            {
                kh.HoDemKH = GetString.Proper(txtHoDem.Text);
                kh.TenKH = GetString.Proper(txtTen.Text);
                kh.DienThoai = txtSDT.Text;
                if (!Input.IsValidEmail(txtEmail.Text))
                {
                    MessageBox.Show("Vui lòng nhập địa chỉ email hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Focus();
                    return;
                }
                kh.Email = txtEmail.Text;
                kh.MaSoThue = txtMaSoThue.Text;
                kh.STK = txtSoTK.Text;
                kh.NganHangID = Convert.ToInt32(cboNH.SelectedValue);
                dgvKhachHang.DataSource = null;
                dgvKhachHang.DataSource = khList;
                dgvKhachHang.AutoGenerateColumns = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dgvKhachHang.AutoGenerateColumns = false;
            int selectedIndex = dgvKhachHang.SelectedCells[0].RowIndex;
            if (selectedIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá khách hàng này?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    khList.RemoveAt(selectedIndex);
                    dgvKhachHang.DataSource = null;
                    dgvKhachHang.DataSource = khList;
                    dgvKhachHang.AutoGenerateColumns = true;
                }
            }
        }

        private void FilterLinQ(string text)
        {
            text = text.ToUpper();
            var results = from s in khachhangList
                          join ng in nganhangList on s.NganHangID equals ng.ID
                          where s.HoDemKH.ToUpper().Contains(text) || s.TenKH.ToUpper().Contains(text) || s.MaKH.Contains(text) || ng.TenNH.Contains(text)
                          select new { s.MaKH, s.HoDemKH, s.TenKH, s.DienThoai, s.Email, s.MaSoThue, s.STK, Nghang = ng.TenNH };
            dgvXuatKH.DataSource = results.ToList();
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            string text = txtTim.Text.Trim();
            FilterLinQ(text);
        }

        private void btnXuatDS_Click(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = path + @"\FileKhachHang.csv";
            khachhangList = KhachHang.ReadFromFile(fileName);
            var results = khachhangList.Join(nganhangList, sv => sv.NganHangID, ng => ng.ID,
                    (st, ind) =>
                    {
                        string Nghang = ind.TenNH;
                        return new { st.MaKH, st.HoDemKH, st.TenKH, st.DienThoai, st.Email, st.MaSoThue, st.STK, Nghang, st.NganHangID, st.NgayLap };
                    });
            dgvXuatKH.DataSource = results.ToList();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            btnSua.Hide();
            btnThem.Hide();
            gpbThongTin.Hide();
        }

        private void btnHienThem_Click(object sender, EventArgs e)
        {
            gpbThongTin.Visible = true;
            btnSua.Hide();
            btnThem.Visible = true;
        }

        private void btnHienSua_Click(object sender, EventArgs e)
        {
            gpbThongTin.Visible = true;
            btnThem.Hide();
            btnSua.Visible = true;
        }

        private void dgvKhachHang_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            SacDataGridView.SetRowNumber(sender, e);
        }

        private void btnXoaDS_Click(object sender, EventArgs e)
        {
            dgvXuatKH.AutoGenerateColumns = false;
            int selectedIndex = dgvXuatKH.SelectedCells[0].RowIndex;
            if (selectedIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá khách hàng này?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    khachhangList.RemoveAt(selectedIndex);
                    
                    dgvXuatKH.DataSource = null;
                    dgvXuatKH.DataSource = khachhangList;
                    dgvXuatKH.AutoGenerateColumns = true;
                }
            }
        }

        private void btnThemNH_Click(object sender, EventArgs e)
        {
            var frm = new frmNganHang();
            frm.ShowDialog();
            frmKhachHang_Load(sender, e);
            gpbThongTin.Visible = true;
        }

        private void cboTimNganHang_SelectionChangeCommitted(object sender, EventArgs e)
        {

            int nghangId = Convert.ToInt32(cboTimNganHang.SelectedValue);
            //sinhvienList và nganhList là Thành viên của frmStudentView Class
            var results = khachhangList.Join(nganhangList, sv => sv.NganHangID, ng => ng.ID,
                    (st, ind) =>
                    {
                        string Nghang = ind.TenNH;
                        return new { st.MaKH, st.HoDemKH, st.TenKH, st.DienThoai, st.Email, st.MaSoThue, st.STK, Nghang, st.NganHangID, st.NgayLap };
                    }).Where(s => s.NganHangID == nghangId);

            // Binding / Bound dữ liệu từ List được trả về từ truy vấn trên vào DataGirdView (dgvStudent)
            dgvXuatKH.DataSource = results.ToList();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Input.SoNguyen(e);
            txtSDT.MaxLength = 11;
        }

        private void txtMaSoThue_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtMaSoThue.MaxLength = 13;
        }

        private void dgvXuatKH_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string fieldName = dgvXuatKH.Columns[e.ColumnIndex].Name;
            // Lấy trạng thái đã SortOrder
            SortOrder strSortOrder = getSortOrder(e.ColumnIndex);

            if (strSortOrder == SortOrder.Ascending)
            {
                dgvXuatKH.DataSource = khachhangList.OrderBy(p => p.GetType().GetProperty(fieldName).GetValue(p, null)).ToList();
            }
            else
            {
                dgvXuatKH.DataSource = khachhangList.OrderByDescending(p => p.GetType().GetProperty(fieldName).GetValue(p, null)).ToList();
            }
            dgvKhachHang.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = strSortOrder;
        }
        private SortOrder getSortOrder(int columnIndex)
        {
            if (dgvXuatKH.Columns[columnIndex].HeaderCell.SortGlyphDirection == SortOrder.None ||
                dgvXuatKH.Columns[columnIndex].HeaderCell.SortGlyphDirection == SortOrder.Descending)
            {
                dgvXuatKH.Columns[columnIndex].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
                return SortOrder.Ascending;
            }
            else
            {
                dgvXuatKH.Columns[columnIndex].HeaderCell.SortGlyphDirection = SortOrder.Descending;
                return SortOrder.Descending;
            }
        }

        private void dgvXuatKH_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            SacDataGridView.SetRowNumber(sender, e);
        }

        private void txtSoTK_KeyPress(object sender, KeyPressEventArgs e)
        {
            Input.SoNguyen(e);
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            string _Path = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = _Path + @"\FileKhachHang.csv";
            KhachHang.SaveToFile(khachhangList, fileName, false);
        }
    }
}
