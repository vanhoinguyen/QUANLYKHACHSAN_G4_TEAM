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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnOder_Click(object sender, EventArgs e)
        {
            fOderDichVu oder = new fOderDichVu();
            oder.Show();
        }
    }
}