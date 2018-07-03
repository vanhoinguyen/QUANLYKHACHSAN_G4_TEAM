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
using System.Text.RegularExpressions;
using BUS;
using DTO;

namespace QuanLiKhachSan.UserControl
{
    public partial class frmPhieuThuePhong : DevExpress.XtraEditors.XtraForm
    {
        //khai bao cac bien static nhan du lieu
        public static string room = string.Empty;
        public static string roomtype = string.Empty;
        //bien de ktra SL khach da dc them vao 1 phong
        int numRow = 0;
        //bien xac dinh SL toi da khach co the o cung 1 phong(theo quy dinh khach san)
        int maxCus = 0;
        public frmPhieuThuePhong()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThemPhieuThue_Click(object sender, EventArgs e)
        {
            if (numRow < maxCus)
            {
                if (txtTenKhachHang.Text != "" && txtDiaChi.Text != "" && txtCMND.Text != "")
                {
                    dgvDanhSachPhieuThue.Rows.Add();
                    dgvDanhSachPhieuThue.Rows[numRow].Cells["colTenKhachHang"].Value = txtTenKhachHang.Text;
                    dgvDanhSachPhieuThue.Rows[numRow].Cells["colLoaiKhach"].Value = cmbLoaiKhachHang.SelectedValue;
                    dgvDanhSachPhieuThue.Rows[numRow].Cells["colTenLoaiKhach"].Value = cmbLoaiKhachHang.Text;
                    dgvDanhSachPhieuThue.Rows[numRow].Cells["colCMND"].Value = txtCMND.Text;
                    dgvDanhSachPhieuThue.Rows[numRow].Cells["colDiaChi"].Value = txtDiaChi.Text;
                    numRow++;

                    btnLuuPhieuThue.Enabled = true;
                    btnXoaPhieuThue.Enabled = true;

                    txtTenKhachHang.Text = "";
                    txtCMND.Text = "";
                    txtDiaChi.Text = "";
                    txtTenKhachHang.Focus();
                }
            }
            else
            {
                btnThemPhieuThue.Enabled = false;
            }
        }

        private void btnXoaPhieuThue_Click(object sender, EventArgs e)
        {
            string kt_chon = "false";
            for (int j = 0; j < dgvDanhSachPhieuThue.Rows.Count; j++)
            {
                try
                {
                    kt_chon = dgvDanhSachPhieuThue.Rows[j].Cells["colXoa"].Value.ToString();
                }
                catch { }
                if (kt_chon == "True")
                {
                    dgvDanhSachPhieuThue.Rows.RemoveAt(j);
                    kt_chon = "false";
                    numRow--;
                    j -=1;
                    btnThemPhieuThue.Enabled = true;
                }
            }
            if (dgvDanhSachPhieuThue.RowCount == 0)
            {
                btnXoaPhieuThue.Enabled = false;
                btnLuuPhieuThue.Enabled = false;
            }
        }

        private void btnLuuPhieuThue_Click(object sender, EventArgs e)
        {
            PhieuThuePhongDTO p = LayThongTinPhong();
            ChiTietPhieuThueDTO ct = LayMaKeTiep();

            if (PhieuThueBUS.ThemPhieuThuePhong(ct, p))
            {
                for (int i = 0; i < dgvDanhSachPhieuThue.Rows.Count; i++)
                {
                    KhachHangDTO kh = LayThongTinKhachHang(i);
                    if (KhachHangBUS.ThemKhachHang(kh))
                    {
                        if (!PhieuThueBUS.ThemCTPhieuThuePhong(ct, kh))
                        {
                            MessageBox.Show("Không thêm được chi tiết phiếu thuê", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thêm được thông tin khách hàng" + kh.TenKhachHang + "", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                if (PhongBUS.CapNhatTinhTrangPhong(p))
                {
                    MessageBox.Show("Lập phiếu thuê thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ((Form)this.TopLevelControl).Close();

                }
                else
                {
                    MessageBox.Show("Không cập nhật được tình trạng phòng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Không thêm được phiếu thuê", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void frmPhieuThuePhong_Load(object sender, EventArgs e)
        {
            txtMaPhong.Text = room;
            txtLoaiPhong.Text = roomtype;

            cmbLoaiKhachHang.DataSource = KhachHangBUS.LayDSLoaiKhach();
            cmbLoaiKhachHang.ValueMember = "MaLoaiKhach";
            cmbLoaiKhachHang.DisplayMember = "LoaiKhach";


            #region
            List<ThamSoDTO> lstMaxCus = PhongBUS.SoLuongKhachToiDa();
            maxCus = lstMaxCus[0].SLKhachToiDa;
            #endregion
        }
        private PhieuThuePhongDTO LayThongTinPhong()
        {
            PhieuThuePhongDTO p = new PhieuThuePhongDTO();
            p.MaPhong = int.Parse(txtMaPhong.Text);
            p.NgayThue = Convert.ToDateTime(dtpNgayThuePhong.Text);
            p.NgayTraPhong = Convert.ToDateTime(dtpNgayTraPhong.Text);
            return p;
        }
        private KhachHangDTO LayThongTinKhachHang(int i)
        {
            KhachHangDTO kh = new KhachHangDTO();
            List<KhachHangDTO> lst = new List<KhachHangDTO>();
            try
            {
                lst = PhieuThueBUS.LayMaKHKeTiep();
                kh.MaKH = lst[0].MaKH + 1;

            }
            catch
            {
                kh.MaKH = 1;
            }
            kh.TenKhachHang = dgvDanhSachPhieuThue.Rows[i].Cells["colTenKhachHang"].Value.ToString();
            kh.CMND = dgvDanhSachPhieuThue.Rows[i].Cells["colCMND"].Value.ToString();
            kh.DiaChi = dgvDanhSachPhieuThue.Rows[i].Cells["colDiaChi"].Value.ToString();
            kh.MaLoaiKhach = dgvDanhSachPhieuThue.Rows[i].Cells["colLoaiKhach"].Value.ToString();
            return kh;
        }
        private ChiTietPhieuThueDTO LayMaKeTiep()
        {
            ChiTietPhieuThueDTO ct = new ChiTietPhieuThueDTO();
            List<PhieuThuePhongDTO> lst = new List<PhieuThuePhongDTO>();
            try
            {
                lst = PhieuThueBUS.LayMaPTKeTiep();
                ct.MaPT = lst[0].MaPT + 1;
                lst = PhieuThueBUS.LayMaCTPTKeTiep();
                ct.MaCTPT = lst[0].MaCTPT + 1;
            }
            catch
            {
                ct.MaPT = 1;
                ct.MaCTPT = 1;
            }
            return ct;
        }

        private void txtTenKhachHang_TextChanged(object sender, EventArgs e)
        {
            Regex  regex4, regex5, regex6, regex7;
            
            regex4 = new Regex(@"^\d+$");
            regex5 = new Regex(@"^\d+\s\d+$");
            regex6 = new Regex(@"^\d+\s\d+\s\d+$");
            regex7 = new Regex(@"^\d+\s\d+\s\d+\s\d+$");
            Control ctrl = (Control)sender;
            if (regex4.IsMatch(ctrl.Text) || regex5.IsMatch(ctrl.Text)
                || regex6.IsMatch(ctrl.Text) || regex7.IsMatch(ctrl.Text) )
                errorProvider4.SetError(ctrl,
                  "Tên không được chứa số");
            string st = "";
            st = txtTenKhachHang.Text;
            if(st.Length <1 )
                errorProvider4.SetError(ctrl,
                  "Tên không hợp lệ");
            else
                errorProvider4.SetError(ctrl, "");
        }

        private void txtCMND_TextChanged(object sender, EventArgs e)
        {
            Regex regex;
            regex = new Regex(@"^\w{9,12}$");
            Control ctrl = (Control)sender;
            if (regex.IsMatch(ctrl.Text))
            {
                errorProvider2.SetError(ctrl, "");
            }
            else
            {
                errorProvider2.SetError(ctrl,
                  "CMND không hợp lệ");
            }
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            string st = "";
            st=txtDiaChi.Text;
            if (st.Length < 1)
                errorProvider1.SetError(ctrl, "Địa chỉ không hợp lệ");
            else
                errorProvider1.SetError(ctrl, "");
        }
    }
}