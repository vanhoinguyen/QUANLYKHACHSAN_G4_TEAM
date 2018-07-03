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
using BUS;
using DTO;
using System.IO;

namespace QuanLiKhachSan.UserControl
{
    public partial class frmDanhSachPhongTrong : DevExpress.XtraEditors.XtraUserControl
    {

        List<PhongDTO> lstPhong = new List<PhongDTO>();
        public frmDanhSachPhongTrong()
        {
            InitializeComponent();
            if (txtMaPhong.Text == "")
                btnDatPhong.Enabled = false;
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            frmPhieuThuePhong.room = txtMaPhong.Text;
            frmPhieuThuePhong.roomtype = txtLoaiPhong.Text;
            UserControl.frmPhieuThuePhong tp = new frmPhieuThuePhong();
            tp.ShowDialog();
            lvPhong.Enabled = false;

            ThietLapTextBox();
            btnDatPhong.Enabled = false;
        }
        private void ThietLapTextBox()
        {
            txtMaPhong.Text = "";
            txtLoaiPhong.Text = "";
            txtGhiChu.Text = "";
            txtDonGia.Text = "";
        }

        private void LayDanhSachPhongTrong()
        {
            List<PhongDTO> danhmuclst = new List<PhongDTO>();
            danhmuclst = PhongBUS.LayDanhSachLoaiPhong();
            for (int i = 0; i < danhmuclst.Count; i++)
            {
                string lp = danhmuclst[i].MaLoaiPhong;
                int num = PhongBUS.LaySLPhongTrongTheoLoai(lp);
                DirectoryInfo dir;
                dir = new DirectoryInfo(@"..\..\ICON\" + lp);
                for (int j = 1; j <= num; j++)
                {
                    foreach (FileInfo file in dir.GetFiles())
                    {
                        //imgListRoom.Images.Add(Image.FromFile(file.FullName));
                        try
                        {
                            imgListRoom.Images.Add(Image.FromFile(file.FullName));
                        }
                        catch
                        {
                        }
                    }
                }
            }


            for (int j = 0; j < this.imgListRoom.Images.Count; j++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = j;
                string a = Convert.ToString(j);
                item.Text = a;
                this.lvPhong.Items.Add(item);
            }
           
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            lvPhong.Items.Clear();
            imgListRoom.Images.Clear();
            LayDanhSachPhongTrong();
            lvPhong.Enabled = true;
        }

        private void frmDanhSachPhongTrong_Load(object sender, EventArgs e)
        {
            LayDanhSachPhongTrong();
        }

        

        private void txtMaPhong_TextChanged(object sender, EventArgs e)
        {
            if (txtMaPhong.Text != "")
            {
                btnDatPhong.Enabled = true;
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            lstPhong = new List<PhongDTO>();
            lstPhong = PhongBUS.LayMaPhongLoaiPhong();
            txtMaPhong.Text = lstPhong[int.Parse(lvPhong.SelectedItems[0].SubItems[0].Text)].MaPhong.ToString();
            txtLoaiPhong.Text = lstPhong[int.Parse(lvPhong.SelectedItems[0].SubItems[0].Text)].TenLoaiPhong;
            txtGhiChu.Text = lstPhong[int.Parse(lvPhong.SelectedItems[0].SubItems[0].Text)].GhiChu;
            txtDonGia.Text = string.Format("{0:0,0}", lstPhong[int.Parse(lvPhong.SelectedItems[0].SubItems[0].Text)].DonGia);
        }
    }
}
