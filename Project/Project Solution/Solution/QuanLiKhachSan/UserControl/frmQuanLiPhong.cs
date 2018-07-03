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
    public partial class frmQuanLiPhong : DevExpress.XtraEditors.XtraUserControl
    {
        public frmQuanLiPhong()
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
            btnThemPhong.Enabled = !flag;
            btnCapNhat.Enabled = !flag;
            btnXoaPhong.Enabled = !flag;

            btnLuu.Enabled = flag;
        }
        private void frmQuanLiPhong_Load(object sender, EventArgs e)
        {
            cmbLoaiPhong.DataSource = PhongBUS.LoaiPhong();
            ThietLapTextbox(false);
            ThietLapButton(false);
            List<PhongDTO> lstt = new List<PhongDTO>();
            lstt = PhongBUS.DanhSachPhong();
            for (int i = 0; i < lstt.Count; i++)
            {
                lstt[i].DonGia = Convert.ToDecimal(string.Format("{0:0,0}", lstt[i].DonGia));
            }

            gcDanhSachPhong.DataSource = lstt;
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

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            if (btnThemPhong.Text == "Thêm phòng")
            {
                LamSachDL();
                txtTinhTrang.Text = "Trống";
                btnThemPhong.Text = "Ngừng";
                ThietLapButton(true);
                btnThemPhong.Enabled = true;
                ThietLapTextbox(true);
                gcDanhSachPhong.Enabled = false;
            }
            else
            {
                btnThemPhong.Text = "Thêm phòng";
                frmQuanLiPhong_Load(sender, e);
                KhoiTaoLai();
                gcDanhSachPhong.Enabled = true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            PhongDTO infor = LayThongTinPhong();
            if (btnThemPhong.Text == "Ngừng")
            {
                if (PhongBUS.ThemPhong(infor))
                {
                    MessageBox.Show("Bạn đã thêm phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmQuanLiPhong_Load(sender, e);
                    KhoiTaoLai();
                    gcDanhSachPhong.Enabled = true;
                    btnThemPhong.Text = "Thêm phòng";
                }
                else
                    MessageBox.Show("Lỗi");
            }
            else if (btnCapNhat.Text == "Ngừng")
            {
                if (PhongBUS.SuaThongTinPhong(infor))
                {
                    MessageBox.Show("Bạn đã sửa thông tin phòng " + txtMaPhong.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmQuanLiPhong_Load(sender, e);
                    KhoiTaoLai();
                    gcDanhSachPhong.Enabled = true;
                    btnCapNhat.Text = "Cập nhật";
                }
                else
                    MessageBox.Show("Lỗi");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text != "")
            {
                if (btnCapNhat.Text == "Cập nhật")
                {
                    btnCapNhat.Text = "Ngừng";
                    ThietLapButton(true);
                    btnCapNhat.Enabled = true;
                    ThietLapTextbox(true);
                    txtDonGia.Text = "";
                    gcDanhSachPhong.Enabled = false;
                }
                else
                {
                    btnCapNhat.Text = "Cập nhật";
                    frmQuanLiPhong_Load(sender, e);
                    KhoiTaoLai();
                    gcDanhSachPhong.Enabled = true;
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

        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text != "" && txtTinhTrang.Text == "Trống")
            {
                PhongDTO infor = LayThongTinPhong();
                DialogResult result = (MessageBox.Show("Bạn có muốn xóa phòng " + txtMaPhong.Text + " không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (result == DialogResult.Yes)
                {
                    if (PhongBUS.XoaPhongTrongCTHoaDon(infor))
                        if (PhongBUS.XoaPhong(infor))
                        {
                            MessageBox.Show("Bạn đã xóa phòng " + txtMaPhong.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmQuanLiPhong_Load(sender, e);
                            KhoiTaoLai();
                        }
                }             
            }
            if (txtTinhTrang.Text == "Đầy")
            {
                MessageBox.Show("Không thể xóa phòng đang được đặt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gvDanhSachPhong_Click(object sender, EventArgs e)
        {
            string tinhtrang = gvDanhSachPhong.GetRowCellValue(gvDanhSachPhong.FocusedRowHandle, gvDanhSachPhong.Columns["TinhTrang"]).ToString();
            
            {
                txtMaPhong.Text = gvDanhSachPhong.GetRowCellValue(gvDanhSachPhong.FocusedRowHandle, gvDanhSachPhong.Columns["MaPhong"]).ToString();
                cmbLoaiPhong.Text = gvDanhSachPhong.GetRowCellValue(gvDanhSachPhong.FocusedRowHandle, gvDanhSachPhong.Columns["TenLoaiPhong"]).ToString();
                txtTinhTrang.Text = gvDanhSachPhong.GetRowCellValue(gvDanhSachPhong.FocusedRowHandle, gvDanhSachPhong.Columns["TinhTrang"]).ToString();
                txtDonGia.Text = string.Format("{0:0,0}", gvDanhSachPhong.GetRowCellValue(gvDanhSachPhong.FocusedRowHandle, gvDanhSachPhong.Columns["DonGia"]));
                txtGhiChu.Text = gvDanhSachPhong.GetRowCellValue(gvDanhSachPhong.FocusedRowHandle, gvDanhSachPhong.Columns["GhiChu"]).ToString();
            }
           
        }

        private void cmbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<PhongDTO>  ldg = PhongBUS.LoadDonGia("A");
            List<PhongDTO> ldg1 = PhongBUS.LoadDonGia("B");
            List<PhongDTO> ldg2 = PhongBUS.LoadDonGia("C");
            if (cmbLoaiPhong.Text == "A")
                txtDonGia.Text = string.Format("{0:0,0 VNĐ}" ,ldg[0].DonGia.Value);
            if (cmbLoaiPhong.Text == "B")
                txtDonGia.Text = string.Format("{0:0,0 VNĐ}",ldg1[0].DonGia.Value);
            if (cmbLoaiPhong.Text == "C")
                txtDonGia.Text = string.Format("{0:0,0 VNĐ}",ldg2[0].DonGia.Value);
        }
    }
}
