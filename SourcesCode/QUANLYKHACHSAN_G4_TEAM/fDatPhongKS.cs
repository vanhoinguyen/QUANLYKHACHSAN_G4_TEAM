using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYKHACHSAN_G4_TEAM.DatPhong
{
    public partial class fDatPhongKS : DevExpress.XtraEditors.XtraForm
    {
        //khai bao cac bien static nhan du lieu
        public static string room = string.Empty;
        public static string roomtype = string.Empty;
        //bien de ktra SL khach da dc them vao 1 phong
        int numRow = 0;
        //bien xac dinh SL toi da khach co the o cung 1 phong(theo quy dinh khach san)
        int maxCus = 0;

        public fDatPhongKS()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (numRow < maxCus)
            {
                if (txtTenKhachHang.Text != "" && txtDiaChi.Text != "" && txtCMND.Text != "")
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[numRow].Cells["colTenKhachHang"].Value = txtTenKhachHang.Text;
                    dataGridView1.Rows[numRow].Cells["colLoaiKhach"].Value = cmbLoaiKhach.SelectedValue;
                    dataGridView1.Rows[numRow].Cells["colCMND"].Value = txtCMND.Text;
                    dataGridView1.Rows[numRow].Cells["colDiaChi"].Value = txtDiaChi.Text;
                    numRow++;

                    btnLuu.Enabled = true;
                    btnXoa.Enabled = true;

                    txtTenKhachHang.Text = "";
                    txtCMND.Text = "";
                    txtDiaChi.Text = "";
                    txtTenKhachHang.Focus();
                }
            }
            else
            {
                btnThem.Enabled = false;
            }
        }

        private void fDatPhongKS_Load(object sender, EventArgs e)
        {

            txtMaPhong.Text = room;
            txtLoaiPhong.Text = roomtype;

            cmbLoaiKhach.DataSource = KhachHangBUS.LayDSLoaiKhach();
            cmbLoaiKhach.ValueMember = "MaLoaiKhach";
            cmbLoaiKhach.DisplayMember = "LoaiKhach";
            //cmbLoaiKhach.DisplayMember = "TenLoaiKhach";

            #region
            List<ThamSoDTO> lstMaxCus = PhongBUS.SoLuongKhachToiDa();
            maxCus = lstMaxCus[0].SLKhachToiDa;
            #endregion
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string kt_chon = "false";
            for (int j = 0; j < dataGridView1.Rows.Count; j++)
            {
                try
                {
                    kt_chon = dataGridView1.Rows[j].Cells["colXoa"].Value.ToString();
                }
                catch { }
                if (kt_chon == "True")
                {
                    dataGridView1.Rows.RemoveAt(j);
                    kt_chon = "false";
                    numRow--;
                    j = -1;
                    btnThem.Enabled = true;
                }
            }
            if (dataGridView1.RowCount == 0)
            {
                btnXoa.Enabled = false;
                btnLuu.Enabled = false;
            }
        }

        #region
        private PhieuThuePhongDTO LayThongTinPhong()
        {
            PhieuThuePhongDTO p = new PhieuThuePhongDTO();
            p.MaPhong = int.Parse(txtMaPhong.Text);
            p.NgayThue = Convert.ToDateTime(dtpNgayThue.Text);
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
            kh.TenKhachHang = dataGridView1.Rows[i].Cells["colTenKhachHang"].Value.ToString();
            kh.CMND = dataGridView1.Rows[i].Cells["colCMND"].Value.ToString();
            kh.DiaChi = dataGridView1.Rows[i].Cells["colDiaChi"].Value.ToString();
            kh.MaLoaiKhach = dataGridView1.Rows[i].Cells["colLoaiKhach"].Value.ToString();
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

        #endregion

        private void btnLuu_Click(object sender, EventArgs e)
        {
            PhieuThuePhongDTO p = LayThongTinPhong();
            ChiTietPhieuThueDTO ct = LayMaKeTiep();

            if (PhieuThueBUS.ThemPhieuThuePhong(ct, p))
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}