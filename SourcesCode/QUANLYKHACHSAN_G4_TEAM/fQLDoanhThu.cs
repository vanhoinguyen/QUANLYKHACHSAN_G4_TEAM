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

namespace QUANLYKHACHSAN_G4_TEAM.DoanhThu
{
    public partial class fQLDoanhThu : DevExpress.XtraEditors.XtraForm
    {
        public fQLDoanhThu()
        {
            InitializeComponent();
        }

        private void fQLDoanhThu_Load(object sender, EventArgs e)
        {
            rbtTatCa.Checked = true;
        }

        List<BCDoanhThuDTO> lst = new List<BCDoanhThuDTO>();
        private void btnXem_Click(object sender, EventArgs e)
        {
            decimal s = 0;
            if (rbtTatCa.Checked == true)
            {
                try
                {
                    lst = BaoCaoBUS.DoanhThuTheoLoaiPhong();
                    decimal sum = 0;
                    for (int i = 0; i < lst.Count; i++)
                    {
                        sum = sum + lst[i].Sum.Value;
                    }

                    for (int i = 0; i < lst.Count - 1; i++)
                    {
                        decimal per = (lst[i].Sum.Value * 100) / sum;
                        per = Math.Round(per, 2);
                        s = s + per;
                        lst[i].TiLe = (per).ToString() + "%";
                    }
                    s = 100 - s;
                    lst[lst.Count - 1].TiLe = (s).ToString() + "%";
                    BCDoanhThuDTOBindingSource.DataSource = lst;

                    btnLuu.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Dữ liệu hiện tại không có", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (rbtTheoThang.Checked == true)
            {
                BCDoanhThuDTO infor = new BCDoanhThuDTO();
                infor.Thang = dtpDTThang.Value.Month;
                infor.Nam = dtpDTThang.Value.Year;
                lst = BaoCaoBUS.DoanhThuTheoLoaiPhongTheoThang(infor);
                if (lst.Count > 0)
                {
                    s = 0;
                    decimal sum = 0;
                    for (int i = 0; i < lst.Count; i++)
                    {
                        sum = sum + lst[i].Sum.Value;
                    }

                    for (int i = 0; i < lst.Count - 1; i++)
                    {
                        decimal per = (lst[i].Sum.Value * 100) / sum;
                        per = Math.Round(per, 2);
                        s = s + per;
                        lst[i].TiLe = (per).ToString() + "%";
                    }
                    s = 100 - s;
                    lst[lst.Count - 1].TiLe = (s).ToString() + "%";

                    btnLuu.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Dữ liệu báo cáo cho tháng " + infor.Thang + " năm " + infor.Nam + " hiện không có", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                BCDoanhThuDTOBindingSource.DataSource = lst;
            }
            this.reportViewerDoanhThu.RefreshReport();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool success = true;
            List<BCDoanhThuDTO> dtlst = new List<BCDoanhThuDTO>();
            BCDoanhThuDTO infor = new BCDoanhThuDTO();
            try
            {
                dtlst = BaoCaoBUS.LayMaBCDoanhThuKeTiep();
                infor.MaBCDoanhThu = (dtlst[0].MaBCDoanhThu + 1);
                dtlst = BaoCaoBUS.LayMaCTBCDoanhThuKeTiep();
                infor.MaCTBCDoanhThu = (dtlst[0].MaCTBCDoanhThu + 1);
            }
            catch
            {
                infor.MaBCDoanhThu = 1;
                infor.MaCTBCDoanhThu = 1;
            }
            infor.Thang = dtpDTThang.Value.Month;
            if (BaoCaoBUS.ThemBaoCaoDoanhThu(infor))
            {
                int n = lst.Count();
                for (int i = 0; i < n; i++)
                {
                    infor.Name = lst[i].Name;
                    infor.Sum = lst[i].Sum;
                    infor.TiLe = lst[i].TiLe;
                    if (!(BaoCaoBUS.ThemCTBaoCaoDoanhThu(infor)))
                    {
                        success = false;
                        MessageBox.Show("Không thêm được chi tiết báo cáo doanh thu cho tháng " + infor.Thang + "", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (success == true)
                {
                    MessageBox.Show("Lưu dữ liệu báo cáo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLuu.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Không thêm được báo cáo doanh thu cho tháng " + infor.Thang + "", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}