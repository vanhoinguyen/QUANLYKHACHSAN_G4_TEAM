using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class ThamSoDAO
    {
        static QUAN_LY_KHACH_SANEntities context = new QUAN_LY_KHACH_SANEntities();

        public static List<ThamSoDTO> LoadSoLuongKhach()
        {
            var query = (from ts in context.THAM_SO
                         select new ThamSoDTO
                         {
                             SLKhachToiDa = ts.SoKhachToiDa,
                         });
            return query.ToList(); 
        }

        public static List<ThamSoDTO> LoadPhuThu()
        {
            var query = (from ts in context.THAM_SO
                         select new ThamSoDTO
                         {
                             PhuThu = ts.PhuThu,
                         });
            return query.ToList();
        }

        public static List<ThamSoDTO> LoadHeSo()
        {
            var query = (from ts in context.THAM_SO
                         select new ThamSoDTO
                         {
                             HeSo = ts.HeSo,
                         });
            return query.ToList();
        }
    }
}
