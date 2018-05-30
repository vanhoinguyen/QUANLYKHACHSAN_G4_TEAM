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


 
      

        private void ptbThanhToan_Click(object sender, EventArgs e)
        {
            ThanhToan.fThanhToan thanhtoan = new ThanhToan.fThanhToan();
            this.Hide();
            thanhtoan.ShowDialog();
            this.Show();
            
        }

        private void ptbQuanLiPhong_Click(object sender, EventArgs e)
        {
            QuanLiPhong.fQuanLiPhong roommanage = new QuanLiPhong.fQuanLiPhong();
            this.Hide();
            roommanage.ShowDialog();
            this.Show();
        }

        private void ptbTraCuuPhong_Click(object sender, EventArgs e)
        {
            TraCuuPhong.fTraCuuPhong tracuuphong = new TraCuuPhong.fTraCuuPhong();
            this.Hide();
            tracuuphong.ShowDialog();
            this.Show();
        }

        private void ptbQuanLiKhachHang_Click(object sender, EventArgs e)
        {
            TraCuuKhachHang.fTimKhachHang kh = new TraCuuKhachHang.fTimKhachHang();
            this.Hide();
            kh.ShowDialog();
            this.Show();
        }

        private void ptbQuanLiDichVu_Click(object sender, EventArgs e)
        {
            QuanLiDichVu.fQuanLiDichVu qldv = new QuanLiDichVu.fQuanLiDichVu();
            this.Hide();
            qldv.ShowDialog();
            this.Show();
        }

        private void ptbDatPhong_Click(object sender, EventArgs e)
        {
            DatPhong.fPhongKS phong = new DatPhong.fPhongKS();
            this.Hide();
            phong.ShowDialog();
            this.Show();
        }

        private void ptbDoanhThu_Click(object sender, EventArgs e)
        {
            DoanhThu.fQLDoanhThu doanhthu = new DoanhThu.fQLDoanhThu();
            this.Hide();
            doanhthu.ShowDialog();
            this.Show();
        }


   

        private void ptbQuyDinh_Click(object sender, EventArgs e)
        {
            
            fThayDoiQuyDinhKS qd = new fThayDoiQuyDinhKS();
            qd.ShowDialog();
        }

        private void btnTroGiup_Click(object sender, EventArgs e)
        {
            fTroGiup trogiup = new fTroGiup();
            trogiup.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThuNho_Click(object sender, EventArgs e)
        {
             this.WindowState = FormWindowState.Minimized;
        }

      

        #region MoveForm
        Boolean flag;
        int x, y;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            x = e.X;
            y = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

     
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag == true)
            {
                this.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
            }
        }
        #endregion

    }
}
