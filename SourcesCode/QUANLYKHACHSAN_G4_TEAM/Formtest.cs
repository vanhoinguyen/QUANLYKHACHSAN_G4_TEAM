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

namespace QUANLYKHACHSAN_G4_TEAM
{
    public partial class Formtest : Form
    {
        static DATA_QUAN_LY_KHACH_SANEntities context = new DATA_QUAN_LY_KHACH_SANEntities();

        List<PhongDTO> lstPhong = new List<PhongDTO>();
        public Formtest()
        {
            InitializeComponent();
        }

        private void ThietLapTextBox()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
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
                            imageList1.Images.Add(Image.FromFile(file.FullName));
                        }
                        catch
                        {
                            MessageBox.Show("khong tim thay file anh");
                        }
                    }
                }
            }


            for (int j = 0; j < this.imageList1.Images.Count; j++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = j;
                string a = Convert.ToString(j);
                item.Text = a;
                this.listView1.Items.Add(item);
            }
        }

        private void Formtest_Load(object sender, EventArgs e)
        {
            LayDanhSachPhongTrong();
           
           
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            lstPhong = PhongBUS.LayMaPhongLoaiPhong();
         
            textBox1.Text = lstPhong[int.Parse(listView1.SelectedItems[0].SubItems[0].Text)].MaPhong.ToString();
            textBox2.Text = lstPhong[int.Parse(listView1.SelectedItems[0].SubItems[0].Text)].TenLoaiPhong;
            textBox3.Text = lstPhong[int.Parse(listView1.SelectedItems[0].SubItems[0].Text)].GhiChu;
            textBox4.Text = lstPhong[int.Parse(listView1.SelectedItems[0].SubItems[0].Text)].DonGia.ToString();
            
        }


    }
}
