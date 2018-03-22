using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYKHACHSAN_G4_TEAM.DanhMucPhong
{
    public partial class fDanhMucPhong : Form
    {
        public fDanhMucPhong()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fThemPhong addRoom = new fThemPhong();
            addRoom.ShowDialog();
            
           
        }

       

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditRoom_Click(object sender, EventArgs e)
        {
            DanhMucPhong.fSuaPhong editRoom = new fSuaPhong();
            editRoom.ShowDialog();
        }
    }
}
