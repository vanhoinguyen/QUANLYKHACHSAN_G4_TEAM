using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAO
{
    public class KhachHangDAO
    {
        static QUAN_LY_KHACH_SANEntities context = new QUAN_LY_KHACH_SANEntities();


        public static List<KhachHangDTO> LayDSLoaiKhach()
        {
            var query = (from t in context.LOAI_KHACH_HANG
                         select new KhachHangDTO
                         {
                             MaLoaiKhach = t.MaLoaiKhach,
                             LoaiKhach = t.TenLoaiKhach,
                         });
            return query.ToList();
        }

        public static bool ThemKhachHang(KhachHangDTO kh)
        {
            SqlParameter makh = new SqlParameter("@MaKH", kh.MaKH);
            SqlParameter tenkh = new SqlParameter("@TenKH", kh.TenKhachHang);
            SqlParameter cmnd = new SqlParameter("@CMND", kh.CMND);
            SqlParameter diachi = new SqlParameter("@DiaChi", kh.DiaChi);
            SqlParameter malk = new SqlParameter("@MaLK", kh.MaLoaiKhach);
            try
            {
                context.Database.ExecuteSqlCommand("spThemKhachHang @MaKH, @TenKH, @CMND, @DiaChi, @MaLK", makh, tenkh, cmnd, diachi, malk);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}