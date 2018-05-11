using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class OderDichVuDAO
    {
        static QUAN_LY_KHACH_SANEntities context = new QUAN_LY_KHACH_SANEntities();

        public static List<OderDichVuDTO> LoadDanhSachMaPhong()
        {
            var query = (from t in context.PHONGs
                         where t.TinhTrang == "Đầy"
                         select new OderDichVuDTO
                         {
                             MaPhong = t.MaPhong,
                         });
            return query.ToList();

        }

        public static List<OderDichVuDTO> LoadDanhSachDichVu()
        {
            var query = (from t in context.DICH_VU
                        
                         select new OderDichVuDTO
                         {
                             TenDichVu = t.TenDichVu,
                         });
            return query.ToList();
        }
    }
}
