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

namespace QUANLYKHACHSAN_G4_TEAM.QuanLiPhong
{
    public partial class fQuanLiPhong : DevExpress.XtraEditors.XtraForm
    {
        public fQuanLiPhong()
        {
            InitializeComponent();
            cmbLoaiPhong.DisplayMember = "TenLoaiPhong";
            cmbLoaiPhong.ValueMember = "MaLoaiPhong";
        }

        private void ThietLapTextbox(bool flag)
        {
            cmbLoaiPhong.Enabled = flag;
            txtTinhTrang.Enabled = flag;
            txtGhiChu.Enabled = flag;
        }

        private void ThietLapButton(bool flag)
        {
            btnThem.Enabled = !flag;
            btnSua.Enabled = !flag;
            btnXoa.Enabled = !flag;

            btnLuu.Enabled = flag;
        }

        private void fQuanLiPhong_Load(object sender, EventArgs e)
        {
            cmbLoaiPhong.DataSource = PhongBUS.LoaiPhong();
            ThietLapTextbox(false);
            ThietLapButton(false);
            gcDSPhong.DataSource = PhongBUS.DanhSachPhong();
        }

        private void gvDSPhong_Click(object sender, EventArgs e)
        {
            string tinhtrang = gvDSPhong.GetRowCellValue(gvDSPhong.FocusedRowHandle, gvDSPhong.Columns["TinhTrang"]).ToString();
            if (tinhtrang != "Đầy")
            {
                txtMaPhong.Text = gvDSPhong.GetRowCellValue(gvDSPhong.FocusedRowHandle, gvDSPhong.Columns["MaPhong"]).ToString();
                cmbLoaiPhong.Text = gvDSPhong.GetRowCellValue(gvDSPhong.FocusedRowHandle, gvDSPhong.Columns["TenLoaiPhong"]).ToString();
                txtTinhTrang.Text = gvDSPhong.GetRowCellValue(gvDSPhong.FocusedRowHandle, gvDSPhong.Columns["TinhTrang"]).ToString();
                txtDonGia.Text = gvDSPhong.GetRowCellValue(gvDSPhong.FocusedRowHandle, gvDSPhong.Columns["DonGia"]).ToString();
                txtGhiChu.Text = gvDSPhong.GetRowCellValue(gvDSPhong.FocusedRowHandle, gvDSPhong.Columns["GhiChu"]).ToString();
            }
        }

        private void LamSachDL()
        {
            txtDonGia.Text = "";
            txtGhiChu.Text = "";
        }

        private void KhoiTaoLai()
        {
            ThietLapButton(false);
            txtMaPhong.Text = "";
        
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm phòng")
            {
                LamSachDL();
                txtTinhTrang.Text = "Trống";
                btnThem.Text = "Ngừng";
                ThietLapButton(true);
                btnThem.Enabled = true;
                ThietLapTextbox(true);
                gcDSPhong.Enabled = false;
            }
            else
            {
                btnThem.Text = "Thêm phòng";
                fQuanLiPhong_Load(sender, e);
                KhoiTaoLai();
                gcDSPhong.Enabled = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text != "")
            {
                if (btnSua.Text == "Cập nhật")
                {
                    btnSua.Text = "Ngừng";
                    ThietLapButton(true);
                    btnSua.Enabled = true;
                    ThietLapTextbox(true);
                    txtDonGia.Text = "";
                    gcDSPhong.Enabled = false;
                }
                else
                {
                    btnSua.Text = "Cập nhật";
                    fQuanLiPhong_Load(sender, e);
                    KhoiTaoLai();
                    gcDSPhong.Enabled = true;
                }
            }
        }

        private PhongDTO LayThongTinPhong()
        {
            PhongDTO infor = new PhongDTO();
            if (txtMaPhong.Text != "")
            {
                infor.MaPhong = int.Parse(txtMaPhong.Text);
            }
            
            infor.MaLoaiPhong = cmbLoaiPhong.SelectedValue.ToString();
            infor.TinhTrang = txtTinhTrang.Text;
            infor.GhiChu = txtGhiChu.Text;
            return infor;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            PhongDTO infor = LayThongTinPhong();
            if (btnThem.Text == "Ngừng")
            {
                if (PhongBUS.ThemPhong(infor))
                {
                    MessageBox.Show("Bạn đã thêm phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fQuanLiPhong_Load(sender, e);
                    KhoiTaoLai();
                    gcDSPhong.Enabled = true;
                    btnThem.Text = "Thêm phòng";
                }
            }
            else if (btnSua.Text == "Ngừng")
            {
                if (PhongBUS.SuaThongTinPhong(infor))
                {
                    MessageBox.Show("Bạn đã sửa thông tin phòng " + txtMaPhong.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fQuanLiPhong_Load(sender, e);
                    KhoiTaoLai();
                    gcDSPhong.Enabled = true;
                    btnSua.Text = "Cập nhật";
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text != "")
            {
                PhongDTO infor = LayThongTinPhong();
                DialogResult result = (MessageBox.Show("Bạn có muốn xóa phòng " + txtMaPhong.Text + " không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (result == DialogResult.Yes)
                {
                    if (PhongBUS.XoaPhong(infor))
                    {
                        MessageBox.Show("Bạn đã xóa phòng " + txtMaPhong.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fQuanLiPhong_Load(sender, e);
                        KhoiTaoLai();
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}