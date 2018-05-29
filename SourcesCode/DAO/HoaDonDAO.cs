using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    
    public class HoaDonDAO
    {
        static QUAN_LY_KHACH_SANEntities context = new QUAN_LY_KHACH_SANEntities();


        public static List<HoaDonDTO> LoadDanhSach()
        {
            var query = (from p in context.PHIEU_THUE_PHONG
                         select new HoaDonDTO
                         {
                             MaPhong = p.MaPhong,
                         });
            return query.ToList();
        }

        public static List<HoaDonDTO> LayThongTinPhongThue(HoaDonDTO infor)
        {
            var query = (from pt in context.PHIEU_THUE_PHONG
                         join p in context.PHONGs on pt.MaPhong equals p.MaPhong
                         join lp in context.LOAI_PHONG on p.MaLoaiPhong equals lp.MaLoaiPhong
                         join ctpt in context.CHI_TIET_PHIEU_THUE on pt.MaPhieuThue equals ctpt.MaPhieuThue
                         join kh in context.KHACH_HANG on ctpt.MaKhachHang equals kh.MaKhachHang
                        
                         where pt.MaPhong == infor.MaPhong
                         select new HoaDonDTO
                         {
                             NgayBatDauThue = pt.NgayBatDauThue,
                             MaPhong = pt.MaPhong,
                             MaPhieuThue = pt.MaPhieuThue,
                             TenKhachHang = kh.TenKhachHang,
                             DiaChi = kh.DiaChi,
                             DonGia = lp.DonGia,
                             //PhiDichVu = 

                         });
            return query.ToList();
        }

        public static object LayMaPhongDaThue()
        {
            var query = (from p in context.PHIEU_THUE_PHONG
                         select new HoaDonDTO
                         {
                             MaPhong = p.MaPhong,
                         });
            return query.ToList();
        }

        public static int? LayMaHDCuoiCung()
        {
            int num = (from t in context.HOA_DON
                       select new HoaDonDTO
                       {
                       }).Count();
            return num;
        }

        public static List<HoaDonDTO> LayMaPhieuThue(int maphong)
        {
            var query = (from t in context.PHIEU_THUE_PHONG
                         where t.MaPhong == maphong
                         select new HoaDonDTO
                         {
                             MaPhieuThue = t.MaPhieuThue
                         });
            return query.ToList();
        }

        public static bool XoaChiTietPhieuThue(HoaDonDTO inforHD)
        {
            SqlParameter maphieuthue = new SqlParameter("@MaPT", inforHD.MaPhieuThue);
            
            try
            {
                context.Database.ExecuteSqlCommand("spXoaCTPhieuThue @MaPT", maphieuthue);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool XoaPhieuThue(HoaDonDTO inforHD)
        {
            SqlParameter maphieuthue = new SqlParameter("@MaPT", inforHD.MaPhieuThue);

            try
            {
                context.Database.ExecuteSqlCommand("spXoaPhieuThue @MaPT", maphieuthue);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool LapChiTietHoaDon(HoaDonDTO infor, HoaDonDTO inforHD)
        {
            SqlParameter mahoadon = new SqlParameter("@MaHD", infor.MaHoaDon);
            SqlParameter songaythue = new SqlParameter("@SoNgayThue", inforHD.SoNgayDaThue);
            SqlParameter dongia = new SqlParameter("@DonGia", inforHD.DonGia);
            SqlParameter thanhtien = new SqlParameter("@ThanhTien", inforHD.ThanhTien);
            
            SqlParameter ngaythanhtoan = new SqlParameter("@NgayThanhToan", inforHD.NgayThanhToan);
            SqlParameter maphong = new SqlParameter("@MaPhong", inforHD.MaPhong);
            try
            {
                context.Database.ExecuteSqlCommand("spThemChiTietHD @MaHD , @SoNgayThue , @DonGia , @ThanhTien , @NgayThanhToan , @MaPhong", mahoadon, songaythue, dongia, thanhtien, ngaythanhtoan,maphong);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool LapHoaDon(HoaDonDTO infor)
        {
            SqlParameter mahoadon = new SqlParameter("@MaHD", infor.MaHoaDon);
            SqlParameter tenkh = new SqlParameter("@MaKH", infor.TenKhachHang);
            SqlParameter trigia = new SqlParameter("@TriGia", infor.TongTien);
            try
            {
                context.Database.ExecuteSqlCommand("spThemHoaDon @MaHD, @MaKH, @TriGia", mahoadon, tenkh, trigia);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static List<HoaDonDTO> TinhHeSo()
        {
            var query = (from t in context.THAM_SO
                         select new HoaDonDTO
                         {
                             HeSo= t.HeSo,
                         });
            return query.ToList();
        }

        public static bool TinhSoNgayDaThue(HoaDonDTO infor)
        {
            SqlParameter ngaythue = new SqlParameter("@NgayBDThue", infor.NgayBatDauThue);
            try
            {
                context.Database.ExecuteSqlCommand("spTruNgayThangNam @NgayBDThue", ngaythue);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static int DemSoLuongKhachNuocNgoai(HoaDonDTO infor)
        {
            int num = (from pt in context.PHIEU_THUE_PHONG
                         join ctpt in context.CHI_TIET_PHIEU_THUE on pt.MaPhieuThue equals ctpt.MaPhieuThue
                         join kh in context.KHACH_HANG on ctpt.MaKhachHang equals kh.MaKhachHang
                         where pt.MaPhong == infor.MaPhong && kh.MaLoaiKhach == "LK002"
                         select new HoaDonDTO
                         {

                         }).Count();
            return num;

        }

        public static List<HoaDonDTO> LaySoNgayDaThue()
        {
            var query = (from t in context.THAM_SO
                         select new HoaDonDTO
                         {
                             SoNgayDaThue = t.SoNgayThue,
                         });
            return query.ToList();
        }

        public static List<HoaDonDTO> TinhPhuThu(int num)
        {
            var query = (from t in context.THAM_SO
                         select new HoaDonDTO
                         {
                            PhuThu = t.PhuThu,
                         });
            return query.ToList();
        }

        public static int LaySoLuongKhach(int maphieuthue)
        {
            int num = (from pt in context.PHIEU_THUE_PHONG
                       join ct in context.CHI_TIET_PHIEU_THUE on pt.MaPhieuThue equals ct.MaPhieuThue
                       where ct.MaPhieuThue == maphieuthue
                       select new HoaDonDTO
                       {

                       }).Count();
            return num;
        }

        public static List<HoaDonDTO> LayKhachNuocNgoai()
        {
            var query = (from t in context.THAM_SO
                         select new HoaDonDTO
                         {
                             KhachPTThu = t.PhuThuKhachThu,
                             SLKhachNG = t.SLKhachNuocNgoai,
                         });
            return query.ToList();
        }
    }
}
