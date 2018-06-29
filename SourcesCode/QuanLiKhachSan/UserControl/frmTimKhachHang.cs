using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DTO;
using BUS;
namespace QuanLiKhachSan.UserControl
{
    public partial class frmTimKhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        public frmTimKhachHang()
        {
            InitializeComponent();
        }
        private void SuKienLoadForm()
        {
            txtTenKhachHang.Text = "";
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
            gcDanhSachKhachHang.DataSource = KhachHangBUS.DanhSachKhachHang();
        }
        private void frmTimKhachHang_Load(object sender, EventArgs e)
        {
            SuKienLoadForm();
        }

        private KhachHangDTO LayThongTinTimKiem()
        {
            KhachHangDTO thongtin = new KhachHangDTO();
            thongtin.TenKhachHang = txtTenKhachHang.Text;
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
                gcDanhSachKhachHang.DataSource = KhachHangBUS.DSKHTheoTen(thongtin);
            }
            else if (s == 2)
            {
                gcDanhSachKhachHang.DataSource = KhachHangBUS.DSKHTheoTenDiaChi(thongtin);
            }
            else if (s == 3)
            {
                gcDanhSachKhachHang.DataSource = KhachHangBUS.DSKHTheoTenLoaiKhach(thongtin);
            }
            else if (s == 4)
            {
                gcDanhSachKhachHang.DataSource = KhachHangBUS.DSKHTheoTenDiaChiLoaiKhach(thongtin);
            }
            else if (s == 5)
            {
                gcDanhSachKhachHang.DataSource = KhachHangBUS.DSKHTheoLoaiKhach(thongtin);
            }
            else if (s == 6)
            {
                gcDanhSachKhachHang.DataSource = KhachHangBUS.DSKHTheoLoaiKhachDiaChi(thongtin);
            }
            else if (s == 7)
            {
                gcDanhSachKhachHang.DataSource = KhachHangBUS.DSKHTheoDiaChi(thongtin);
            }
            else if (s == 8)
            {
                gcDanhSachKhachHang.DataSource = KhachHangBUS.DanhSachKhachHang();
            }
            else if (s == 9)
            {
                gcDanhSachKhachHang.DataSource = KhachHangBUS.DSKHTheoCMND(thongtin);
            }
            else if (s == 10)
            {
                gcDanhSachKhachHang.DataSource = KhachHangBUS.DSKHTheoTenDiaChiLoaiKhachCMND(thongtin);
            }
            else if (s == 11)
            {
                gcDanhSachKhachHang.DataSource = KhachHangBUS.DSKHTheoTenDiaChiCMND(thongtin);
            }
            else if (s == 12)
            {
                gcDanhSachKhachHang.DataSource = KhachHangBUS.DSKHTheoTenLoaiKhachCMND(thongtin);
            }
            else if (s == 13)
            {
                gcDanhSachKhachHang.DataSource = KhachHangBUS.DSKHLoaiKhachCMND(thongtin);
            }
            else if (s == 14)
            {
                gcDanhSachKhachHang.DataSource = KhachHangBUS.DSKHDiaChiLoaiKhachCMND(thongtin);
            }
            else if (s == 15)
            {
                gcDanhSachKhachHang.DataSource = KhachHangBUS.DSKHDiaChiCMND(thongtin);
            }
            else if (s == 16)
            {
                gcDanhSachKhachHang.DataSource = KhachHangBUS.DSKHTheoTenCMND(thongtin);
            }
        }

        private void txtTenKhachHang_TextChanged(object sender, EventArgs e)
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
            else if (txtDiaChi.Text == "" && cmbLoaiKhach.Text == "" && txtTenKhachHang.Text == "" && txtCMND.Text == "")
            {
                TimKiemTheoYeuCau(8);
            }
        }

        private void cmbLoaiKhach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "" && txtTenKhachHang.Text == "" && txtCMND.Text == "")
            {
                TimKiemTheoYeuCau(5);
            }
            else if (txtDiaChi.Text != "" && txtTenKhachHang.Text == "" && txtCMND.Text == "")
            {
                TimKiemTheoYeuCau(6);
            }
            else if (txtDiaChi.Text == "" && txtTenKhachHang.Text != "" && txtCMND.Text == "")
            {
                TimKiemTheoYeuCau(3);
            }
            else if (txtDiaChi.Text == "" && txtTenKhachHang.Text == "" && txtCMND.Text != "")
            {
                TimKiemTheoYeuCau(13);
            }
            else if (txtDiaChi.Text != "" && txtTenKhachHang.Text != "" && txtCMND.Text == "")
            {
                TimKiemTheoYeuCau(4);
            }
            else if (txtDiaChi.Text != "" && txtTenKhachHang.Text == "" && txtCMND.Text != "")
            {
                TimKiemTheoYeuCau(14);
            }
            else if (txtDiaChi.Text == "" && txtTenKhachHang.Text != "" && txtCMND.Text != "")
            {
                TimKiemTheoYeuCau(12);
            }
            else if (txtDiaChi.Text != "" && txtTenKhachHang.Text != "" && txtCMND.Text != "")
            {
                TimKiemTheoYeuCau(10);
            }
            else if (txtDiaChi.Text == "" && cmbLoaiKhach.Text == "" && txtTenKhachHang.Text == "" && txtCMND.Text == "")
            {
                TimKiemTheoYeuCau(8);
            }
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            if (cmbLoaiKhach.Text == "" && txtTenKhachHang.Text == "" && txtCMND.Text == "")
            {
                TimKiemTheoYeuCau(7);
            }
            else if (cmbLoaiKhach.Text != "" && txtTenKhachHang.Text == "" && txtCMND.Text == "")
            {
                TimKiemTheoYeuCau(6);
            }
            else if (cmbLoaiKhach.Text == "" && txtTenKhachHang.Text != "" && txtCMND.Text == "")
            {
                TimKiemTheoYeuCau(2);
            }
            else if (cmbLoaiKhach.Text == "" && txtTenKhachHang.Text == "" && txtCMND.Text != "")
            {
                TimKiemTheoYeuCau(15);
            }
            else if (cmbLoaiKhach.Text != "" && txtTenKhachHang.Text == "" && txtCMND.Text != "")
            {
                TimKiemTheoYeuCau(14);
            }
            else if (cmbLoaiKhach.Text == "" && txtTenKhachHang.Text != "" && txtCMND.Text != "")
            {
                TimKiemTheoYeuCau(11);
            }
            else if (cmbLoaiKhach.Text != "" && txtTenKhachHang.Text != "" && txtCMND.Text == "")
            {
                TimKiemTheoYeuCau(4);
            }
            else if (cmbLoaiKhach.Text != "" && txtTenKhachHang.Text != "" && txtCMND.Text != "")
            {
                TimKiemTheoYeuCau(10);
            }
            else if (txtDiaChi.Text == "" && cmbLoaiKhach.Text == "" && txtTenKhachHang.Text == "" && txtCMND.Text == "")
            {
                TimKiemTheoYeuCau(8);
            }
        }

        private void txtCMND_TextChanged(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "" && cmbLoaiKhach.Text == "" && txtTenKhachHang.Text == "")
            {
                TimKiemTheoYeuCau(9);
            }
            else if (txtDiaChi.Text != "" && cmbLoaiKhach.Text == "" && txtTenKhachHang.Text == "")
            {
                TimKiemTheoYeuCau(15);
            }
            else if (txtDiaChi.Text == "" && cmbLoaiKhach.Text != "" && txtTenKhachHang.Text == "")
            {
                TimKiemTheoYeuCau(13);
            }
            else if (txtDiaChi.Text == "" && cmbLoaiKhach.Text == "" && txtTenKhachHang.Text != "")
            {
                TimKiemTheoYeuCau(16);
            }
            else if (txtDiaChi.Text != "" && cmbLoaiKhach.Text != "" && txtTenKhachHang.Text == "")
            {
                TimKiemTheoYeuCau(14);
            }
            else if (txtDiaChi.Text == "" && cmbLoaiKhach.Text != "" && txtTenKhachHang.Text != "")
            {
                TimKiemTheoYeuCau(12);
            }
            else if (txtDiaChi.Text != "" && cmbLoaiKhach.Text == "" && txtTenKhachHang.Text != "")
            {
                TimKiemTheoYeuCau(11);
            }
            else if (cmbLoaiKhach.Text != "" && txtTenKhachHang.Text != "" && txtDiaChi.Text != "")
            {
                TimKiemTheoYeuCau(10);
            }
            else if (txtDiaChi.Text == "" && cmbLoaiKhach.Text == "" && txtTenKhachHang.Text == "" && txtCMND.Text == "")
            {
                TimKiemTheoYeuCau(8);
            }
        }

        private void cmbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            PhongDTO thongtin = new PhongDTO();
            thongtin.MaPhong = int.Parse(cmbPhong.Text);

            gcDanhSachKhachHang.DataSource = KhachHangBUS.DSKHTheoPhong(thongtin);
        }

        private void gcDanhSachKhachHang_DoubleClick(object sender, EventArgs e)
        {
            int makh = int.Parse(gvKhachHang.GetRowCellValue(gvKhachHang.FocusedRowHandle, gvKhachHang.Columns["MaKH"]).ToString());
            string tenkh = gvKhachHang.GetRowCellValue(gvKhachHang.FocusedRowHandle, gvKhachHang.Columns["TenKhachHang"]).ToString();
            List<PhieuThuePhongDTO> lst = new List<PhieuThuePhongDTO>();
            lst = PhieuThueBUS.LayPhongTuongUng(makh);
            int? maphong = lst[0].MaPhong;
            MessageBox.Show("Khách hàng '" + tenkh + "' đang thuê phòng số " + maphong + "", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtTenKhachHang_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
