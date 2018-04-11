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
    }
}
