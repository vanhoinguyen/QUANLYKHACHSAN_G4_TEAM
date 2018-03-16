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

        private void btnCategoryRoom_Click(object sender, EventArgs e)
        {
            DanhMucPhong.fDanhMucPhong caterogy = new DanhMucPhong.fDanhMucPhong();
            caterogy.Show();
           


        }

        private void btnExitMain_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void ManHinhChinh_FormClosing(object sender, FormClosingEventArgs e)
        { 
            if (MessageBox.Show("Bạn Có muốn thoát chương trình? ", "Thông báo", MessageBoxButtons.OKCancel)!= DialogResult.OK)
            {
                e.Cancel = true;
            }
                

        }

        private void btnListRoom_Click(object sender, EventArgs e)
        {
            DanhSachPhong.fDanhSachPhong listroom = new DanhSachPhong.fDanhSachPhong();
            listroom.Show();
        }

        private void btnBookRoom_Click(object sender, EventArgs e)
        {
            DatPhong.fDatPhong oder = new DatPhong.fDatPhong();
            oder.Show();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            TinhTien.fTinhTien payroom = new TinhTien.fTinhTien();
            payroom.Show();
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            DoanhThu.fDoanhThu revenue = new DoanhThu.fDoanhThu();
            revenue.Show();
        }

        private void btnManagerCustomer_Click(object sender, EventArgs e)
        {
            QuanLiKhachHang.fQuanLiKhachHang customer = new QuanLiKhachHang.fQuanLiKhachHang();
            customer.Show();
        }
    }
}
