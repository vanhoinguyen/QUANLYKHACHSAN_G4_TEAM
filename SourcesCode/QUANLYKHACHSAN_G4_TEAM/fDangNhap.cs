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
using BUS;
using DTO;
using System.Security.Cryptography;

namespace QUANLYKHACHSAN_G4_TEAM
{
    public partial class fDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public fDangNhap()
        {
            InitializeComponent();
            
        }
        string TenTaiKhoan = "";
        string MatKhauTaiKhoan = "";
        int SLTK;
        
        
        List<DangNhapDTO> lst = new List<DangNhapDTO>();

        private void fDangNhap_Load(object sender, EventArgs e)
        {
            lst = DangNhapBUS.LayThongTinNguoiDung();
            SLTK = DangNhapBUS.DemSoLuongTK();
        }
        private void DangNhapHeThong(string TenTaiKhoan,string MatKhauTaiKhoan)
        {
            if (txtTenDangNhap.Text == TenTaiKhoan && txtPass.Text == MatKhauTaiKhoan)
            {
                ManHinhChinh f = new ManHinhChinh();
                f.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < SLTK; i++)
            {
                TenTaiKhoan = lst[i].TenDangNhap.TrimEnd();
                MatKhauTaiKhoan = lst[i].MatKhau.TrimEnd();
                DangNhapHeThong(TenTaiKhoan, MatKhauTaiKhoan);
            }

            

        }
    }
}