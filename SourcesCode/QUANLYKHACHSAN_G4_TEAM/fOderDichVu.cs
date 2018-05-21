using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;
using DTO;
namespace QUANLYKHACHSAN_G4_TEAM
{
    public partial class fOderDichVu : DevExpress.XtraEditors.XtraForm
    {
        public fOderDichVu()
        {
            InitializeComponent();
        }

        private void fOderDichVu_Load(object sender, EventArgs e)
        {
            cmbMaPhong.DataSource = OderDichVuBUS.LoadDanhSachMaPhong();
            cmbMaPhong.DisplayMember = "MaPhong";
            cmbTenDichVu.DataSource = OderDichVuBUS.LoadDanhSachDichVu();
            cmbTenDichVu.DisplayMember = "TenDichVu";
        }

        private void btnOder_Click(object sender, EventArgs e)
        {
            List<OderDichVuDTO> lst = new List<OderDichVuDTO>();
            string tendichvu = cmbTenDichVu.Text;
            lst = OderDichVuBUS.LayMaDichVuDangKi(tendichvu);
            OderDichVuDTO infor = new OderDichVuDTO();
            infor.MaPhong = Convert.ToInt32(cmbMaPhong.Text);
            infor.SoLuong = Convert.ToInt32(txtSoLuong.Text);
            infor.MaDichVu = lst[0].MaDichVu;
            if(OderDichVuBUS.DangKiDichVu(infor) == true)
            {
                MessageBox.Show("Đăng kí dịch vụ thành công", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi hệ thống hoặc chưa nhập số lượng", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}