using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class KhachHangBUS
    {
        public static List<KhachHangDTO> LayDSLoaiKhach()
        {
            return KhachHangDAO.LayDSLoaiKhach();
        }

        public static bool ThemKhachHang(KhachHangDTO kh)
        {
            return KhachHangDAO.ThemKhachHang(kh);
        }

        public static List<KhachHangDTO> DanhSachKhachHang()
        {
            return KhachHangDAO.DanhSachKhachHang();
        }

        public static List<KhachHangDTO> DSKHTheoTen(KhachHangDTO thongtin)
        {
            return KhachHangDAO.DSKHTheoTen(thongtin);
        }

        public static List<KhachHangDTO> DSKHTheoTenDiaChi(KhachHangDTO thongtin)
        {
            return KhachHangDAO.DSKHTheoTenDiaChi(thongtin);
        }

        public static List<KhachHangDTO> DSKHTheoTenLoaiKhach(KhachHangDTO thongtin)
        {
            return KhachHangDAO.DSKHTheoTenLoaiKhach(thongtin);
        }

        public static List<KhachHangDTO> DSKHTheoTenDiaChiLoaiKhach(KhachHangDTO thongtin)
        {
            return KhachHangDAO.DSKHTheoTenDiaChiLoaiKhach(thongtin);
        }

        public static List<KhachHangDTO> DSKHTheoLoaiKhach(KhachHangDTO thongtin)
        {
            return KhachHangDAO.DSKHTheoLoaiKhach(thongtin);
        }

        public static List<KhachHangDTO> DSKHTheoLoaiKhachDiaChi(KhachHangDTO thongtin)
        {
            return KhachHangDAO.DSKHTheoLoaiKhachDiaChi(thongtin);
        }

        public static List<KhachHangDTO> DSKHTheoDiaChi(KhachHangDTO thongtin)
        {
            return KhachHangDAO.DSKHTheoDiaChi(thongtin);
        }

        public static List<KhachHangDTO> DSKHTheoPhong(PhongDTO thongtin)
        {
            return KhachHangDAO.DSKHTheoPhong(thongtin);
        }

        public static List<KhachHangDTO> DSKHTheoCMND(KhachHangDTO thongtin)
        {
            return KhachHangDAO.DSKHTheoCMND(thongtin);
        }

        public static List<KhachHangDTO> DSKHTheoTenDiaChiLoaiKhachCMND(KhachHangDTO thongtin)
        {
            return KhachHangDAO.DSKHTheoTenDiaChiLoaiKhachCMND(thongtin);
        }

        public static List<KhachHangDTO> DSKHTheoTenDiaChiCMND(KhachHangDTO thongtin)
        {
            return KhachHangDAO.DSKHTheoTenDiaChiCMND(thongtin);
        }

        public static List<KhachHangDTO> DSKHTheoTenCMND(KhachHangDTO thongtin)
        {
            return KhachHangDAO.DSKHTheoTenCMND(thongtin);
        }

        public static List<KhachHangDTO> DSKHTheoTenLoaiKhachCMND(KhachHangDTO thongtin)
        {
            return KhachHangDAO.DSKHTheoTenLoaiKhachCMND(thongtin);
        }

        public static List<KhachHangDTO> DSKHLoaiKhachCMND(KhachHangDTO thongtin)
        {
            return KhachHangDAO.DSKHTheoLoaiKhachCMND(thongtin);
        }

        public static List<KhachHangDTO> DSKHDiaChiLoaiKhachCMND(KhachHangDTO thongtin)
        {
            return KhachHangDAO.DSKHDiaChiLoaiKhachCMND(thongtin);
        }

        public static List<KhachHangDTO> DSKHDiaChiCMND(KhachHangDTO thongtin)
        {
            return KhachHangDAO.DSKHDiaChiCMND(thongtin);
        }

        public static List<KhachHangDTO> LayMaKhachHangCanXoa(int? maphieuthue)
        {
            return KhachHangDAO.LayMaKhachHangCanXoa(maphieuthue);
        }

        public static bool XoaKhachHang(KhachHangDTO id)
        {
            return KhachHangDAO.XoaKhachHang(id);
        }
    }
}
