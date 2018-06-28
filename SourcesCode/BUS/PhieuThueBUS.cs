using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class PhieuThueBUS
    {
        public static List<KhachHangDTO> LayMaKHKeTiep()
        {
            return PhieuThueDAO.LayMaKHKeTiep();
        }

        public static List<PhieuThuePhongDTO> LayMaPTKeTiep()
        {
            return PhieuThueDAO.LayMaPTKeTiep();
        }

        public static List<PhieuThuePhongDTO> LayMaCTPTKeTiep()
        {
            return PhieuThueDAO.LayMaCTPTKeTiep();
        }

        public static bool ThemPhieuThuePhong(ChiTietPhieuThueDTO ct, PhieuThuePhongDTO p)
        {
            int i = DateTime.Compare(p.NgayThue, p.NgayTraPhong.Value);
            if (i <= 0)
                return PhieuThueDAO.ThemPhieuThuePhong(ct, p);
            return false;
        }

        public static bool ThemCTPhieuThuePhong(ChiTietPhieuThueDTO ct, KhachHangDTO kh)
        {
            return PhieuThueDAO.ThemCTPhieuThuePhong(ct, kh);
        }

        public static List<PhieuThuePhongDTO> LayPhongTuongUng(int makh)
        {
            return PhieuThueDAO.LayPhongTuongUng(makh);
        }
    }
}
