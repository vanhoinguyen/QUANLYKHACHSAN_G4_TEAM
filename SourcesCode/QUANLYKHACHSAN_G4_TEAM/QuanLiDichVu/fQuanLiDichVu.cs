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

namespace QUANLYKHACHSAN_G4_TEAM.QuanLiDichVu
{
    public partial class fQuanLiDichVu : DevExpress.XtraEditors.XtraForm
    {
        public fQuanLiDichVu()
        {
            InitializeComponent();
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {

        }

        public void fQuanLiDichVu_Load(object sender, EventArgs e)
        {
            dgvListService.DataSource= DichVuBUS.LoadDanhSachDichVu();
            txtNameService.DataBindings.Add(new Binding("Text", dgvListService.DataSource, "TenDichVu"));
            txtPriceService.DataBindings.Add(new Binding("Text", dgvListService.DataSource, "DonGia"));
            txtUnitService.DataBindings.Add(new Binding("Text", dgvListService.DataSource, "DonViTinh"));

        }
        private void ThietLapTextbox(bool flag)
        {
            txtNameService.Enabled = flag;
            txtPriceService.Enabled = flag;
            txtUnitService.Enabled = flag;
        }
       /* private void ThietLapButton(bool flag)
        {
            btnThem.Enabled = !flag;
            btnSua.Enabled = !flag;
            btnXoa.Enabled = !flag;

        }*/
        private void LamSachDL()
        {
            txtNameService.Text = "";
            txtPriceService.Text = "";
            txtUnitService.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            LamSachDL();
            
             DichVuBUS.ThemDichVu();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
    }
}