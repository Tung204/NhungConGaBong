using System;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            new FrmNhanVien().ShowDialog();
        }

        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            new frmKhachHang().ShowDialog();
        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            new frmHopDong().ShowDialog();  
        }
    }
}
