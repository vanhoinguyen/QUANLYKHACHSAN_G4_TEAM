using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuThuePhongDTO
    {
        public int? MaPhong { get; set; }
        public DateTime NgayThue { get; set; }
        public int? MaPT { get; set; }
        public int? MaCTPT { get; set; }
        public DateTime? NgayTraPhong { get; set; }
    }
}
