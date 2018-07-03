using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

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

        public static bool DangKiDichVu(OderDichVuDTO infor)
        {
            SqlParameter MaDichVu = new SqlParameter("@MaDichVu", infor.MaDichVu);
            SqlParameter maphong = new SqlParameter("@MaPhong", infor.MaPhong);
            SqlParameter soluong = new SqlParameter("@SoLuong", infor.SoLuong);
            try
            {
                context.Database.ExecuteSqlCommand("spDangKiDichVu @MaDichVu, @MaPhong , @SoLuong", MaDichVu, maphong, soluong);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool XoaDichVuPhongDK(HoaDonDTO inforHD)
        {
            SqlParameter maphong = new SqlParameter("@MaPhong", inforHD.MaPhong);
            try
            {
                context.Database.ExecuteSqlCommand("spXoaDichVuPhongDK  @MaPhong ", maphong);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static List<OderDichVuDTO> DanhSachDichVuDK(int? maPhong)
        {
            var query = (from t in context.DANG_KI_DICH_VU
                         where t.MaPhong == maPhong
                         select new OderDichVuDTO
                         {
                             MaDichVu = t.MaDichVu,
                             SoLuong = t.SoLuong,
                         });
            return query.ToList();
        }

        public static int LaySoLuongDichVuDK(int? maPhong)
        {
            int num = (from t in context.DANG_KI_DICH_VU
                       where t.MaPhong == maPhong
                       select new OderDichVuDTO
                       { }).Count();
            return num;
        }

        public static List<OderDichVuDTO> LayMaDichVuDangKi(string tendichvu)
        {
            var query = (
                         from y in context.DICH_VU
                         where y.TenDichVu == tendichvu
                         select new OderDichVuDTO
                         {
                             MaDichVu = y.MaDichVu,
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
