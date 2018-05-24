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
using DTO;
using BUS;

namespace QUANLYKHACHSAN_G4_TEAM.DoanhThu
{
    public partial class fQLDoanhThu : DevExpress.XtraEditors.XtraForm
    {
        public fQLDoanhThu()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            List<BCDoanhThuDTO> lst = new List<BCDoanhThuDTO>();
            BCDoanhThuDTO infor = new BCDoanhThuDTO();
            if(txtNam.Text == "" && cmbThang.Text == "")
            {
                decimal sum = 0;
                lst = BaoCaoBUS.TinhTongDoanhThuTheoLoaiPhong();
                dgvDoanhThu.DataSource = lst;
                for( int i =0; i< dgvDoanhThu.RowCount;i++)
                {
                    sum += lst[i].TongDoanhThu.Value;
                }
                for(int i =0;i<dgvDoanhThu.RowCount;i++)
                {
                    decimal cd = (lst[i].TongDoanhThu.Value * 100) / sum;
                    cd = Math.Round ( cd , 2 );
                    lst[i].TiLe = (cd).ToString() + "%";


                }

            }
            else if(txtNam.Text != "" && cmbThang.Text != "")
            {
                decimal sum = 0;
                infor.Thang = Convert.ToInt32(txtNam.Text);
                infor.Nam = Convert.ToInt32(cmbThang.Text);
                lst = BaoCaoBUS.DoanhThuTheoLoaiPhongTheoThang(infor);
                dgvDoanhThu.DataSource = lst;
                for (int i = 0; i < dgvDoanhThu.RowCount; i++)
                {
                    sum += lst[i].TongDoanhThu.Value;
                }
                for (int i = 0; i < dgvDoanhThu.RowCount; i++)
                {
                    decimal cd = (lst[i].TongDoanhThu.Value * 100) / sum;
                    cd = Math.Round(cd, 2);
                    lst[i].TiLe = (cd).ToString() + "%";


                }
            }
        }
    }
}