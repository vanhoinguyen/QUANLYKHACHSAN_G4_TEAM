using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
namespace DAO
{
    public class BaoCaoDAO
    {
        static QUAN_LY_KHACH_SANEntities context = new QUAN_LY_KHACH_SANEntities();

        public static List<BCDoanhThuDTO> TinhTongDoanhThuTheoLoaiPhong()
        {
            var query = (from p in context.PHONGs
                         join cthd in context.CHI_TIET_HOA_DON on p.MaPhong equals cthd.MaPhong
                         join hd in context.HOA_DON on cthd.MaHoaDon equals hd.MaHoaDon
                         group hd by p.LOAI_PHONG.TenLoaiPhong into g
                         select new BCDoanhThuDTO
                         {
                             TenLoaiPhong = g.Key,
                           
                             TongDoanhThu = g.Sum(hd => hd.TriGia),
                         });
            return query.ToList();
        }

        public static List<BCDoanhThuDTO> DoanhThuTheoLoaiPhongTheoThang(DateTime ntm_min, DateTime ntm_max)
        {
            var query = from p in context.PHONGs
                        join ct in context.CHI_TIET_HOA_DON on p.MaPhong equals ct.MaPhong
                        join hd in context.HOA_DON on ct.MaHoaDon equals hd.MaHoaDon
                        where ct.NgayThanhToan >= ntm_min && ct.NgayThanhToan <= ntm_max
                        group hd by p.LOAI_PHONG.TenLoaiPhong into g
                        select new BCDoanhThuDTO
                        {
                            TenLoaiPhong = g.Key,
                            TongDoanhThu = g.Sum(hd => hd.TriGia),
                        };
            return query.ToList();
        }

        /*public static List<BCDoanhThuDTO> LayMaBCDoanhThuKeTiep()
        {
            var query = (from t in context.BAOCAO_DOANHTHUTHEOLOAIPHONG
                         select new BCDoanhThuDTO
                         {

                             MaBCDoanhThu = t.MaBCDoanhThu,
                         }).OrderByDescending(x => x.MaBCDoanhThu).Take(1);
            return query.ToList();

        }

        public static List<BCDoanhThuDTO> LayMaBCCTDoanhThuKeTiep()
        {
            var query = (from t in context.CHITIET_BAOCAODOANHTHU
                         select new BCDoanhThuDTO
                         {

                             MaCTBCDoanhThu = t.MaBCCTDoanhThu,
                         }).OrderByDescending(x => x.MaCTBCDoanhThu).Take(1);
            return query.ToList();
        }

        public static bool ThemBaoCaoDoanhThu(BCDoanhThuDTO infor)
        {
            SqlParameter mabc = new SqlParameter("@MaBCDoanhThu", infor.MaBCDoanhThu);
            SqlParameter thang = new SqlParameter("@Thang", infor.Thang);
            try
            {
                context.Database.ExecuteSqlCommand("spThemBCDoanhThuTheoLoaiPhongTheoThang @MaBCDoanhThu, @Thang", mabc, thang);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool ThemCTBaoCaoDoanhThu(BCDoanhThuDTO infor)
        {
            SqlParameter mabcct = new SqlParameter("@MaBCCTDoanhThu", infor.MaCTBCDoanhThu);
            SqlParameter malp = new SqlParameter("@TenLoaiPhong", infor.TenLoaiPhong);
            SqlParameter mabc = new SqlParameter("@MaBCDoanhThu", infor.MaBCDoanhThu);
            SqlParameter dt = new SqlParameter("@DoanhThu", infor.TongDoanhThu);
            SqlParameter tl = new SqlParameter("@TiLe", infor.TiLe);

            try
            {
                context.Database.ExecuteSqlCommand("spThemBCCTDTTheoLoaiPhongTheoThang @MaBCCTDoanhThu, @TenLoaiPhong, @MaBCDoanhThu, @DoanhThu, @TiLe",
                                mabcct, malp, mabc, dt, tl);
                return true;
            }
            catch
            {
                return false;
            }
        }*/
    }
}
