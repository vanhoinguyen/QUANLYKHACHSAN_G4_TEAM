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
namespace QuanLiKhachSan.UserControl
{
    public partial class frmQuyDinh : DevExpress.XtraEditors.XtraForm
    {
        public frmQuyDinh()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCapNhatQuyDinh_Click(object sender, EventArgs e)
        {
            List<ThamSoDTO> lst = new List<ThamSoDTO>();
            ThamSoDTO ts = new ThamSoDTO();

            lst = ThamSoBUS.LayThongTinTS();


            if (cmbThamSo.Text == "Số lượng khách tối đa")
            {
                ts.SLKhachToiDa = Convert.ToInt32(txtGiaTri.Text);
                if (ThamSoBUS.CapNhatTSSoKhachToiDa(ts) == true)
                {
                    MessageBox.Show("Cập nhập thành công số khách tối đa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (cmbThamSo.Text == "Hệ số")
            {
                ts.HeSo = Convert.ToDouble(txtGiaTri.Text);
                if (ThamSoBUS.CapNhatTSHeSo(ts) == true)
                {
                    MessageBox.Show("Cập nhập hệ số thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (cmbThamSo.Text == "Phụ thu")
            {
                ts.PhuThu = Convert.ToDouble(txtGiaTri.Text);
                if (ThamSoBUS.CapNhatTSPhuThu(ts) == true)
                {
                    MessageBox.Show("Cập nhập phụ thu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (cmbThamSo.Text == "Loại phòng A")
            {
                string lp = "A";
                ts.DonGia = Convert.ToDecimal(txtGiaTri.Text);
                if (ThamSoBUS.CapNhatTSDonGia(ts, lp) == true)
                {
                    MessageBox.Show("Cập nhập giá phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Lỗi hệ thống hoặc nhập sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (cmbThamSo.Text == "Loại phòng B")
            {
                string lp1 = "B";
                ts.DonGia = Convert.ToDecimal(txtGiaTri.Text);
                if (ThamSoBUS.CapNhatTSDonGia(ts, lp1) == true)
                {
                    MessageBox.Show("Cập nhập giá phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Lỗi hệ thống hoặc nhập sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (cmbThamSo.Text == "Loại phòng C")
            {
                string lp2 = "C";
                ts.DonGia = Convert.ToDecimal(txtGiaTri.Text);
                if (ThamSoBUS.CapNhatTSDonGia(ts, lp2) == true)
                {
                    MessageBox.Show("Cập nhập giá phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Lỗi hệ thống hoặc nhập sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtGiaTri_TextChanged(object sender, EventArgs e)
        {
            btnCapNhatQuyDinh.Enabled = true;
        }

        private void cmbThamSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ThamSoDTO> lst = new List<ThamSoDTO>();

            if (cmbThamSo.Text == "Số lượng khách tối đa")
            {
                lst = ThamSoBUS.LoadSoLuongKhach();
                txtGiaTri.Text = lst[0].SLKhachToiDa.ToString();
            }
            if (cmbThamSo.Text == "Hệ số")
            {
                lst = ThamSoBUS.LoadHeSo();
                txtGiaTri.Text = lst[0].HeSo.ToString();
            }
            if (cmbThamSo.Text == "Phụ thu")
            {
                lst = ThamSoBUS.LoadPhuThu();
                txtGiaTri.Text = lst[0].PhuThu.ToString();
            }
            if (cmbThamSo.Text == "Loại phòng A")
            {
                string lp = "A";
                lst = ThamSoBUS.LoadDonGia(lp);
                txtGiaTri.Text = string.Format("{0:0,0}", lst[0].DonGia);
            }
            if (cmbThamSo.Text == "Loại phòng B")
            {
                string lp1 = "B";
                lst = ThamSoBUS.LoadDonGia(lp1);
                txtGiaTri.Text = string.Format("{0:0,0}", lst[0].DonGia);
            }
            if (cmbThamSo.Text == "Loại phòng C")
            {
                string lp2 = "C";
                lst = ThamSoBUS.LoadDonGia(lp2);
                txtGiaTri.Text = string.Format("{0:0,0}", lst[0].DonGia);
            }
        }


    }
}