using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class PhongDTO
    {
        public int? MaPhong { get; set; }
        public string TinhTrang { get; set; }
        public string MaLoaiPhong { get; set; }
        public string TenLoaiPhong { get; set; }
        public string GhiChu { get; set; }
        public decimal? DonGia { get; set; }
        public DateTime? NgayTraPhongDK { get; set; }
    }
}
