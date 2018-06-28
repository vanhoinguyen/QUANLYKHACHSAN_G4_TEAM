using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLiKhachSan
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();         
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Skins();
            pnHienThi.Controls.Clear();
            pnHienThi.Controls.Add(new UserControl.frmManHinhChinh());
        }

        public void Skins()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Summer 2008";
            
        }
        

        private void tabHienThi_Click(object sender, EventArgs e)
        {

        }

        private void btnQuanLiPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pnHienThi.Controls.Clear();
            pnHienThi.Controls.Add(new UserControl.frmQuanLiPhong());
        }

        private void btnQuanLiDichVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pnHienThi.Controls.Clear();
            pnHienThi.Controls.Add(new UserControl.frmQuanLiDichVu());
        }

        private void btnTimPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pnHienThi.Controls.Clear();
            pnHienThi.Controls.Add(new UserControl.frmTimPhong());
        }

        private void btnTimKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pnHienThi.Controls.Clear();
            pnHienThi.Controls.Add(new UserControl.frmTimKhachHang());
        }

        private void btnDoanhThu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pnHienThi.Controls.Clear();
            pnHienThi.Controls.Add(new UserControl.frmDoanhThu());
        }

        private void btnTraPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pnHienThi.Controls.Clear();
            pnHienThi.Controls.Add(new UserControl.frmTraPhong());
        }

        private void btnDatPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pnHienThi.Controls.Clear();
            pnHienThi.Controls.Add(new UserControl.frmDanhSachPhongTrong());
        }

        private void btnOder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UserControl.frmOderDichVu oder = new UserControl.frmOderDichVu();
            oder.ShowDialog();
        }

        private void btnThayDoiQuyDinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UserControl.frmQuyDinh quydinh = new UserControl.frmQuyDinh();
            quydinh.ShowDialog();
        }

        private void btnTroGiup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UserControl.frmTroGiup help = new UserControl.frmTroGiup();
            help.ShowDialog();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UserControl.frmTroGiup pn = new UserControl.frmTroGiup();
            pn.ShowDialog();
        }

        private void btnLogOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void barButtonItem3_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pnHienThi.Controls.Clear();
            pnHienThi.Controls.Add(new UserControl.frmManHinhChinh());
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pnHienThi.Controls.Clear();
            pnHienThi.Controls.Add(new UserControl.frmManHinhChinh());
        }
    }
}
