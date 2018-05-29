using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhongBUS
    {
        //11111111111111
        public static List<PhongDTO> LayMaPhongLoaiPhong()
        {
            return PhongDAO.LayMaPhongLoaiPhong();
        }

        //2222222222222222222222222
        public static List<PhongDTO> LayDanhSachLoaiPhong()
        {
            return PhongDAO.LayDanhSachLoaiPhong();
        }

        //33333333333333
        public static int LaySLPhongTrongTheoLoai(string lp)
        {
            return PhongDAO.LaySLPhongTrongTheoLoai(lp);
        }

        public static List<ThamSoDTO> SoLuongKhachToiDa()
        {
            return PhongDAO.SoLuongKhachToiDa();
        }

        public static bool CapNhatTinhTrangPhong(PhieuThuePhongDTO p)
        {
            return PhongDAO.CapNhatTinhTrangPhong(p);
        }

        public static List<PhongDTO> DanhSachPhongTK()
        {
            return PhongDAO.DanhSachPhongTK();
        }

        public static List<PhongDTO> LoaiPhong()
        {
            return PhongDAO.LoaiPhong();
        }

        public static List<PhieuThuePhongDTO> DanhSachPhongDangDuocThue()
        {
            return PhongDAO.DanhSachPhongDangDuocThue();
        }

        public static List<PhongDTO> DanhSachPhong()
        {
            return PhongDAO.DanhSachPhong();
        }

        public static List<ThamSoDTO> LoadDonGia(string text)
        {
            throw new NotImplementedException();
        }

        public static bool ThemPhong(PhongDTO infor)
        {
            return PhongDAO.ThemPhong(infor);
        }

        public static bool SuaThongTinPhong(PhongDTO infor)
        {
            return PhongDAO.SuaThongTinPhong(infor);
        }

        public static bool XoaPhong(PhongDTO infor)
        {
            return PhongDAO.XoaPhong(infor);
        }

        public static bool ThietLapTrangThaiPhongBanDau(HoaDonDTO inforHD)
        {
            return PhongDAO.ThietLapTrangThaiPhongBanDau(inforHD);
        }

        public static List<PhongDTO> DanhSachPhongTheoLoai(PhongDTO thongtin)
        {
            return PhongDAO.DanhSachPhongTheoLoai(thongtin);
        }

        public static List<PhongDTO> DanhSachPhongYeuCau(PhongDTO thongtin)
        {
            return PhongDAO.DanhSachPhongYeuCau(thongtin);
        }

        public static List<PhongDTO> DanhSachPhongTheoLoaiTheoYeuCau(PhongDTO thongtin)
        {
            return PhongDAO.DanhSachPhongTheoLoaiTheoYeuCau(thongtin);
        }

        public static List<PhongDTO> DanhSachPhongTheoDGTu(decimal dgtu)
        {
            return PhongDAO.DanhSachPhongTheoDGTu(dgtu);
        }

        public static List<PhongDTO> DanhSachPhongTheoKhoangDG(decimal dgtu, decimal dgden)
        {
            return PhongDAO.DanhSachPhongTheoKhoangDG(dgtu, dgden);
        }

        public static List<PhongDTO> DanhSachPhongTheoDGDen(decimal dgden)
        {
            return PhongDAO.DanhSachPhongTheoDGDen(dgden);
        }

        public static List<PhieuThuePhongDTO> NgayTraPhong()
        {
            return PhongDAO.NgayTraPhong();
        }

        public static object DanhSachPhongTraGanNhat()
        {
            return PhongDAO.DanhSachPhongTraGanNhat();
        }
    }
}
