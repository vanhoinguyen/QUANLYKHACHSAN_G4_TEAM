using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DTO;
using BUS;
namespace QuanLiKhachSan.UserControl
{
    public partial class frmDoanhThu : DevExpress.XtraEditors.XtraUserControl
    {
        public frmDoanhThu()
        {
            InitializeComponent();
        }
        List<BCDoanhThuDTO> lst = new List<BCDoanhThuDTO>();
        private void btnXem_Click(object sender, EventArgs e)
        {
            BCDoanhThuDTO infor = new BCDoanhThuDTO();
            List<BCDoanhThuDTO> dlst = new List<BCDoanhThuDTO>();
            if (txtNam.Text == "" && cmbThang.Text == "")
            {
                decimal sum = 0;
                lst = BaoCaoBUS.TinhTongDoanhThuTheoLoaiPhong();
                for (int i = 0; i < lst.Count; i++)
                {
                    lst[i].TongDoanhThu = Convert.ToDecimal(string.Format("{0:0,0}", lst[i].TongDoanhThu));
                }
                gridControl1.DataSource = lst;
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    sum += lst[i].TongDoanhThu.Value;
                }
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    decimal cd = (lst[i].TongDoanhThu.Value * 100) / sum;
                    cd = Math.Round(cd, 2);
                    lst[i].TiLe = (cd).ToString() + "%";


                }
                //btnLuu.Enabled = false;
                txtTongTien.Text = string.Format("{0:0,0 VNĐ}", sum);

            }

            else if (txtNam.Text != "" && cmbThang.Text != "")
            {
                decimal sum = 0;
                infor.Thang = Convert.ToInt32(cmbThang.Text);
                infor.Nam = Convert.ToInt32(txtNam.Text);
                /*try
                {
                    dlst = BaoCaoBUS.LayMaBCDoanhThuKeTiep();
                    infor.MaBCDoanhThu = dlst[0].MaBCDoanhThu + 1;
                    dlst = BaoCaoBUS.LayMaBCCTDoanhThuKeTiep();
                    infor.MaCTBCDoanhThu = dlst[0].MaCTBCDoanhThu + 1;
                }
                catch
                {
                    infor.MaBCDoanhThu = 1;
                    infor.MaCTBCDoanhThu = 1;
                }*/
                lst = BaoCaoBUS.DoanhThuTheoLoaiPhongTheoThang(infor);
                for (int i = 0; i < lst.Count; i++)
                {
                    lst[i].TongDoanhThu = Convert.ToDecimal(string.Format("{0:0,0}", lst[i].TongDoanhThu));
                }
                gridControl1.DataSource = lst;
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    sum += lst[i].TongDoanhThu.Value;
                }
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    decimal cd = (lst[i].TongDoanhThu.Value * 100) / sum;
                    cd = Math.Round(cd, 2);
                    lst[i].TiLe = (cd).ToString() + "%";
                    lst[i].Thang = Convert.ToInt32(cmbThang.Text);
                    lst[i].Nam = Convert.ToInt32(txtNam.Text);
                    //lst[i].MaBCDoanhThu = infor.MaBCDoanhThu;
                    //lst[i].MaCTBCDoanhThu = infor.MaCTBCDoanhThu;

                }
                txtTongTien.Text = string.Format("{0:0,0 VNĐ}", sum);
                //btnLuu.Enabled = true;
            }
        }

        /*private void btnLuu_Click(object sender, EventArgs e)
        {

            bool success = true;
            List<BCDoanhThuDTO> dlst = new List<BCDoanhThuDTO>();
            BCDoanhThuDTO infor = new BCDoanhThuDTO();
            try
            {
                dlst = BaoCaoBUS.LayMaBCDoanhThuKeTiep();
                infor.MaBCDoanhThu = dlst[0].MaBCDoanhThu + 1;
                dlst = BaoCaoBUS.LayMaBCCTDoanhThuKeTiep();
                infor.MaCTBCDoanhThu = dlst[0].MaCTBCDoanhThu + 1;
            }
            catch
            {
                infor.MaBCDoanhThu = 1;
                infor.MaCTBCDoanhThu = 1;
            }

            infor.Thang = int.Parse(cmbThang.Text);
            /*if (BaoCaoBUS.ThemBaoCaoDoanhThu(infor) == true)
                MessageBox.Show("1");
            else
                MessageBox.Show("2");
            if (BaoCaoBUS.ThemBaoCaoDoanhThu(infor))
            {
                int n = lst.Count();
                for (int i = 0; i < n; i++)
                {
                    infor.TenLoaiPhong = lst[i].TenLoaiPhong;
                    infor.TongDoanhThu = lst[i].TongDoanhThu;
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
                    //btnLuu.Enabled = false;
                }
            }

            else
            {
                MessageBox.Show("Không thêm được báo cáo doanh thu cho tháng " + infor.Thang + "", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                int n = lst.Count();
                for (int i = 0; i < n; i++)
                {
                    infor.TenLoaiPhong = lst[i].TenLoaiPhong;
                    infor.TongDoanhThu = lst[i].TongDoanhThu;
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
            }*/
        }
    }
