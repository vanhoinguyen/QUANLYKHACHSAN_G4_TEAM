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

        public static List<KhachHangDTO> DanhSachKhachHang()
        {
            var query = (from c in context.KHACH_HANG
                         join t in context.LOAI_KHACH_HANG on c.MaLoaiKhach equals t.MaLoaiKhach
                         select new KhachHangDTO
                         {
                             MaKH = c.MaKhachHang,
                             TenKhachHang = c.TenKhachHang,
                             CMND = c.CMND,
                             LoaiKhach = t.TenLoaiKhach,
                             DiaChi = c.DiaChi,
                         }).OrderBy(x => x.LoaiKhach);
            return query.ToList();
        }

        public static List<KhachHangDTO> DSKHTheoCMND(KhachHangDTO thongtin)
        {
            var query = (from kh in context.KHACH_HANG
                         join lk in context.LOAI_KHACH_HANG on kh.MaLoaiKhach equals lk.MaLoaiKhach
                         where kh.CMND.Contains(thongtin.CMND)
                         select new KhachHangDTO
                         {
                             MaKH = kh.MaKhachHang,
                             TenKhachHang = kh.TenKhachHang,
                             LoaiKhach = lk.TenLoaiKhach,
                             CMND = kh.CMND,
                             DiaChi = kh.DiaChi,
                         }).OrderBy(x => x.LoaiKhach);
            return query.ToList();
        }

        public static List<KhachHangDTO> DSKHTheoTenLoaiKhachCMND(KhachHangDTO thongtin)
        {
            var query = (from kh in context.KHACH_HANG
                         join lk in context.LOAI_KHACH_HANG on kh.MaLoaiKhach equals lk.MaLoaiKhach
                         where kh.CMND.Contains(thongtin.CMND) && kh.TenKhachHang.Contains(thongtin.TenKhachHang) && lk.TenLoaiKhach.Contains(thongtin.LoaiKhach)
                         select new KhachHangDTO
                         {
                             MaKH = kh.MaKhachHang,
                             TenKhachHang = kh.TenKhachHang,
                             LoaiKhach = lk.TenLoaiKhach,
                             CMND = kh.CMND,
                             DiaChi = kh.DiaChi,
                         }).OrderBy(x => x.LoaiKhach);
            return query.ToList();
        }

        public static bool XoaKhachHang(KhachHangDTO id)
        {
            SqlParameter makh = new SqlParameter("@MaKH", id.MaKH);
            try
            {
                context.Database.ExecuteSqlCommand("spXoaKhachHang @MaKH", makh);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static List<KhachHangDTO> LayMaKhachHangCanXoa(int? maphieuthue)
        {
            var query = (from kh in context.KHACH_HANG
                         join ct in context.CHI_TIET_PHIEU_THUE on kh.MaKhachHang equals ct.MaKhachHang
                         where ct.MaPhieuThue == maphieuthue
                         select new KhachHangDTO
                         {
                             MaKH = kh.MaKhachHang,
                         });
            return query.ToList();
        }

        public static List<KhachHangDTO> DSKHDiaChiCMND(KhachHangDTO thongtin)
        {
            var query = (from kh in context.KHACH_HANG
                         join lk in context.LOAI_KHACH_HANG on kh.MaLoaiKhach equals lk.MaLoaiKhach
                         where kh.CMND.Contains(thongtin.CMND) && kh.DiaChi.Contains(thongtin.DiaChi)
                         select new KhachHangDTO
                         {
                             MaKH = kh.MaKhachHang,
                             TenKhachHang = kh.TenKhachHang,
                             LoaiKhach = lk.TenLoaiKhach,
                             CMND = kh.CMND,
                             DiaChi = kh.DiaChi,
                         }).OrderBy(x => x.LoaiKhach);
            return query.ToList();
        }

        public static List<KhachHangDTO> DSKHDiaChiLoaiKhachCMND(KhachHangDTO thongtin)
        {
            var query = (from kh in context.KHACH_HANG
                         join lk in context.LOAI_KHACH_HANG on kh.MaLoaiKhach equals lk.MaLoaiKhach
                         where kh.CMND.Contains(thongtin.CMND) && kh.DiaChi.Contains(thongtin.DiaChi) && lk.TenLoaiKhach.Contains(thongtin.LoaiKhach)
                         select new KhachHangDTO
                         {
                             MaKH = kh.MaKhachHang,
                             TenKhachHang = kh.TenKhachHang,
                             LoaiKhach = lk.TenLoaiKhach,
                             CMND = kh.CMND,
                             DiaChi = kh.DiaChi,
                         }).OrderBy(x => x.LoaiKhach);
            return query.ToList();
        }

        public static List<KhachHangDTO> DSKHTheoLoaiKhachCMND(KhachHangDTO thongtin)
        {
            var query = (from kh in context.KHACH_HANG
                         join lk in context.LOAI_KHACH_HANG on kh.MaLoaiKhach equals lk.MaLoaiKhach
                         where kh.CMND.Contains(thongtin.CMND) && lk.TenLoaiKhach.Contains(thongtin.LoaiKhach)
                         select new KhachHangDTO
                         {
                             MaKH = kh.MaKhachHang,
                             TenKhachHang = kh.TenKhachHang,
                             LoaiKhach = lk.TenLoaiKhach,
                             CMND = kh.CMND,
                             DiaChi = kh.DiaChi,
                         }).OrderBy(x => x.LoaiKhach);
            return query.ToList();
        }

        public static List<KhachHangDTO> DSKHTheoTenCMND(KhachHangDTO thongtin)
        {
            var query = (from kh in context.KHACH_HANG
                         join lk in context.LOAI_KHACH_HANG on kh.MaLoaiKhach equals lk.MaLoaiKhach
                         where kh.CMND.Contains(thongtin.CMND) && kh.TenKhachHang.Contains(thongtin.TenKhachHang)
                         select new KhachHangDTO
                         {
                             MaKH = kh.MaKhachHang,
                             TenKhachHang = kh.TenKhachHang,
                             LoaiKhach = lk.TenLoaiKhach,
                             CMND = kh.CMND,
                             DiaChi = kh.DiaChi,
                         }).OrderBy(x => x.LoaiKhach);
            return query.ToList();
        }

        public static List<KhachHangDTO> DSKHTheoTenDiaChiCMND(KhachHangDTO thongtin)
        {
            var query = (from kh in context.KHACH_HANG
                         join lk in context.LOAI_KHACH_HANG on kh.MaLoaiKhach equals lk.MaLoaiKhach
                         where kh.CMND.Contains(thongtin.CMND) && kh.TenKhachHang.Contains(thongtin.TenKhachHang) && kh.DiaChi.Contains(thongtin.DiaChi)
                         select new KhachHangDTO
                         {
                             MaKH = kh.MaKhachHang,
                             TenKhachHang = kh.TenKhachHang,
                             LoaiKhach = lk.TenLoaiKhach,
                             CMND = kh.CMND,
                             DiaChi = kh.DiaChi,
                         }).OrderBy(x => x.LoaiKhach);
            return query.ToList();
        }

        public static List<KhachHangDTO> DSKHTheoTenDiaChiLoaiKhachCMND(KhachHangDTO thongtin)
        {
            var query = (from kh in context.KHACH_HANG
                         join lk in context.LOAI_KHACH_HANG on kh.MaLoaiKhach equals lk.MaLoaiKhach
                         where kh.CMND.Contains(thongtin.CMND) && kh.TenKhachHang.Contains(thongtin.TenKhachHang) && lk.TenLoaiKhach == thongtin.LoaiKhach && kh.DiaChi.Contains(thongtin.DiaChi)
                         select new KhachHangDTO
                         {
                             MaKH = kh.MaKhachHang,
                             TenKhachHang = kh.TenKhachHang,
                             LoaiKhach = lk.TenLoaiKhach,
                             CMND = kh.CMND,
                             DiaChi = kh.DiaChi,
                         }).OrderBy(x => x.LoaiKhach);
            return query.ToList();
        }

        public static List<KhachHangDTO> DSKHTheoTen(KhachHangDTO thongtin)
        {
            var query = (from kh in context.KHACH_HANG
                         join lk in context.LOAI_KHACH_HANG on kh.MaLoaiKhach equals lk.MaLoaiKhach
                         where kh.TenKhachHang.Contains(thongtin.TenKhachHang)
                         select new KhachHangDTO
                         {
                             MaKH = kh.MaKhachHang,
                             TenKhachHang = kh.TenKhachHang,
                             LoaiKhach = lk.TenLoaiKhach,
                             CMND = kh.CMND,
                             DiaChi = kh.DiaChi,
                         }).OrderBy(x => x.LoaiKhach);
            return query.ToList();
        }

        public static List<KhachHangDTO> DSKHTheoTenDiaChi(KhachHangDTO thongtin)
        {
            var query = (from kh in context.KHACH_HANG
                         join lk in context.LOAI_KHACH_HANG on kh.MaLoaiKhach equals lk.MaLoaiKhach
                         where kh.TenKhachHang.Contains(thongtin.TenKhachHang) && kh.DiaChi.Contains(thongtin.DiaChi)
                         select new KhachHangDTO
                         {
                             MaKH = kh.MaKhachHang,
                             TenKhachHang = kh.TenKhachHang,
                             LoaiKhach = lk.TenLoaiKhach,
                             CMND = kh.CMND,
                             DiaChi = kh.DiaChi,
                         }).OrderBy(x => x.LoaiKhach);
            return query.ToList();
        }

        public static List<KhachHangDTO> DSKHTheoTenLoaiKhach(KhachHangDTO thongtin)
        {
            var query = (from kh in context.KHACH_HANG
                         join lk in context.LOAI_KHACH_HANG on kh.MaLoaiKhach equals lk.MaLoaiKhach
                         where kh.TenKhachHang.Contains(thongtin.TenKhachHang) && lk.TenLoaiKhach == thongtin.LoaiKhach
                         select new KhachHangDTO
                         {
                             MaKH = kh.MaKhachHang,
                             TenKhachHang = kh.TenKhachHang,
                             LoaiKhach = lk.TenLoaiKhach,
                             CMND = kh.CMND,
                             DiaChi = kh.DiaChi,
                         }).OrderBy(x => x.LoaiKhach);
            return query.ToList();
        }

        public static List<KhachHangDTO> DSKHTheoTenDiaChiLoaiKhach(KhachHangDTO thongtin)
        {
            var query = (from kh in context.KHACH_HANG
                         join lk in context.LOAI_KHACH_HANG on kh.MaLoaiKhach equals lk.MaLoaiKhach
                         where kh.TenKhachHang.Contains(thongtin.TenKhachHang) && lk.TenLoaiKhach == thongtin.LoaiKhach && kh.DiaChi.Contains(thongtin.DiaChi)
                         select new KhachHangDTO
                         {
                             MaKH = kh.MaKhachHang,
                             TenKhachHang = kh.TenKhachHang,
                             LoaiKhach = lk.TenLoaiKhach,
                             CMND = kh.CMND,
                             DiaChi = kh.DiaChi,
                         }).OrderBy(x => x.LoaiKhach);
            return query.ToList();
        }

        public static List<KhachHangDTO> DSKHTheoLoaiKhach(KhachHangDTO thongtin)
        {
            var query = (from kh in context.KHACH_HANG
                         join lk in context.LOAI_KHACH_HANG on kh.MaLoaiKhach equals lk.MaLoaiKhach
                         where lk.TenLoaiKhach == thongtin.LoaiKhach
                         select new KhachHangDTO
                         {
                             MaKH = kh.MaKhachHang,
                             TenKhachHang = kh.TenKhachHang,
                             LoaiKhach = lk.TenLoaiKhach,
                             CMND = kh.CMND,
                             DiaChi = kh.DiaChi,
                         }).OrderBy(x => x.LoaiKhach);
            return query.ToList();
        }

        public static List<KhachHangDTO> DSKHTheoLoaiKhachDiaChi(KhachHangDTO thongtin)
        {
            var query = (from kh in context.KHACH_HANG
                         join lk in context.LOAI_KHACH_HANG on kh.MaLoaiKhach equals lk.MaLoaiKhach
                         where lk.TenLoaiKhach == thongtin.LoaiKhach && kh.DiaChi.Contains(thongtin.DiaChi)
                         select new KhachHangDTO
                         {
                             MaKH = kh.MaKhachHang,
                             TenKhachHang = kh.TenKhachHang,
                             LoaiKhach = lk.TenLoaiKhach,
                             CMND = kh.CMND,
                             DiaChi = kh.DiaChi,
                         }).OrderBy(x => x.LoaiKhach);
            return query.ToList();
        }

        public static List<KhachHangDTO> DSKHTheoDiaChi(KhachHangDTO thongtin)
        {
            var query = (from kh in context.KHACH_HANG
                         join lk in context.LOAI_KHACH_HANG on kh.MaLoaiKhach equals lk.MaLoaiKhach
                         where kh.DiaChi.Contains(thongtin.DiaChi)
                         select new KhachHangDTO
                         {
                             MaKH = kh.MaKhachHang,
                             TenKhachHang = kh.TenKhachHang,
                             LoaiKhach = lk.TenLoaiKhach,
                             CMND = kh.CMND,
                             DiaChi = kh.DiaChi,
                         }).OrderBy(x => x.LoaiKhach);
            return query.ToList();
        }

        public static List<KhachHangDTO> DSKHTheoPhong(PhongDTO thongtin)
        {
            var query = (from lk in context.LOAI_KHACH_HANG
                         join kh in context.KHACH_HANG on lk.MaLoaiKhach equals kh.MaLoaiKhach
                         join ct in context.CHI_TIET_PHIEU_THUE on kh.MaKhachHang equals ct.MaKhachHang
                         join pt in context.PHIEU_THUE_PHONG on ct.MaPhieuThue equals pt.MaPhieuThue
                         where pt.MaPhong == thongtin.MaPhong
                         select new KhachHangDTO
                         {
                             MaKH = kh.MaKhachHang,
                             TenKhachHang = kh.TenKhachHang,
                             LoaiKhach = lk.TenLoaiKhach,
                             CMND = kh.CMND,
                             DiaChi = kh.DiaChi,
                         });
            return query.ToList();
        }
    }
}