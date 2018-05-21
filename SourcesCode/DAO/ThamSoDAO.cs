using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public static bool CapNhatTSPhuThu(ThamSoDTO infor)
        {
            SqlParameter phuthu = new SqlParameter("@PhuThu",infor.PhuThu);
            try
            {
                context.Database.ExecuteSqlCommand("spCapNhatTSPhuThu @PhuThu", phuthu);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static List<ThamSoDTO> LayThongTinTS()
        {
            var query = (from t in context.THAM_SO
                         select new ThamSoDTO
                         {
                             SLKhachToiDa = t.SoKhachToiDa,
                             HeSo = t.HeSo,
                             PhuThu = t.PhuThu
                         });
            return query.ToList();
        }

        public static bool CapNhatTSHeSo(ThamSoDTO infor)
        {
            SqlParameter heso = new SqlParameter("@HeSo", infor.HeSo);
            try
            {
                context.Database.ExecuteSqlCommand("spCapNhatTSHeSo @HeSo", heso);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool CapNhatTSSoKhachToiDa(ThamSoDTO infor)
        {
            SqlParameter toida = new SqlParameter("@SoKhachToiDa",infor.SLKhachToiDa);
            try
            {
                context.Database.ExecuteSqlCommand("spCapNhatTSSoKhachToiDa @SoKhachToiDa", toida);
                return true;
            }
            catch
            {
                return false;
            }
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
