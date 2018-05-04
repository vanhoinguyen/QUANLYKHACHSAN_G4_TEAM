using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QLDichVu_DTO
    {
        private string _MaDichVu;
        private string _TenDichVu;
        private string _DonViTinh;
        private decimal? _DonGia;

        public string MaDichVu { get => _MaDichVu; set => _MaDichVu = value; }
        public string TenDichVu { get => _TenDichVu; set => _TenDichVu = value; }
        public string DonViTinh { get => _DonViTinh; set => _DonViTinh = value; }
        public decimal? DonGia { get => _DonGia; set => _DonGia = value; }
    }
}
