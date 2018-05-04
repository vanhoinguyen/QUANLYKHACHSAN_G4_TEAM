using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace QuanLiKhachSanG4Team
{
    public partial class frmQuanLiDichVu : Form
    {
        public frmQuanLiDichVu()
        {
            InitializeComponent();
        }

        private void LoadDataDanhSachDichVu()
        {
            List<QLDichVu_DTO> lstDichVu = QLDichVu_BUS.LoadDanhSachDichVu();
            dgvDanhSachDichVu.DataSource = lstDichVu;
        }

        private void frmQuanLiDichVu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLKS_DATADataSet.DICH_VU' table. You can move, or remove it, as needed.
            this.dICH_VUTableAdapter.Fill(this.qLKS_DATADataSet.DICH_VU);
            LoadDataDanhSachDichVu();
        }

        

       

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

      

        private void btnThuNho_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
