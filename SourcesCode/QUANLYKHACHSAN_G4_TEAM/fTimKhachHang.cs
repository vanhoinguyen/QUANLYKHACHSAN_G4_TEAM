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
using DTO;
using BUS;

namespace QUANLYKHACHSAN_G4_TEAM.TraCuuKhachHang
{
    public partial class fTimKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public fTimKhachHang()
        {
            InitializeComponent();
        }

        private void SuKienLoadForm()
        {
            txtTenKH.Text = "";
            txtDiaChi.Text = "";
            txtCMND.Text = "";
            List<KhachHangDTO> lst = KhachHangBUS.LayDSLoaiKhach();
            cmbLoaiKhach.Items.Clear();
            for (int i = 0; i < (lst.Count); i++)
            {
                cmbLoaiKhach.Items.Add(lst[i].LoaiKhach);
            }
            cmbPhong.DisplayMember = "MaPhong";
            cmbPhong.ValueMember = "MaPhong";
            cmbPhong.DataSource = PhongBUS.DanhSachPhongDangDuocThue();
            gcKhachHang.DataSource = KhachHangBUS.DanhSachKhachHang();
        }

        private void fTimKhachHang_Load(object sender, EventArgs e)
        {
            SuKienLoadForm();
        }

        private void gvKhachHang_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == gvKhachHang.Columns["LoaiKhach"])
            {
                var loaikhach = Convert.ToString(gvKhachHang.GetRowCellValue(e.RowHandle, gvKhachHang.Columns["LoaiKhach"]));
                if (loaikhach == "Nước ngoài")
                {
                    e.Appearance.BackColor = Color.FromArgb(0x00, 0xFF, 0x00);
                }
            }
        }

        private KhachHangDTO LayThongTinTimKiem()
        {
            KhachHangDTO thongtin = new KhachHangDTO();
            thongtin.TenKhachHang = txtTenKH.Text;
            thongtin.DiaChi = txtDiaChi.Text;
            thongtin.LoaiKhach = cmbLoaiKhach.Text;
            thongtin.CMND = txtCMND.Text;
            return thongtin;
        }

        private void TimKiemTheoYeuCau(int s)
        {
            KhachHangDTO thongtin = LayThongTinTimKiem();
            if (s == 1)
            {
                gcKhachHang.DataSource = KhachHangBUS.DSKHTheoTen(thongtin);
            }
            else if (s == 2)
            {
                gcKhachHang.DataSource = KhachHangBUS.DSKHTheoTenDiaChi(thongtin);
            }
            else if (s == 3)
            {
                gcKhachHang.DataSource = KhachHangBUS.DSKHTheoTenLoaiKhach(thongtin);
            }
            else if (s == 4)
            {
                gcKhachHang.DataSource = KhachHangBUS.DSKHTheoTenDiaChiLoaiKhach(thongtin);
            }
            else if (s == 5)
            {
                gcKhachHang.DataSource = KhachHangBUS.DSKHTheoLoaiKhach(thongtin);
            }
            else if (s == 6)
            {
                gcKhachHang.DataSource = KhachHangBUS.DSKHTheoLoaiKhachDiaChi(thongtin);
            }
            else if (s == 7)
            {
                gcKhachHang.DataSource = KhachHangBUS.DSKHTheoDiaChi(thongtin);
            }
            else if (s == 8)
            {
                gcKhachHang.DataSource = KhachHangBUS.DanhSachKhachHang();
            }
            else if (s == 9)
            {
                gcKhachHang.DataSource = KhachHangBUS.DSKHTheoCMND(thongtin);
            }
            else if (s == 10)
            {
                gcKhachHang.DataSource = KhachHangBUS.DSKHTheoTenDiaChiLoaiKhachCMND(thongtin);
            }
            else if (s == 11)
            {
                gcKhachHang.DataSource = KhachHangBUS.DSKHTheoTenDiaChiCMND(thongtin);
            }
            else if (s == 12)
            {
                gcKhachHang.DataSource = KhachHangBUS.DSKHTheoTenLoaiKhachCMND(thongtin);
            }
            else if (s == 13)
            {
                gcKhachHang.DataSource = KhachHangBUS.DSKHLoaiKhachCMND(thongtin);
            }
            else if (s == 14)
            {
                gcKhachHang.DataSource = KhachHangBUS.DSKHDiaChiLoaiKhachCMND(thongtin);
            }
            else if (s == 15)
            {
                gcKhachHang.DataSource = KhachHangBUS.DSKHDiaChiCMND(thongtin);
            }
            else if (s == 16)
            {
                gcKhachHang.DataSource = KhachHangBUS.DSKHTheoTenCMND(thongtin);
            }
        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "" && cmbLoaiKhach.Text == "" && txtCMND.Text == "")
            {
                TimKiemTheoYeuCau(1);
            }
            else if (txtDiaChi.Text != "" && cmbLoaiKhach.Text == "" && txtCMND.Text == "")
            {
                TimKiemTheoYeuCau(2);
            }
            else if (txtDiaChi.Text == "" && cmbLoaiKhach.Text != "" && txtCMND.Text == "")
            {
                TimKiemTheoYeuCau(3);
            }
            else if (txtDiaChi.Text == "" && cmbLoaiKhach.Text == "" && txtCMND.Text != "")
            {
                TimKiemTheoYeuCau(16);
            }
            else if (txtDiaChi.Text != "" && cmbLoaiKhach.Text == "" && txtCMND.Text != "")
            {
                TimKiemTheoYeuCau(11);
            }
            else if (txtDiaChi.Text == "" && cmbLoaiKhach.Text != "" && txtCMND.Text != "")
            {
                TimKiemTheoYeuCau(12);
            }
            else if (txtDiaChi.Text != "" && cmbLoaiKhach.Text != "" && txtCMND.Text == "")
            {
                TimKiemTheoYeuCau(4);
            }
            else if (txtDiaChi.Text != "" && cmbLoaiKhach.Text != "" && txtCMND.Text != "")
            {
                TimKiemTheoYeuCau(4);
            }
            else if (txtDiaChi.Text == "" && cmbLoaiKhach.Text == "" && txtTenKH.Text == "" && txtCMND.Text == "")
            {
                TimKiemTheoYeuCau(8);
            }
        }

        private void cmbLoaiKhach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "" && txtTenKH.Text == "" && txtCMND.Text == "")
            {
                TimKiemTheoYeuCau(5);
            }
            else if (txtDiaChi.Text != "" && txtTenKH.Text == "" && txtCMND.Text == "")
            {
                TimKiemTheoYeuCau(6);
            }
            else if (txtDiaChi.Text == "" && txtTenKH.Text != "" && txtCMND.Text == "")
            {
                TimKiemTheoYeuCau(3);
            }
            else if (txtDiaChi.Text == "" && txtTenKH.Text == "" && txtCMND.Text != "")
            {
                TimKiemTheoYeuCau(13);
            }
            else if (txtDiaChi.Text != "" && txtTenKH.Text != "" && txtCMND.Text == "")
            {
                TimKiemTheoYeuCau(4);
            }
            else if (txtDiaChi.Text != "" && txtTenKH.Text == "" && txtCMND.Text != "")
            {
                TimKiemTheoYeuCau(14);
            }
            else if (txtDiaChi.Text == "" && txtTenKH.Text != "" && txtCMND.Text != "")
            {
                TimKiemTheoYeuCau(12);
            }
            else if (txtDiaChi.Text != "" && txtTenKH.Text != "" && txtCMND.Text != "")
            {
                TimKiemTheoYeuCau(10);
            }
            else if (txtDiaChi.Text == "" && cmbLoaiKhach.Text == "" && txtTenKH.Text == "" && txtCMND.Text == "")
            {
                TimKiemTheoYeuCau(8);
            }
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            if (cmbLoaiKhach.Text == "" && txtTenKH.Text == "" && txtCMND.Text == "")
            {
                TimKiemTheoYeuCau(7);
            }
            else if (cmbLoaiKhach.Text != "" && txtTenKH.Text == "" && txtCMND.Text == "")
            {
                TimKiemTheoYeuCau(6);
            }
            else if (cmbLoaiKhach.Text == "" && txtTenKH.Text != "" && txtCMND.Text == "")
            {
                TimKiemTheoYeuCau(2);
            }
            else if (cmbLoaiKhach.Text == "" && txtTenKH.Text == "" && txtCMND.Text != "")
            {
                TimKiemTheoYeuCau(15);
            }
            else if (cmbLoaiKhach.Text != "" && txtTenKH.Text == "" && txtCMND.Text != "")
            {
                TimKiemTheoYeuCau(14);
            }
            else if (cmbLoaiKhach.Text == "" && txtTenKH.Text != "" && txtCMND.Text != "")
            {
                TimKiemTheoYeuCau(11);
            }
            else if (cmbLoaiKhach.Text != "" && txtTenKH.Text != "" && txtCMND.Text == "")
            {
                TimKiemTheoYeuCau(4);
            }
            else if (cmbLoaiKhach.Text != "" && txtTenKH.Text != "" && txtCMND.Text != "")
            {
                TimKiemTheoYeuCau(10);
            }
            else if (txtDiaChi.Text == "" && cmbLoaiKhach.Text == "" && txtTenKH.Text == "" && txtCMND.Text == "")
            {
                TimKiemTheoYeuCau(8);
            }
        }

        private void txtCMND_TextChanged(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "" && cmbLoaiKhach.Text == "" && txtTenKH.Text == "")
            {
                TimKiemTheoYeuCau(8);
            }
            else if (txtDiaChi.Text != "" && cmbLoaiKhach.Text == "" && txtTenKH.Text == "")
            {
                TimKiemTheoYeuCau(15);
            }
            else if (txtDiaChi.Text == "" && cmbLoaiKhach.Text != "" && txtTenKH.Text == "")
            {
                TimKiemTheoYeuCau(13);
            }
            else if (txtDiaChi.Text == "" && cmbLoaiKhach.Text == "" && txtTenKH.Text != "")
            {
                TimKiemTheoYeuCau(16);
            }
            else if (txtDiaChi.Text != "" && cmbLoaiKhach.Text != "" && txtTenKH.Text == "")
            {
                TimKiemTheoYeuCau(14);
            }
            else if (txtDiaChi.Text == "" && cmbLoaiKhach.Text != "" && txtTenKH.Text != "")
            {
                TimKiemTheoYeuCau(12);
            }
            else if (txtDiaChi.Text != "" && cmbLoaiKhach.Text == "" && txtTenKH.Text != "")
            {
                TimKiemTheoYeuCau(11);
            }
            else if (cmbLoaiKhach.Text != "" && txtTenKH.Text != "" && txtDiaChi.Text != "")
            {
                TimKiemTheoYeuCau(10);
            }
            else if (txtDiaChi.Text == "" && cmbLoaiKhach.Text == "" && txtTenKH.Text == "" && txtCMND.Text == "")
            {
                TimKiemTheoYeuCau(8);
            }

        }

        private void cmbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            PhongDTO thongtin = new PhongDTO();
            thongtin.MaPhong = int.Parse(cmbPhong.Text);

            gcKhachHang.DataSource = KhachHangBUS.DSKHTheoPhong(thongtin);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            SuKienLoadForm();
        }

        private void gvKhachHang_DoubleClick(object sender, EventArgs e)
        {
            int makh = int.Parse(gvKhachHang.GetRowCellValue(gvKhachHang.FocusedRowHandle, gvKhachHang.Columns["MaKH"]).ToString());
            string tenkh = gvKhachHang.GetRowCellValue(gvKhachHang.FocusedRowHandle, gvKhachHang.Columns["TenKhachHang"]).ToString();
            List<PhieuThuePhongDTO> lst = new List<PhieuThuePhongDTO>();
            lst = PhieuThueBUS.LayPhongTuongUng(makh);
            int? maphong = lst[0].MaPhong;
            MessageBox.Show("Khách hàng '" + tenkh + "' đang thuê phòng số " + maphong + "", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtTenKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}