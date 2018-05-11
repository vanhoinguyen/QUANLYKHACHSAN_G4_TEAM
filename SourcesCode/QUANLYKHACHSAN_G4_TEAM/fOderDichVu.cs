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
    public partial class fOderDichVu : DevExpress.XtraEditors.XtraForm
    {
        public fOderDichVu()
        {
            InitializeComponent();
        }

        private void fOderDichVu_Load(object sender, EventArgs e)
        {
            cmbMaPhong.DataSource = OderDichVuBUS.LoadDanhSachMaPhong();
            cmbMaPhong.DisplayMember = "MaPhong";
            cmbTenDichVu.DataSource = OderDichVuBUS.LoadDanhSachDichVu();
            cmbTenDichVu.DisplayMember = "TenDichVu";
        }
    }
}