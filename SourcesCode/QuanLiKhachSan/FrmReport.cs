using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace QuanLiKhachSan
{
    public partial class FrmReport : Form
    {
        QLKSEntities1 db = new QLKSEntities1();
        public static int  dt ;
        public FrmReport()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
            

        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            CrystalReport1 rpt = new CrystalReport1();


            
            var query = (from t in db.CHI_TIET_HOA_DON
                         join q in db.HOA_DON on t.MaHoaDon equals q.MaHoaDon
                         where t.MaHoaDon == dt 
                         select new InHoaDonDTO
                         {
                             MaHoaDon = t.MaHoaDon,
                             SoNgayThue = t.SoNgayThue,
                             ThanhTien = t.ThanhTien,
                             MaPhong = t.MaPhong,
                             TenKhachHang = q.TenKhachHang,
                             DonGia = t.DonGia,
                             
                         }


            );
            /*var query = (from t in db.CHI_TIET_HOA_DON
                             join q in db.HOA_DON on t.MaHoaDon equals q.MaHoaDon
                         where t.MaHoaDon == dt
                         select new InHoaDonDTO
                         {
                             MaHoaDon = t.MaHoaDon,
                             SoNgayThue = t.SoNgayThue,
                             ThanhTien = t.ThanhTien,
                             MaPhong = t.MaPhong,
                             TenKhachHang = q.TenKhachHang,
                             DonGia = t.DonGia,

                         }


            );*/
            rpt.SetDataSource(query);
            
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Show();
        }
    }
}
