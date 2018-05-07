using QUANLYKHACHSAN_G4_TEAM.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYKHACHSAN_G4_TEAM
{
    public partial class ManHinhChinh : Form
    {
       
        public ManHinhChinh()
        {
            InitializeComponent();
           
        }

       
        private void ManHinhChinh_FormClosing(object sender, FormClosingEventArgs e)
        { 
            if (MessageBox.Show("Bạn Có muốn thoát chương trình? ", "Thông báo", MessageBoxButtons.OKCancel)!= DialogResult.OK)
            {
                e.Cancel = true;
            }
                

        }


        #region PictureBox
      

        private void ptbThanhToan_Click(object sender, EventArgs e)
        {
            ThanhToan.fThanhToan thanhtoan = new ThanhToan.fThanhToan();
            thanhtoan.ShowDialog();
            
        }

        private void ptbQuanLiPhong_Click(object sender, EventArgs e)
        {
            QuanLiPhong.fQuanLiPhong roommanage = new QuanLiPhong.fQuanLiPhong();
            roommanage.ShowDialog();
        }

        private void ptbTraCuuPhong_Click(object sender, EventArgs e)
        {
            TraCuuPhong.fTraCuuPhong tracuuphong = new TraCuuPhong.fTraCuuPhong();
            tracuuphong.ShowDialog();
        }

        private void ptbQuanLiKhachHang_Click(object sender, EventArgs e)
        {
            TraCuuKhachHang.fTimKhachHang kh = new TraCuuKhachHang.fTimKhachHang();
            kh.ShowDialog();
        }

        private void ptbQuanLiDichVu_Click(object sender, EventArgs e)
        {
            QuanLiDichVu.fQuanLiDichVu qldv = new QuanLiDichVu.fQuanLiDichVu();
            qldv.ShowDialog();
        }

        private void ptbDatPhong_Click(object sender, EventArgs e)
        {
            DatPhong.fPhongKS phong = new DatPhong.fPhongKS();
            phong.ShowDialog();
        }

        private void ptbDoanhThu_Click(object sender, EventArgs e)
        {
            DoanhThu.fQLDoanhThu doanhthu = new DoanhThu.fQLDoanhThu();
            doanhthu.ShowDialog();
        }


        #endregion

        private void ptbQuyDinh_Click(object sender, EventArgs e)
        {
            ThayDoiQuyDinh.fThayDoiQuyDinh qd = new ThayDoiQuyDinh.fThayDoiQuyDinh();
            qd.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThuNho_Click(object sender, EventArgs e)
        {
             this.WindowState = FormWindowState.Minimized;
        }
    }
}
