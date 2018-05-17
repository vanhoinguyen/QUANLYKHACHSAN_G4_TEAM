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

        private void cmbThamSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ThamSoDTO> lst = new List<ThamSoDTO>();
            if(cmbThamSo.Text == "Số lượng khách tối đa")
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

        private void txtGiaTri_TextChanged(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
        }
    }
}