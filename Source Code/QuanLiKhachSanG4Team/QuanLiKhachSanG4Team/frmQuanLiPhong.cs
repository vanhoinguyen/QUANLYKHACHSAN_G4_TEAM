using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace QuanLiKhachSanG4Team
{
    public partial class frmQuanLiPhong : Form
    {
        public frmQuanLiPhong()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

       
        private void frmQuanLiPhong_Load(object sender, EventArgs e)
        {
           
            LoadDanhSachPhong();
            LoadDanhSachLoaiPhong();
        }
        public void LoadDanhSachPhong()
        {
            List<QLPhong_DTO> lstDichVu = QLPhong_BUS.LoadDanhSachPhong();
            dgvDanhSachPhong.DataSource = QLPhong_BUS.LoadDanhSachPhong();
        }
        public void LoadDanhSachLoaiPhong()
        {
            List<LoaiPhong_DTO> lstLoaiPhong = LoaiPhong_BUS.LoadDanhSachLoaiPhong();
            cmbLoaiPhong.DataSource = lstLoaiPhong;
            cmbLoaiPhong.DisplayMember = "TenLoaiPhong";//Giá trị hiển thị
            
            cmbLoaiPhong.ValueMember = "MaLoaiPhong";//giá trị cần lấy
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Kiem tra du lieu
            if(txtTenPhong.Text=="" || txtMaPhong.Text=="" )
            {
                MessageBox.Show("Vui lòng nhập vào dữ liệu!", "Thông báo");
                return;
            }
            //Khoi tao doi tuong QLPHONG
            QLPhong_DTO phongDTO = new QLPhong_DTO();
            phongDTO.MaPhong = int.Parse(txtMaPhong.Text);
            phongDTO.TenPhong = txtTenPhong.Text;
            phongDTO.DonGia = decimal.Parse(txtDonGia.Text);
            phongDTO.GhiChu = txtGhiChu.Text;
            

            //Goi lop PHONG BUS
            if(QLPhong_BUS.ThemPhong(phongDTO)==true)
            {
                MessageBox.Show("Thêm phòng thành công!", "Thông báo");
                LoadDanhSachPhong();
                return;
            }
            MessageBox.Show("Thêm phòng không thành công!", "Thông báo");

        }
    }
}
