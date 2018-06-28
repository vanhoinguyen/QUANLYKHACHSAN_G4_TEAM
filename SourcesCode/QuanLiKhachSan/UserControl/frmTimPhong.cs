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
using BUS;
using DTO;


namespace QuanLiKhachSan.UserControl
{
    public partial class frmTimPhong : DevExpress.XtraEditors.XtraUserControl
    {
        PhongBUS phongBUS = new PhongBUS();
        public frmTimPhong()
        {
            InitializeComponent();
            cmbLoaiPhong.DisplayMember = "TenLoaiPhong";
            cmbLoaiPhong.ValueMember = "MaLoaiPhong";
        }
        List<PhongDTO> lstt = new List<PhongDTO>();
        private void SuKienLoadForm()
        {
            cmbLoaiPhong.DataSource = PhongBUS.LoaiPhong();
            lstt = PhongBUS.DanhSachPhong();
            for (int i = 0; i < lstt.Count; i++)
            {
                lstt[i].DonGia = Convert.ToDecimal(string.Format("{0:0,0}", lstt[i].DonGia));
            }
            gcDanhSachPhong.DataSource = lstt;
            btnDatPhong.Enabled = false;
        }
        private PhongDTO LayThongTinTimKiem()
        {
            PhongDTO thongtin = new PhongDTO();
            thongtin.TenLoaiPhong = cmbLoaiPhong.Text;
            thongtin.GhiChu = txtGhiChu.Text;

            return thongtin;
        }

        private void TimKiemTheoYeuCau(int s)
        {
            PhongDTO thongtin = LayThongTinTimKiem();
            if (s == 1)
            {
                lstt = PhongBUS.DanhSachPhongYeuCau(thongtin);
                for (int i = 0; i < lstt.Count; i++)
                {
                    lstt[i].DonGia = Convert.ToDecimal(string.Format("{0:0,0}", lstt[i].DonGia));
                }
                gcDanhSachPhong.DataSource = lstt;
            }
            else if (s == 2)
            {
                lstt = PhongBUS.DanhSachPhongTheoLoai(thongtin);
                for (int i = 0; i < lstt.Count; i++)
                {
                    lstt[i].DonGia = Convert.ToDecimal(string.Format("{0:0,0}", lstt[i].DonGia));
                }
                gcDanhSachPhong.DataSource = lstt;
            }
            else if (s == 3)
            {
                lstt = PhongBUS.DanhSachPhongTheoLoaiTheoYeuCau(thongtin);
                for (int i = 0; i < lstt.Count; i++)
                {
                    lstt[i].DonGia = Convert.ToDecimal(string.Format("{0:0,0}", lstt[i].DonGia));
                }
                gcDanhSachPhong.DataSource = lstt;
            }
            else if (s == 4)
            {
                decimal dgtu = Convert.ToDecimal(txtDonGiaTu.Text);
                lstt = PhongBUS.DanhSachPhongTheoDGTu(dgtu);
                for (int i = 0; i < lstt.Count; i++)
                {
                    lstt[i].DonGia = Convert.ToDecimal(string.Format("{0:0,0}", lstt[i].DonGia));
                }
                gcDanhSachPhong.DataSource = lstt;
            }
            else if (s == 5)
            {
                decimal dgtu = Convert.ToDecimal(txtDonGiaTu.Text);
                decimal dgden = Convert.ToDecimal(txtDonGiaDen.Text);
                lstt = PhongBUS.DanhSachPhongTheoKhoangDG(dgtu, dgden);
                for (int i = 0; i < lstt.Count; i++)
                {
                    lstt[i].DonGia = Convert.ToDecimal(string.Format("{0:0,0}", lstt[i].DonGia));
                }
                gcDanhSachPhong.DataSource = lstt;
            }
            else if (s == 6)
            {
                decimal dgden = Convert.ToDecimal(txtDonGiaDen.Text);

                lstt = PhongBUS.DanhSachPhongTheoDGDen(dgden);
                for (int i = 0; i < lstt.Count; i++)
                {
                    lstt[i].DonGia = Convert.ToDecimal(string.Format("{0:0,0}", lstt[i].DonGia));
                }
                gcDanhSachPhong.DataSource = lstt;
            }
        }
        private void btnTimTatCa_Click(object sender, EventArgs e)
        {
            gcDanhSachPhong.DataSource = PhongBUS.DanhSachPhong();
            txtDonGiaTu.Text = "";
            txtDonGiaDen.Text = "";
        }

        private void btnTimPhongTraGanNhat_Click(object sender, EventArgs e)
        {
            List<PhieuThuePhongDTO> pt = new List<PhieuThuePhongDTO>();
            pt = PhongBUS.NgayTraPhong();
            int k = 0;
            for (int i = 0; i < pt.Count; i++)
            {
                if (DateTime.Today == pt[i].NgayTraPhong)
                {
                    MessageBox.Show("Phòng trả  trong ngày hôm nay(" + DateTime.Today.ToString("d") + "): " + pt[i].MaPhong);
                }
                else k++;
            }
            if (k == pt.Count) MessageBox.Show("Không có phòng được trả trong ngày hôm nay! ");
            gcDanhSachPhong.DataSource = PhongBUS.DanhSachPhongTraGanNhat();
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            frmPhieuThuePhong.room = gvPhong.GetRowCellValue(gvPhong.FocusedRowHandle, gvPhong.Columns["MaPhong"]).ToString();
            frmPhieuThuePhong.roomtype = gvPhong.GetRowCellValue(gvPhong.FocusedRowHandle, gvPhong.Columns["TenLoaiPhong"]).ToString();

            frmPhieuThuePhong frmRentRoom = new frmPhieuThuePhong();
            frmRentRoom.Show();

            gcDanhSachPhong.Enabled = false;
            btnDatPhong.Enabled = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            SuKienLoadForm();
            gcDanhSachPhong.Enabled = true;
        }

        private void frmTimPhong_Load(object sender, EventArgs e)
        {
            SuKienLoadForm();
        }

        private void gvPhong_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == gvPhong.Columns["TinhTrang"])
            {
                var tinhtrang = Convert.ToString(gvPhong.GetRowCellValue(e.RowHandle, gvPhong.Columns["TinhTrang"]));
                if (tinhtrang == "Đầy")
                {
                    e.Appearance.BackColor = Color.FromArgb(0x00, 0xFF, 0x00);
                }

                if (tinhtrang == "Sửa chữa")
                {
                    e.Appearance.BackColor = Color.FromArgb(0xFF, 0x00, 0x00);
                }
            }
        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {
            TimKiemTheoYeuCau(1);
        }

        private void cmbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtDonGiaTu.Text == "" && txtDonGiaDen.Text == "" && txtGhiChu.Text == "")
            {
                TimKiemTheoYeuCau(2);
            }

            else if (txtDonGiaTu.Text == "" && txtDonGiaDen.Text == "" && txtGhiChu.Text != "")
            {
                TimKiemTheoYeuCau(3);
            }
        }

        private void txtDonGiaTu_TextChanged(object sender, EventArgs e)
        {
            if (txtDonGiaTu.Text != "")
            {
                if (txtDonGiaDen.Text == "")
                {
                    TimKiemTheoYeuCau(4);
                }
                else
                {
                    TimKiemTheoYeuCau(5);
                }
            }
            else if (txtDonGiaTu.Text == "" && txtDonGiaDen.Text == "")
            {
                TimKiemTheoYeuCau(2);
            }
        }

        private void txtDonGiaDen_TextChanged(object sender, EventArgs e)
        {
            if (txtDonGiaDen.Text != "")
            {
                if (txtDonGiaTu.Text == "")
                {
                    TimKiemTheoYeuCau(6);
                }
                else
                {
                    TimKiemTheoYeuCau(5);
                }
            }
            else if (txtDonGiaTu.Text == "" && txtDonGiaDen.Text == "")
            {
                TimKiemTheoYeuCau(2);
            }
        }

        private void gvPhong_Click(object sender, EventArgs e)
        {
            string status = gvPhong.GetRowCellValue(gvPhong.FocusedRowHandle, gvPhong.Columns["TinhTrang"]).ToString();
            if (status == "Trống")
                btnDatPhong.Enabled = true;
            else
                btnDatPhong.Enabled = false;
        }

        private void txtDonGiaTu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDonGiaDen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
