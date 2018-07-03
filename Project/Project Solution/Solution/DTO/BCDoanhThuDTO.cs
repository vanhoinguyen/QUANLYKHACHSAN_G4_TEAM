using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BCDoanhThuDTO
    {
        //public string MaLoaiPhong { get; set; }
        public string TenLoaiPhong { get; set; }

        public decimal? TongDoanhThu { get; set; }
        public int? Thang { get; set; }
        public int? Nam { get; set; }
        //public int? MaBCDoanhThu { get; set; }
        //public int? MaCTBCDoanhThu { get; set; }
        public string TiLe { get; set; }
    }
}
