using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiPhong_DTO
    {
        private string _MaLoaiPhong;
        private string _TenLoaiPhong;
        private decimal? _DonGia;

        public string MaLoaiPhong { get => _MaLoaiPhong; set => _MaLoaiPhong = value; }
        public string TenLoaiPhong { get => _TenLoaiPhong; set => _TenLoaiPhong = value; }
        public decimal? DonGia { get => _DonGia; set => _DonGia = value; }
    }
}
