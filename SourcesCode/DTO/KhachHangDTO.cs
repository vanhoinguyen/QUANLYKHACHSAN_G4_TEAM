using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        public int? MaKH { get; set; }
        public string TenKhachHang { get; set; }
        public string DiaChi { get; set; }
        public string CMND { get; set; }
        public string LoaiKhach { get; set; }
        public string MaLoaiKhach { get; set; }
    }
}
