using BUS;
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYKHACHSAN_G4_TEAM.DatPhong;

namespace QUANLYKHACHSAN_G4_TEAM.DatPhong
{
    public partial class fPhong : Form
    {
        List<PhongDTO> lstPhong = new List<PhongDTO>();
        public fPhong()
        {
            InitializeComponent();
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            fDatPhong.room = txtMaPhong.Text;
            fDatPhong.roomtype = txtLoaiPhong.Text;

            fDatPhong _frm = new fDatPhong();
            _frm.Show();

            lvPhong.Enabled = false;

            ThietLapTextBox();
            btnDatPhong.Enabled = false;
        }

        private void ThietLapTextBox()
        {
            txtMaPhong.Text = "";
            txtLoaiPhong.Text = "";
            txtThongTin.Text = "";
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
                        try
                        {
                            imgListRoom.Images.Add(Image.FromFile(file.FullName));
                        }
                        catch
                        {
                            MessageBox.Show("khong tim thay file anh");
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

        private void fPhong_Load(object sender, EventArgs e)
        {
            LayDanhSachPhongTrong();
        }

        private void lvPhong_Click(object sender, EventArgs e)
        {
            lstPhong = new List<PhongDTO>();
            lstPhong = PhongBUS.LayMaPhongLoaiPhong();
            txtMaPhong.Text = lstPhong[int.Parse(lvPhong.SelectedItems[0].SubItems[0].Text)].MaPhong.ToString();
            txtLoaiPhong.Text = lstPhong[int.Parse(lvPhong.SelectedItems[0].SubItems[0].Text)].TenLoaiPhong;
            txtThongTin.Text = lstPhong[int.Parse(lvPhong.SelectedItems[0].SubItems[0].Text)].GhiChu;
            txtDonGia.Text = lstPhong[int.Parse(lvPhong.SelectedItems[0].SubItems[0].Text)].DonGia.ToString();
        }

        private void txtMaPhong_TextChanged(object sender, EventArgs e)
        {
            if (txtMaPhong.Text != "")
            {
                btnDatPhong.Enabled = true;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            lvPhong.Items.Clear();
            imgListRoom.Images.Clear();
            LayDanhSachPhongTrong();
            lvPhong.Enabled = true;
        }
    }
}
