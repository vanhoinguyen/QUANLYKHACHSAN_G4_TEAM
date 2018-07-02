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
using System.Text.RegularExpressions;

namespace QuanLiKhachSan.UserControl
{
    public partial class frmQuanLiDichVu : DevExpress.XtraEditors.XtraUserControl
    {
        public frmQuanLiDichVu()
        {
            InitializeComponent();
        }
        private void LamSachDL()
        {
            txtTenDichVu.Text = "";
            txtDonViTinh.Text = "";
            txtDonGia.Text = "";
        }
        private void btnOder_Click(object sender, EventArgs e)
        {
            UserControl.frmOderDichVu oder = new frmOderDichVu();
            oder.ShowDialog();
        }

        private void btnThemDichVu_Click(object sender, EventArgs e)
        {
            if (btnThemDichVu.Text == "Thêm dịch vụ")
            {
                LamSachDL();

                btnThemDichVu.Text = "Ngừng";
                btnCapNhatDichVu.Enabled = false;
                btnXoaDichVu.Enabled = false;
                btnThemDichVu.Enabled = true;
                //ThietLapTextbox(true);
                gcDanhSachDichVu.Enabled = false;
            }
            else
            {
                btnThemDichVu.Text = "Thêm dịch vụ";
                frmQuanLiDichVu_Load(sender, e);
                //KhoiTaoLai();
                btnCapNhatDichVu.Enabled = true;
                btnXoaDichVu.Enabled = true;
                gcDanhSachDichVu.Enabled = true;


            }
        }

        private void btnLuuDichVu_Click(object sender, EventArgs e)
        {
            DichVuDTO infor = LayThongTinDichVu();

            if (btnThemDichVu.Text == "Ngừng")
            {
                if (DichVuBUS.ThemDichVu(infor))
                {
                    MessageBox.Show("Bạn đã thêm dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmQuanLiDichVu_Load(sender, e);
                    btnCapNhatDichVu.Enabled = true;
                    btnXoaDichVu.Enabled = true;
                    gcDanhSachDichVu.Enabled = true;
                    btnThemDichVu.Text = "Thêm dịch vụ";
                }
                else
                    MessageBox.Show("Lỗi");
            }
            else if (btnCapNhatDichVu.Text == "Ngừng")
            {
                infor.MaDichVu = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["MaDichVu"]).ToString());
                if (DichVuBUS.SuaThongTinDichVu(infor))
                {
                    MessageBox.Show("Bạn đã sửa thông tin dịch vụ " + txtTenDichVu.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmQuanLiDichVu_Load(sender, e);
                    btnThemDichVu.Enabled = true;
                    btnCapNhatDichVu.Enabled = true;
                    btnXoaDichVu.Enabled = true;
                    gcDanhSachDichVu.Enabled = true;
                    btnCapNhatDichVu.Text = "Cập nhật";
                }
                else
                    MessageBox.Show("Lỗi");
            }
        }

        private void btnXoaDichVu_Click(object sender, EventArgs e)
        {
            DichVuDTO infor = LayThongTinDichVu();
            infor.MaDichVu = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["MaDichVu"]).ToString());

            DialogResult result = (MessageBox.Show("Bạn có muốn xóa dịch vụ " + txtTenDichVu.Text + " không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (result == DialogResult.Yes)
            {
                if (DichVuBUS.XoaDichVu(infor))
                {
                    MessageBox.Show("Bạn đã xóa dịch vụ " +txtTenDichVu.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmQuanLiDichVu_Load(sender, e);
                    //KhoiTaoLai();
                }
            }
        }

        private void frmQuanLiDichVu_Load(object sender, EventArgs e)
        {
            List<DichVuDTO> lstt = new List<DichVuDTO>();
            lstt = DichVuBUS.LoadDanhSach();
            for (int i = 0; i < lstt.Count; i++)
            {
                lstt[i].DonGia = Convert.ToDecimal(string.Format("{0:0,0}", lstt[i].DonGia));
            }
            gcDanhSachDichVu.DataSource = lstt;
        }

        private void btnCapNhatDichVu_Click(object sender, EventArgs e)
        {
            if (btnCapNhatDichVu.Text == "Cập nhật")
            {

                btnCapNhatDichVu.Text = "Ngừng";
                btnThemDichVu.Enabled = false;
                btnXoaDichVu.Enabled = false;
                btnCapNhatDichVu.Enabled = true;
                gcDanhSachDichVu.Enabled = false;
            }
            else
            {
                btnCapNhatDichVu.Text = "Cập nhật";
                frmQuanLiDichVu_Load(sender, e);
                //KhoiTaoLai();
                btnThemDichVu.Enabled = true;
                btnXoaDichVu.Enabled = true;
                gcDanhSachDichVu.Enabled = true;
            }
        }
        private DichVuDTO LayThongTinDichVu()
        {
            DichVuDTO infor = new DichVuDTO();


            infor.TenDichVu = txtTenDichVu.Text;
            infor.DonViTinh = txtDonViTinh.Text;
            infor.DonGia = Convert.ToDecimal(txtDonGia.Text);
            //infor.DonGia = Convert.ToDecimal( gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["DonGia"]).ToString
                //());
            return infor;
        }

        

        private void gcDanhSachDichVu_Click(object sender, EventArgs e)
        {
            txtTenDichVu.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["TenDichVu"]).ToString();
            txtDonViTinh.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["DonViTinh"]).ToString();
            //txtDonGia.Text = string.Format("{0:0,0 VNĐ}", gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["DonGia"]));
            txtDonGia.Text =  gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["DonGia"]).ToString();

        }

        private void txtTenDichVu_TextChanged(object sender, EventArgs e)
        {
            
            Control ctrl = (Control)sender;

            
            if(txtTenDichVu.Text.Length>=1)
            {
                errorProvider1.SetError(ctrl, "");
            }
            else
            {
                errorProvider1.SetError(ctrl,
                  "Tên không hợp lệ");
            }
        }

        private void txtDonViTinh_TextChanged(object sender, EventArgs e)
        {
            
            Control ctrl = (Control)sender;


            if(txtDonViTinh.Text.Length >= 1)
            {
                errorProvider2.SetError(ctrl, "");
            }
            else
            {
                errorProvider2.SetError(ctrl,
                  "Đơn vị tính không hợp lệ");
            }
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            Regex regex, regex1;
            regex = new Regex(@"^\d{1,12}$");
            regex1 = new Regex(@"^\d{1,3},\d{1,3}\s[A-Z]");
            Control ctrl = (Control)sender;
            if (regex.IsMatch(ctrl.Text)|| regex1.IsMatch(ctrl.Text))
            {
                errorProvider3.SetError(ctrl, "");
            }
            else
            {
                errorProvider3.SetError(ctrl,
                  "Gía không hợp lệ");
            }
        }
    }
}
