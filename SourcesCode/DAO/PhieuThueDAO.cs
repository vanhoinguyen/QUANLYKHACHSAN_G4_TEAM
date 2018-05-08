using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class PhieuThueDAO
    {
        static QUAN_LY_KHACH_SANEntities context = new QUAN_LY_KHACH_SANEntities();
        public static List<KhachHangDTO> LayMaKHKeTiep()
        {
            var query = (from k in context.KHACH_HANG
                         select new KhachHangDTO
                         {
                             MaKH = k.MaKhachHang,
                         }).OrderByDescending(x => x.MaKH).Take(1);
            return query.ToList();
        }

        public static List<PhieuThuePhongDTO> LayMaCTPTKeTiep()
        {
            var query = (from ctpt in context.CHI_TIET_PHIEU_THUE
                         select new PhieuThuePhongDTO
                         {
                             MaCTPT = ctpt.MaChiTietPT,
                         }).OrderByDescending(x => x.MaCTPT).Take(1);
            return query.ToList();
        }

        public static List<PhieuThuePhongDTO> LayPhongTuongUng(int makh)
        {
            var query = (from pt in context.PHIEU_THUE_PHONG
                         join ct in context.CHI_TIET_PHIEU_THUE on pt.MaPhieuThue equals ct.MaPhieuThue
                         where ct.MaKhachHang == makh
                         select new PhieuThuePhongDTO
                         {
                             MaPhong = pt.MaPhong,
                         });
            return query.ToList();
        }

        public static bool ThemCTPhieuThuePhong(ChiTietPhieuThueDTO ct, KhachHangDTO kh)
        {
            SqlParameter mactpt = new SqlParameter("@MaCTPT", ct.MaCTPT);
            SqlParameter makh = new SqlParameter("@MaKH", kh.MaKH);
            SqlParameter mapt = new SqlParameter("@MaPT", ct.MaPT);
            try
            {
                context.Database.ExecuteSqlCommand("spThemCTPhieuThue @MaCTPT, @MaKH, @MaPT", mactpt, makh, mapt);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool ThemPhieuThuePhong(ChiTietPhieuThueDTO ct, PhieuThuePhongDTO p)
        {
            SqlParameter mapt = new SqlParameter("@MaPT", ct.MaPT);
            SqlParameter ngaythue = new SqlParameter("@NgayThue", p.NgayThue);
            SqlParameter maphong = new SqlParameter("@MaPhong", p.MaPhong);
            SqlParameter ngaytraphong = new SqlParameter("@NgayTraPhong", p.NgayTraPhong);
            try
            {
                context.Database.ExecuteSqlCommand("spThemPhieuThue @MaPT , @NgayThue , @MaPhong , @NgayTraPhong", mapt, ngaythue, maphong, ngaytraphong);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static List<PhieuThuePhongDTO> LayMaPTKeTiep()
        {
            var query = (from pt in context.PHIEU_THUE_PHONG
                         select new PhieuThuePhongDTO
                         {
                             MaPT = pt.MaPhieuThue,
                         }).OrderByDescending(x => x.MaPT).Take(1);
            return query.ToList();
        }
    }
}