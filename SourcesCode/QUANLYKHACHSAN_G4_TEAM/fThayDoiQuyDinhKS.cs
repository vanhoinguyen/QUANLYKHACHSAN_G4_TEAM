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
namespace QUANLYKHACHSAN_G4_TEAM
{
    public partial class fThayDoiQuyDinhKS : DevExpress.XtraEditors.XtraForm
    {
        public fThayDoiQuyDinhKS()
        {
            InitializeComponent();
           
            
        }

        private void txtGiaTri_TextChanged(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
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
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            List<ThamSoDTO> lst = new List<ThamSoDTO>();
             ThamSoDTO ts = new ThamSoDTO();

            lst = ThamSoBUS.LayThongTinTS();
            

            if (cmbThamSo.Text == "Số lượng khách tối đa")
            {
                ts.SLKhachToiDa = Convert.ToInt32(txtGiaTri.Text);
                if(ThamSoBUS.CapNhatTSSoKhachToiDa(ts) == true )
                {
                    MessageBox.Show("Cập nhập thành công số khách tối đa","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (ThamSoBUS.CapNhatTSPhuThu(ts) == true )
                {
                    MessageBox.Show("Cập nhập phụ thu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}