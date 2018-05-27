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
namespace QUANLYKHACHSAN_G4_TEAM.ThanhToan
{
    public partial class fThanhToan : DevExpress.XtraEditors.XtraForm
    {
        public fThanhToan()
        {
            InitializeComponent();
            cmbMaPhong.DisplayMember = "MaPhong";
            cmbMaPhong.ValueMember = "MaPhong";
        }
        int numRow = 0;

        public void ThietLapButton(bool value)
        {
            btnThanhToan.Enabled = value;
            btnXoa.Enabled = value;
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            Close();
        }



        private void fThanhToan_Load_1(object sender, EventArgs e)
        {
            ThietLapButton(false);
            cmbMaPhong.DataSource = HoaDonBUS.LayMaPhongDaThue();
            if (cmbMaPhong.SelectedValue == null)
                btnThem.Enabled = false;
        }

        private void cmbMaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            HoaDonDTO infor = new HoaDonDTO();
            infor.MaPhong = int.Parse(cmbMaPhong.Text);
            List<HoaDonDTO> lst = new List<HoaDonDTO>();
            lst = HoaDonBUS.LayThongTinPhongThue(infor);
            txtDonGiaPhong.Text = lst[0].DonGia.ToString();
            txtTenKhachHang.Text = lst[0].TenKhachHang.ToString();
            txtDiaChi.Text = lst[0].DiaChi.ToString();
            int maphieuthue = lst[0].MaPhieuThue.Value;
            infor.NgayBatDauThue = Convert.ToDateTime(lst[0].NgayBatDauThue.ToString());

            HoaDonBUS.TinhSoNgayDaThue(infor);
            lst = HoaDonBUS.LaySoNgayDaThue();
            txtSoNgayThue.Text = lst[0].SoNgayDaThue.ToString();
            if(Convert.ToInt32(txtSoNgayThue.Text) < 0)
            {
                btnThanhToan.Enabled = false;
                MessageBox.Show("Chưa thể thanh toán khách hàng này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (txtSoNgayThue.Text == "0")
            {
                txtSoNgayThue.Text = "1";
            }
            int num = HoaDonBUS.LaySoLuongKhach(maphieuthue);

            lst = HoaDonBUS.LayKhachNuocNgoai();
            int kpt = lst[0].KhachPTThu.Value;
            int kng = lst[0].SLKhachNG.Value;
            if (num >= kpt)
            {
                lst = HoaDonBUS.TinhPhuThu(num);
                txtPhuThu.Text = lst[0].PhuThu.ToString();
            }
            else
            {
                txtPhuThu.Text = "0";
            }
            int nc = HoaDonBUS.DemSoLuongKhachNuocNgoai(infor);
            if (nc >= kng)
            {
                lst = HoaDonBUS.TinhHeSo();
                txtHeSo.Text = lst[0].HeSo.ToString();
            }
            else
            {
                txtHeSo.Text = "0";
            }
            decimal phidichvu = 0;
            int numdv = OderDichVuBUS.LaySoLuongDichVuDK(infor.MaPhong);
            if(numdv == 0)
            {
                txtPhiDichVu.Text = "0";
            }
            else
            {
                
                for (int i = 0; i< numdv; i++)
                {
                    List<OderDichVuDTO> lst2 = new List<OderDichVuDTO>();
                    OderDichVuDTO infor2 = new OderDichVuDTO();
                    lst2 = OderDichVuBUS.DanhSachDichVuDK(infor.MaPhong);
                    infor2.MaDichVu = lst2[i].MaDichVu;
                    infor2.SoLuong = lst2[i].SoLuong;
                    List<DichVuDTO> lst3 = new List<DichVuDTO>();
                    lst3 = DichVuBUS.LayDonGia(infor2.MaDichVu);
                    DichVuDTO dongiadv = new DichVuDTO();
                    dongiadv.DonGia = lst3[0].DonGia;
                    decimal tiendv = dongiadv.DonGia;
                    phidichvu += infor2.SoLuong * tiendv;
                }
                txtPhiDichVu.Text = phidichvu.ToString();
            }
             
            txtPhiDichVu.Text = phidichvu.ToString();
            bool flag = true;
            for (int i = 0; i< dgvHoaDon.RowCount; i++)
            {
                if (dgvHoaDon.Rows[i].Cells["colMaPhong"].Value.ToString() != null)
                {
                    if (dgvHoaDon.Rows[i].Cells["colMaPhong"].Value.ToString() == cmbMaPhong.Text)
                    {
                        btnThem.Enabled = false;
                        flag = false;
                        break;
                    }
                }
            }

            if (flag == true)
            {
                btnThem.Enabled = true;
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            
            dgvHoaDon.Rows.Add();
            dgvHoaDon.Rows[numRow].Cells["colSTT"].Value = numRow + 1;
            dgvHoaDon.Rows[numRow].Cells["colMaPhong"].Value = cmbMaPhong.Text;
            dgvHoaDon.Rows[numRow].Cells["colSoNgayThue"].Value = txtSoNgayThue.Text;
            dgvHoaDon.Rows[numRow].Cells["colDonGia"].Value = txtDonGiaPhong.Text;
            dgvHoaDon.Rows[numRow].Cells["colPhuThu"].Value = txtPhuThu.Text;
            dgvHoaDon.Rows[numRow].Cells["colHeSo"].Value = txtHeSo.Text;

            btnThem.Enabled = false;
            decimal thanhtien = HoaDonBUS.ThanhTien(int.Parse(txtSoNgayThue.Text), Convert.ToDecimal(txtDonGiaPhong.Text), 
                Convert.ToDecimal(txtPhuThu.Text), Convert.ToDecimal(txtHeSo.Text),Convert.ToDecimal(txtPhiDichVu.Text));
            /*decimal thanhtien = HoaDonBUS.ThanhTien(int.Parse(txtSoNgayThue.Text), Convert.ToDecimal(txtDonGiaPhong.Text),
               Convert.ToDecimal(txtPhuThu.Text), Convert.ToDecimal(txtHeSo.Text));*/
            dgvHoaDon.Rows[numRow].Cells["colThanhTien"].Value = thanhtien.ToString();
            numRow++;

            txtTongTien.Text = (Convert.ToDecimal(txtTongTien.Text) + thanhtien).ToString();
            ThietLapButton(true);
            if (txtTenKhachHang.ToString() == "")
            {
                btnThanhToan.Enabled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string kt = "false";
            decimal thanhtien = 0;
            for (int i = 0; i < dgvHoaDon.Rows.Count; i++)
            {
                try
                {
                    kt = dgvHoaDon.Rows[i].Cells["colXoa"].Value.ToString();
                    thanhtien = Convert.ToDecimal(dgvHoaDon.Rows[i].Cells["colThanhTien"].Value.ToString());
                }
                catch { }
                if (kt == "True")
                {
                    txtTongTien.Text = (Convert.ToDecimal(txtTongTien.Text) - thanhtien).ToString();
                    if (!(Convert.ToDecimal(txtTongTien.Text) > 0))
                    {
                        txtTongTien.Text = "0";
                    }
                    dgvHoaDon.Rows.RemoveAt(i);
                    kt = "false";
                    numRow--;
                    i = -1;
                }
            }

            if (dgvHoaDon.RowCount == 0)
            {
                ThietLapButton(false);
                btnThem.Enabled = true;
            }
        }

        private void txtTenKhachHang_TextChanged(object sender, EventArgs e)
        {
            if (txtTenKhachHang.Text != "")
            {
                if (dgvHoaDon.Rows.Count > 0)
                {
                    btnThanhToan.Enabled = true;
                }
            }
        }
        private HoaDonDTO ThongTinHoaDonThanhToan(int i)
        {
            HoaDonDTO infor = new HoaDonDTO();
            int maphong = int.Parse(dgvHoaDon.Rows[i].Cells["colMaPhong"].Value.ToString());
            //tai sao la null
            //int maphong = int.Parse(cmbMaPhong.SelectedIndex.ToString());

            infor.MaPhong = maphong;
            List<HoaDonDTO> lst = new List<HoaDonDTO>();
            lst = HoaDonBUS.LayMaPhieuThue(maphong);
            infor.MaPhieuThue = lst[0].MaPhieuThue.Value;
            infor.SoNgayDaThue = int.Parse(dgvHoaDon.Rows[i].Cells["colSoNgayThue"].Value.ToString());
            infor.DonGia = Convert.ToDecimal(dgvHoaDon.Rows[i].Cells["colDonGia"].Value.ToString());
            infor.ThanhTien = Convert.ToDecimal(dgvHoaDon.Rows[i].Cells["colThanhTien"].Value.ToString());
            infor.NgayThanhToan = Convert.ToDateTime(dateTimePicker1.Text);
            return infor;
        }

        private HoaDonDTO LayThongTinKhachHangThanhToan()
        {
            HoaDonDTO infor = new HoaDonDTO();
            infor.MaHoaDon = HoaDonBUS.LayMaHDCuoiCung();
            infor.MaHoaDon = infor.MaHoaDon + 1;
            infor.TenKhachHang = txtTenKhachHang.Text;
            infor.TongTien = Convert.ToDecimal(txtTongTien.Text);
            return infor;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            bool success = true;
            HoaDonDTO infor = LayThongTinKhachHangThanhToan();
            if (HoaDonBUS.LapHoaDon(infor))
            {
                for (int i = 0; i < dgvHoaDon.RowCount  ; i++)
                {
                    HoaDonDTO inforHD = ThongTinHoaDonThanhToan(i);
                    if (!(HoaDonBUS.LapChiTietHoaDon(infor, inforHD)))
                    {
                        success = false;
                        MessageBox.Show("Không lập được hóa đơn chi tiết thứ " + i + "", "Lỗi", MessageBoxButtons.OK,
                            MessageBoxIcon.Stop);
                    }
                    List<KhachHangDTO> lstkh = new List<KhachHangDTO>();
                    int? maphieuthue = inforHD.MaPhieuThue;
                    lstkh = KhachHangBUS.LayMaKhachHangCanXoa(maphieuthue);
                    if (!(HoaDonBUS.XoaChiTietPhieuThue(inforHD)))
                    {
                        success = false;
                        MessageBox.Show("Không xóa được chi tiết phiếu thuê ", "Lỗi", MessageBoxButtons.OK,
                            MessageBoxIcon.Stop);
                    }
                    int dem = lstkh.Count();
                    for (int j = 0; j < dem; j++)
                    {
                        KhachHangDTO id = new KhachHangDTO();
                        id.MaKH = lstkh[j].MaKH;
                        if (!(KhachHangBUS.XoaKhachHang(id)))
                        {
                            success = false;
                            MessageBox.Show("Không xóa được khách hàng ", "Lỗi", MessageBoxButtons.OK,
                                MessageBoxIcon.Stop);
                        }
                    }
                    if (!(HoaDonBUS.XoaPhieuThue(inforHD)))
                    {
                        success = false;
                        MessageBox.Show("Không xóa được phiếu thuê ", "Lỗi", MessageBoxButtons.OK,
                            MessageBoxIcon.Stop);
                    }
                    if (!(PhongBUS.ThietLapTrangThaiPhongBanDau(inforHD)))
                    {
                        success = false;
                        MessageBox.Show("Không cập nhập được tình trạng phòng ", "Lỗi", MessageBoxButtons.OK,
                            MessageBoxIcon.Stop);
                    }
                }

                    if (success == true)
                    {
                        success = false;
                        MessageBox.Show("Lập hóa đơn thanh toán thành công ", "Thông báo", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        for (int k = 0; k < dgvHoaDon.RowCount; k++)
                        {
                            dgvHoaDon.Rows.RemoveAt(k);
                            k = -1;
                            numRow = 0;
                        }
                        fThanhToan_Load_1(sender, e);
                        ThietLapButton(false);
                        txtTenKhachHang.Text = "";
                        txtTongTien.Text = "0";
                    }
                
            }
            else
            {
                MessageBox.Show("Không lập hóa đơn thanh toán được ", "Lỗi", MessageBoxButtons.OK,
                        MessageBoxIcon.Stop);
            }
            ThietLapButton(false);
        }
    }
}
           

