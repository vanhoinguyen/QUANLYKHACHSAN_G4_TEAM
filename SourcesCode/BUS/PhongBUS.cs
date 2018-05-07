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

        public static List<PhongDTO> LoaiPhong()
        {
            return PhongDAO.LoaiPhong();
        }

        public static List<PhongDTO> DanhSachPhong()
        {
            return PhongDAO.DanhSachPhong();
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
    }
}
