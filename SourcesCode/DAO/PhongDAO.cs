using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class PhongDAO
    {
        static QUAN_LY_KHACH_SANEntities context = new QUAN_LY_KHACH_SANEntities();

        //111111111111111111111
        public static List<PhongDTO> LayMaPhongLoaiPhong()
        {
            var query = (from r in context.PHONGs
                         join t in context.LOAI_PHONG on r.LOAI_PHONG.MaLoaiPhong equals t.MaLoaiPhong
                         where r.TinhTrang == "Trống"
                         select new PhongDTO
                         {
                             MaPhong = r.MaPhong,
                             TenLoaiPhong = r.LOAI_PHONG.TenLoaiPhong,
                             GhiChu = r.GhiChu,
                             DonGia = r.LOAI_PHONG.DonGia,
                         }).OrderBy(r => r.TenLoaiPhong);
            return query.ToList();
        }


        //22222222222
        public static int LaySLPhongTrongTheoLoai(string lp)
        {
            int num = (from r in context.PHONGs
                       join t in context.LOAI_PHONG on r.LOAI_PHONG.MaLoaiPhong equals t.MaLoaiPhong
                       where r.LOAI_PHONG.MaLoaiPhong == lp && r.TinhTrang == "Trống"
                       select new PhongDTO
                       {
                       }).Count();
            return num;
        }

        public static bool SuaThongTinPhong(PhongDTO infor)
        {
            SqlParameter maphong = new SqlParameter("@MaPhong", infor.MaPhong);
            SqlParameter tinhtrang = new SqlParameter("@TinhTrang", infor.TinhTrang);
            SqlParameter malp = new SqlParameter("@MaLoaiPhong", infor.MaLoaiPhong);
            SqlParameter ghichu = new SqlParameter("@GhiChu", infor.GhiChu);

            try
            {
                context.Database.ExecuteSqlCommand("spSuaThongTinPhong @MaPhong, @TinhTrang, @MaLoaiPhong, @GhiChu",
                                    maphong, tinhtrang, malp, ghichu);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool XoaPhong(PhongDTO infor)
        {
            SqlParameter maphong = new SqlParameter("@MaPhong", infor.MaPhong);
            try
            {
                context.Database.ExecuteSqlCommand("spXoaPhong @MaPhong", maphong);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool ThemPhong(PhongDTO infor)
        {
            SqlParameter tinhtrang = new SqlParameter("@TinhTrang", infor.TinhTrang);
            SqlParameter malp = new SqlParameter("@MaLoaiPhong", infor.MaLoaiPhong);
            SqlParameter ghichu = new SqlParameter("@GhiChu", infor.GhiChu);

            try
            {
                context.Database.ExecuteSqlCommand("spThemPhong @TinhTrang, @MaLoaiPhong, @GhiChu",
                                    tinhtrang, malp, ghichu);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static List<PhongDTO> DanhSachPhong()
        {
            var query = (from r in context.PHONGs
                         join t in context.LOAI_PHONG on r.LOAI_PHONG.MaLoaiPhong equals t.MaLoaiPhong
                         select new PhongDTO
                         {
                             MaPhong = r.MaPhong,
                             TinhTrang = r.TinhTrang,
                             GhiChu = r.GhiChu,
                             TenLoaiPhong = r.LOAI_PHONG.TenLoaiPhong,
                             DonGia = r.LOAI_PHONG.DonGia,
                         }).OrderByDescending(s => s.TinhTrang);
            return query.ToList();
        }

        public static List<PhongDTO> LoaiPhong()
        {
            var query = (from t in context.LOAI_PHONG
                         select new PhongDTO
                         {
                             MaLoaiPhong = t.MaLoaiPhong,
                             TenLoaiPhong = t.TenLoaiPhong,
                         });
            return query.ToList();
        }

        //333333333333333333333
        public static List<PhongDTO> LayDanhSachLoaiPhong()
        {
            var query = (from t in context.LOAI_PHONG
                         select new PhongDTO
                         {
                             MaLoaiPhong = t.MaLoaiPhong,
                         });
            return query.ToList();
        }

        public static bool CapNhatTinhTrangPhong(PhieuThuePhongDTO p)
        {
            SqlParameter maphong = new SqlParameter("@MaPhong", p.MaPhong);
            try
            {
                context.Database.ExecuteSqlCommand("spCapNhatTinhTrangPhong @MaPhong", maphong);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static List<ThamSoDTO> SoLuongKhachToiDa()
        {
            var query = (from max in context.THAM_SO
                         select new ThamSoDTO
                         {
                             SLKhachToiDa = max.SoKhachToiDa,
                         });
            return query.ToList();
        }
    }
}

