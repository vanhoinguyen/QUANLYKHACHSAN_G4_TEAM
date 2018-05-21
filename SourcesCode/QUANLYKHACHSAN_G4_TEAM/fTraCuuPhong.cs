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

namespace QUANLYKHACHSAN_G4_TEAM.TraCuuPhong
{
    public partial class fTraCuuPhong : DevExpress.XtraEditors.XtraForm
    {
        public fTraCuuPhong()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}