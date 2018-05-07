using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DichVuDAO
    {
        static QUAN_LY_KHACH_SANEntities context = new QUAN_LY_KHACH_SANEntities();

        public static List<DichVuDTO> LoadDanhSachDichVu()
        {
            var query = (from t in context.DICH_VU
                         select new DichVuDTO
                         {
                             MaDichVu = t.MaDichVu,
                             TenDichVu= t.TenDichVu,
                             DonGia = t.DonGia,
                             DonViTinh = t.DonViTinh
                         });
                         return query.ToList();
        }

        public static bool ThemDichVu()
        {
            return false;
        }
    }
}
