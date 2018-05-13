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
            cmbMaPhong.ValueMember = "MaPhong";
            cmbMaPhong.DisplayMember = "MaPhong";
        }
        int numRow = 0;

        private void fThanhToan_Load(object sender, EventArgs e)
        {
            cmbMaPhong.DataSource = HoaDonBUS.LoadMaPhong();
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
            bool flag = true;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["MaPhong"].ToString()) == cmbMaPhong.Text)
                {
                    btnThem.Enabled = false;
                    flag = false;
                    break;
                }
            }
            if (flag == true)
            {
                btnThem.Enabled = true;
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            gridView1.AddNewRow();
            //gridView1.Rows[numRow]
        }
        
    }
}