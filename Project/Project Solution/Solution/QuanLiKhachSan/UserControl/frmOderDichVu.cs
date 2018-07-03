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
using System.Text.RegularExpressions;

namespace QuanLiKhachSan.UserControl
{
    public partial class frmOderDichVu : DevExpress.XtraEditors.XtraForm
    {
        public frmOderDichVu()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmOderDichVu_Load(object sender, EventArgs e)
        {
            cmbMaPhong.DataSource = OderDichVuBUS.LoadDanhSachMaPhong();
            cmbMaPhong.DisplayMember = "MaPhong";
            cmbDichVu.DataSource = OderDichVuBUS.LoadDanhSachDichVu();
            cmbDichVu.DisplayMember = "TenDichVu";
        }

        private void btnOder_Click(object sender, EventArgs e)
        {
            List<OderDichVuDTO> lst = new List<OderDichVuDTO>();
            string tendichvu = cmbDichVu.Text;
            lst = OderDichVuBUS.LayMaDichVuDangKi(tendichvu);
            OderDichVuDTO infor = new OderDichVuDTO();
            infor.MaPhong = Convert.ToInt32(cmbMaPhong.Text);
            infor.SoLuong = Convert.ToInt32(txtSoLuong.Text);
            infor.MaDichVu = lst[0].MaDichVu;
            if (OderDichVuBUS.DangKiDichVu(infor) == true)
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

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            Regex regex;
            regex = new Regex(@"[^A-Za-z]{1,3}$");
            Control ctrl = (Control)sender;
            if (regex.IsMatch(ctrl.Text))
            {
                errorProvider1.SetError(ctrl, "");
            }
            else
            {
                errorProvider1.SetError(ctrl,
                  "Không được nhập chữ");
            }
        }
    }
}