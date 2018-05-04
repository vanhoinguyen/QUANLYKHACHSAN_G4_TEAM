using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QLPhong_DTO
    {
        private int _MaPhong;
        private string _TenPhong;
        private string _TinhTrang;
        private string _MaLoaiPhong;
        private string _GhiChu;
    
        private string _TenLoaiPhong;
        private decimal? _DonGia;

        public int MaPhong { get => _MaPhong; set => _MaPhong = value; }
        public string TenPhong { get => _TenPhong; set => _TenPhong = value; }
        public string TinhTrang { get => _TinhTrang; set => _TinhTrang = value; }
        public string MaLoaiPhong { get => _MaLoaiPhong; set => _MaLoaiPhong = value; }
        public string GhiChu { get => _GhiChu; set => _GhiChu = value; }
        public string TenLoaiPhong { get => _TenLoaiPhong; set => _TenLoaiPhong = value; }
        public decimal? DonGia { get => _DonGia; set => _DonGia = value; }
    }
}
