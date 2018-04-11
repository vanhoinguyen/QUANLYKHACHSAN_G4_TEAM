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
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ptbBill_Click(object sender, EventArgs e)
        {
            ThanhToan.fThanhToan bill = new ThanhToan.fThanhToan();
            bill.ShowDialog();
        }

        private void ptbRoomManage_Click(object sender, EventArgs e)
        {
            QuanLiPhong.fQuanLiPhong roommanage = new QuanLiPhong.fQuanLiPhong();
            roommanage.ShowDialog();
        }

        private void ptbSearchRoom_Click(object sender, EventArgs e)
        {
            TraCuuPhong.fTraCuuPhong searchroom = new TraCuuPhong.fTraCuuPhong();
            searchroom.ShowDialog();
        }

        private void ptbCustomerManage_Click(object sender, EventArgs e)
        {
            QuanLiKhachHang.fQuanLiKhachHang customer = new QuanLiKhachHang.fQuanLiKhachHang();
            customer.ShowDialog();
        }

        private void ptbServiceManage_Click(object sender, EventArgs e)
        {
            QuanLiDichVu.fQuanLiDichVu service = new QuanLiDichVu.fQuanLiDichVu();
            service.ShowDialog();
        }

        private void ptbBookRoom_Click(object sender, EventArgs e)
        {
            DatPhong.fDatPhong oder = new DatPhong.fDatPhong();
            oder.ShowDialog();
        }

        private void ptbRevenue_Click(object sender, EventArgs e)
        {
            DoanhThu.fDoanhThu revenue = new DoanhThu.fDoanhThu();
            revenue.ShowDialog();
        }
        #endregion


        #region ImagesEvent
        private void ptbRoomManage_MouseHover(object sender, EventArgs e)
        {
           

           int x_Width = Resources.quanliphong.Width + ((Resources.quanliphong.Width* 20) / 100);
           int y_Height = Resources.quanliphong.Height + ((Resources.quanliphong.Height * 20) / 100);
            Bitmap bm = new Bitmap(x_Width, y_Height);
            Graphics g = Graphics.FromImage(bm);
            g.DrawImage(Resources.quanliphong, new Rectangle(Point.Empty, bm.Size));
            ptbRoomManage.Image = bm;
        }

        private void ptbRoomManage_MouseLeave(object sender, EventArgs e)
        {
            ptbRoomManage.Image = Resources.quanliphong;
        }

        private void ptbCustomerManage_MouseHover(object sender, EventArgs e)
        {
            int x_Width = Resources.qlkhachhang.Width + ((Resources.qlkhachhang.Width * 20) / 100);
            int y_Height = Resources.qlkhachhang.Height + ((Resources.qlkhachhang.Height * 20) / 100);
            Bitmap bm = new Bitmap(x_Width, y_Height);
            Graphics g = Graphics.FromImage(bm);
            g.DrawImage(Resources.qlkhachhang, new Rectangle(Point.Empty, bm.Size));
            ptbCustomerManage.Image = bm;
        }

        private void ptbCustomerManage_MouseLeave(object sender, EventArgs e)
        {
            ptbCustomerManage.Image = Resources.qlkhachhang;
        }

        private void ptbServiceManage_MouseHover(object sender, EventArgs e)
        {
            int x_Width = Resources.qldichvu.Width + ((Resources.qldichvu.Width * 20) / 100);
            int y_Height = Resources.qldichvu.Height + ((Resources.qldichvu.Height * 20) / 100);
            Bitmap bm = new Bitmap(x_Width, y_Height);
            Graphics g = Graphics.FromImage(bm);
            g.DrawImage(Resources.qldichvu, new Rectangle(Point.Empty, bm.Size));
            ptbServiceManage.Image = bm;
        }

        private void ptbServiceManage_MouseLeave(object sender, EventArgs e)
        {
            ptbServiceManage.Image = Resources.qldichvu;
        }

        private void ptbRegulations_MouseHover(object sender, EventArgs e)
        {
            int x_Width = Resources.quydinh.Width + ((Resources.quydinh.Width * 20) / 100);
            int y_Height = Resources.quydinh.Height + ((Resources.quydinh.Height * 20) / 100);
            Bitmap bm = new Bitmap(x_Width, y_Height);
            Graphics g = Graphics.FromImage(bm);
            g.DrawImage(Resources.quydinh, new Rectangle(Point.Empty, bm.Size));
            ptbRegulations.Image = bm;
        }

        private void ptbRegulations_MouseLeave(object sender, EventArgs e)
        {
            ptbRegulations.Image = Resources.quydinh;
        }

        private void ptbBookRoom_MouseHover(object sender, EventArgs e)
        {
            int x_Width = Resources.datphong.Width + ((Resources.datphong.Width * 20) / 100);
            int y_Height = Resources.datphong.Height + ((Resources.datphong.Height * 20) / 100);
            Bitmap bm = new Bitmap(x_Width, y_Height);
            Graphics g = Graphics.FromImage(bm);
            g.DrawImage(Resources.datphong, new Rectangle(Point.Empty, bm.Size));
            ptbBookRoom.Image = bm;
        }

        private void ptbBookRoom_MouseLeave(object sender, EventArgs e)
        {
            ptbBookRoom.Image = Resources.datphong;
        }

        private void ptbSearchRoom_MouseHover(object sender, EventArgs e)
        {
            int x_Width = Resources.tracuuphong.Width + ((Resources.tracuuphong.Width * 20) / 100);
            int y_Height = Resources.tracuuphong.Height + ((Resources.tracuuphong.Height * 20) / 100);
            Bitmap bm = new Bitmap(x_Width, y_Height);
            Graphics g = Graphics.FromImage(bm);
            g.DrawImage(Resources.tracuuphong, new Rectangle(Point.Empty, bm.Size));
            ptbSearchRoom.Image = bm;
        }

        private void ptbSearchRoom_MouseLeave(object sender, EventArgs e)
        {
            ptbSearchRoom.Image = Resources.tracuuphong;
        }

        private void ptbBill_MouseHover(object sender, EventArgs e)
        {
            int x_Width = Resources.thanhtoan.Width + ((Resources.thanhtoan.Width * 20) / 100);
            int y_Height = Resources.thanhtoan.Height + ((Resources.thanhtoan.Height * 20) / 100);
            Bitmap bm = new Bitmap(x_Width, y_Height);
            Graphics g = Graphics.FromImage(bm);
            g.DrawImage(Resources.thanhtoan, new Rectangle(Point.Empty, bm.Size));
            ptbBill.Image = bm;
        }

        private void ptbBill_MouseLeave(object sender, EventArgs e)
        {
            ptbBill.Image = Resources.thanhtoan;
        }

        private void ptbRevenue_MouseHover(object sender, EventArgs e)
        {
            int x_Width = Resources.doanhthu.Width + ((Resources.doanhthu.Width * 20) / 100);
            int y_Height = Resources.doanhthu.Height + ((Resources.doanhthu.Height * 20) / 100);
            Bitmap bm = new Bitmap(x_Width, y_Height);
            Graphics g = Graphics.FromImage(bm);
            g.DrawImage(Resources.doanhthu, new Rectangle(Point.Empty, bm.Size));
            ptbRevenue.Image = bm;

        }

        private void ptbRevenue_MouseLeave(object sender, EventArgs e)
        {
            ptbRevenue.Image = Resources.doanhthu;
        }
        #endregion
    }
}
