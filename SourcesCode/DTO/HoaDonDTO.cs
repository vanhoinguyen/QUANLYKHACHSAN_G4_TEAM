using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
        public int? MaHoaDon { get; set; }
        public int? MaPhong { get; set; }
        public DateTime? NgayBatDauThue { get; set; }
        public decimal? DonGia { get; set; }
        public int? SoNgayDaThue { get; set; }
        public int? MaPhieuThue { get; set; }
        public double? PhuThu { get; set; }
        public double? HeSo { get; set; }
        public int? KhachPTThu { get; set; }
        public int? SLKhachNG { get; set; }
        public string TenKhachHang { get; set; }
        public string DiaChi { get; set; }
        public decimal PhiDichVu { get; set; }
        public decimal? TongTien { get; set; }
        public decimal? ThanhTien { get; set; }
        public DateTime NgayThanhToan { get; set; }
    }
}
