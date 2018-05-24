using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
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
                         group hd by p.MaLoaiPhong into g
                         select new BCDoanhThuDTO
                         {
                             MaLoaiPhong = g.Key,
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
                        group hd by p.MaLoaiPhong into g
                        select new BCDoanhThuDTO
                        {
                            MaLoaiPhong = g.Key,
                            TongDoanhThu = g.Sum(hd => hd.TriGia),
                        };
            return query.ToList();
        }
    }
}
