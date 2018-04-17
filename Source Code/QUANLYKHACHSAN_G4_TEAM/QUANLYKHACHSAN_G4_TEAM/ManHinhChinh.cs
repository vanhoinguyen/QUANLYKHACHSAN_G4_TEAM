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

       
       /*private void ManHinhChinh_FormClosing(object sender, FormClosingEventArgs e)
        { 
            if (MessageBox.Show("Bạn Có muốn thoát chương trình? ", "Thông báo", MessageBoxButtons.OKCancel)!= DialogResult.OK)
            {
                e.Cancel = true;
            }
                

        }*/


       
        #region Main
        private void ptbDatPhong_Click_1(object sender, EventArgs e)
        {
            DatPhong.fPhong phong = new DatPhong.fPhong();
            phong.ShowDialog();
        }

        private void ptbThanhToan_Click_1(object sender, EventArgs e)
        {
            ThanhToan.fThanhToan thanhtoan = new ThanhToan.fThanhToan();
            thanhtoan.ShowDialog();
        }
     

        private void ptbQuanLiPhong_Click_1(object sender, EventArgs e)
        {
            QuanLiPhong.fQuanLiPhong roommanage = new QuanLiPhong.fQuanLiPhong();
            roommanage.ShowDialog();
        }

        private void ptbDoanhThu_Click_1(object sender, EventArgs e)
        {
            DoanhThu.fDoanhThu doanhthu = new DoanhThu.fDoanhThu();
            doanhthu.ShowDialog();
        }

        private void ptbTraCuuPhong_Click_1(object sender, EventArgs e)
        {
            TraCuuPhong.fTraCuuPhong tracuuphong = new TraCuuPhong.fTraCuuPhong();
            tracuuphong.ShowDialog();
        }

        private void ptbTraCuuKhachHang_Click(object sender, EventArgs e)
        {
            QuanLiKhachHang.fTraCuuKhachHang kh = new QuanLiKhachHang.fTraCuuKhachHang();
            kh.ShowDialog();
           
        }

        private void ptbQuanLiDichVu_Click_1(object sender, EventArgs e)
        {
            QuanLiDichVu.fQuanLiDichVu qldv = new QuanLiDichVu.fQuanLiDichVu();
            qldv.ShowDialog();
        }

        private void ptbQuyDinh_Click_1(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
        #region MouseHoverAndLeave
        private void ptbDatPhong_MouseHover_1(object sender, EventArgs e)
        {
            int x_Width = Resources.datphong.Width + ((Resources.datphong.Width * 50) / 100);
            int y_Height = Resources.datphong.Height + ((Resources.datphong.Height * 50) / 100);
            Bitmap bm = new Bitmap(x_Width, y_Height);
            Graphics g = Graphics.FromImage(bm);
            g.DrawImage(Resources.datphong, new Rectangle(Point.Empty, bm.Size));
            ptbDatPhong.Image = bm;
        }

        private void ptbDatPhong_MouseLeave(object sender, EventArgs e)
        {
            ptbDatPhong.Image = Resources.datphong;
        }

        private void ptbThanhToan_MouseHover(object sender, EventArgs e)
        {
            int x_Width = Resources.thanhtoan.Width + ((Resources.thanhtoan.Width * 20) / 100);
            int y_Height = Resources.thanhtoan.Height + ((Resources.thanhtoan.Height * 20) / 100);
            Bitmap bm = new Bitmap(x_Width, y_Height);
            Graphics g = Graphics.FromImage(bm);
            g.DrawImage(Resources.thanhtoan, new Rectangle(Point.Empty, bm.Size));
            ptbThanhToan.Image = bm;
        }

        private void ptbThanhToan_MouseLeave(object sender, EventArgs e)
        {
            ptbThanhToan.Image = Resources.thanhtoan;
        }

        private void ptbQuanLiPhong_MouseHover(object sender, EventArgs e)
        {
            int x_Width = Resources.quanliphong.Width + ((Resources.quanliphong.Width * 20) / 100);
            int y_Height = Resources.quanliphong.Height + ((Resources.quanliphong.Height * 20) / 100);
            Bitmap bm = new Bitmap(x_Width, y_Height);
            Graphics g = Graphics.FromImage(bm);
            g.DrawImage(Resources.quanliphong, new Rectangle(Point.Empty, bm.Size));
            ptbQuanLiPhong.Image = bm;
        }

        private void ptbQuanLiPhong_MouseLeave(object sender, EventArgs e)
        {
            ptbQuanLiPhong.Image = Resources.quanliphong;
        }

        private void ptbDoanhThu_MouseHover(object sender, EventArgs e)
        {
            int x_Width = Resources.doanhthu.Width + ((Resources.doanhthu.Width * 50) / 100);
            int y_Height = Resources.doanhthu.Height + ((Resources.doanhthu.Height * 50) / 100);
            Bitmap bm = new Bitmap(x_Width, y_Height);
            Graphics g = Graphics.FromImage(bm);
            g.DrawImage(Resources.doanhthu, new Rectangle(Point.Empty, bm.Size));
            ptbDoanhThu.Image = bm;
        }

        private void ptbDoanhThu_MouseLeave(object sender, EventArgs e)
        {
            ptbDoanhThu.Image = Resources.doanhthu;
        }

        private void ptbTraCuuPhong_MouseHover(object sender, EventArgs e)
        {
            int x_Width = Resources.tracuuphong.Width + ((Resources.tracuuphong.Width * 50) / 100);
            int y_Height = Resources.tracuuphong.Height + ((Resources.tracuuphong.Height * 50) / 100);
            Bitmap bm = new Bitmap(x_Width, y_Height);
            Graphics g = Graphics.FromImage(bm);
            g.DrawImage(Resources.tracuuphong, new Rectangle(Point.Empty, bm.Size));
            ptbTraCuuPhong.Image = bm;
        }

        private void ptbTraCuuPhong_MouseLeave(object sender, EventArgs e)
        {
            ptbTraCuuPhong.Image = Resources.tracuuphong;
        }

        private void ptbTraCuuKhachHang_MouseHover(object sender, EventArgs e)
        {
            int x_Width = Resources.tracuuKH.Width + ((Resources.tracuuKH.Width * 50) / 100);
            int y_Height = Resources.tracuuKH.Height + ((Resources.tracuuKH.Height * 50) / 100);
            Bitmap bm = new Bitmap(x_Width, y_Height);
            Graphics g = Graphics.FromImage(bm);
            g.DrawImage(Resources.tracuuKH, new Rectangle(Point.Empty, bm.Size));
            ptbTraCuuKhachHang.Image = bm;
        }

        private void ptbTraCuuKhachHang_MouseLeave(object sender, EventArgs e)
        {
            ptbTraCuuKhachHang.Image = Resources.tracuuKH;
        }

        private void ptbQuanLiDichVu_MouseHover(object sender, EventArgs e)
        {
            int x_Width = Resources.qldichvu.Width + ((Resources.qldichvu.Width * 50) / 100);
            int y_Height = Resources.qldichvu.Height + ((Resources.qldichvu.Height * 50) / 100);
            Bitmap bm = new Bitmap(x_Width, y_Height);
            Graphics g = Graphics.FromImage(bm);
            g.DrawImage(Resources.qldichvu, new Rectangle(Point.Empty, bm.Size));
            ptbQuanLiDichVu.Image = bm;
        }

        private void ptbQuanLiDichVu_MouseLeave(object sender, EventArgs e)
        {
            ptbQuanLiDichVu.Image = Resources.qldichvu;
        }

        private void ptbQuyDinh_MouseHover(object sender, EventArgs e)
        {
            int x_Width = Resources.quydinh.Width + ((Resources.quydinh.Width * 50) / 100);
            int y_Height = Resources.quydinh.Height + ((Resources.quydinh.Height * 50) / 100);
            Bitmap bm = new Bitmap(x_Width, y_Height);
            Graphics g = Graphics.FromImage(bm);
            g.DrawImage(Resources.quydinh, new Rectangle(Point.Empty, bm.Size));
            ptbQuyDinh.Image = bm;
        }

        private void ptbQuyDinh_MouseLeave(object sender, EventArgs e)
        {
            ptbQuyDinh.Image = Resources.quydinh;
        }
        #endregion
    }
}
