using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiKhachSanG4Team
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnThuNho_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pcbDatPhong_Click(object sender, EventArgs e)
        {
            frmPhong p = new frmPhong();
            p.ShowDialog();

        }

        private void pcbThanhToan_Click(object sender, EventArgs e)
        {
            frmThanhToan tt = new frmThanhToan();
            tt.ShowDialog();
        }

        private void pcbThayDoiQuyDinh_Click(object sender, EventArgs e)
        {
            frmThayDoiQuyDinh tdqd = new frmThayDoiQuyDinh();
            tdqd.ShowDialog();
        }

        private void pcbTimPhong_Click(object sender, EventArgs e)
        {
            frmTimPhong tp = new frmTimPhong();
            tp.ShowDialog();
        }

        private void pcbTimKhachHang_Click(object sender, EventArgs e)
        {
            frmTimKhachHang tkh = new frmTimKhachHang();
            tkh.ShowDialog();
        }

        private void pcbQuanLiPhong_Click(object sender, EventArgs e)
        {
            frmQuanLiPhong qlp = new frmQuanLiPhong();
            qlp.ShowDialog();
        }

        private void pcbQuanLiDichVu_Click(object sender, EventArgs e)
        {
            frmQuanLiDichVu qldv = new frmQuanLiDichVu();
            qldv.ShowDialog();
        }

        private void pcbDoanhThu_Click(object sender, EventArgs e)
        {
            frmDoanhThu dt = new frmDoanhThu();
            dt.ShowDialog();
        }
    }
}
