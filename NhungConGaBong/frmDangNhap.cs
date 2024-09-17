using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace NhungConGaBong
{
    public partial class frmDangNhap : Form
    {
        Hashtable ht = new Hashtable();
        public frmDangNhap()
        {
            InitializeComponent();
            CenterPictureBox();
            ht.Add("Admin", "Admin123");
        }
        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ckHienMK_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !ckHienMK.Checked;
        }
        private void CenterPictureBox()
        {
            pictureBox1.Location = new Point((this.ClientSize.Width - pictureBox1.Width) / 2, 0);
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (ht.Contains(txtTenDangNhap.Text))
            {
                if (ht[txtTenDangNhap.Text].ToString() == txtMatKhau.Text)
                {
                    var frm = new frmQLKH();
                    this.Hide();
                    frm.ShowDialog();
                    //this.Show();
                }
                else
                {
                    MessageBox.Show("Mật khẩu không đúng vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMatKhau.Focus();
                }
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDangNhap.Focus();
            }
        }
    }
}
