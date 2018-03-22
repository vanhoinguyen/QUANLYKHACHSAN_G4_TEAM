using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYKHACHSAN_G4_TEAM.DichVu
{
    public partial class fDichVu : Form
    {
        public fDichVu()
        {
            InitializeComponent();
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            DichVu.fThemDichVu addService = new fThemDichVu();
            addService.ShowDialog();
        }

        private void btnEditService_Click(object sender, EventArgs e)
        {
            DichVu.fSuaDichVu editService = new fSuaDichVu();
            editService.ShowDialog();
        }

        private void btnExitService_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
