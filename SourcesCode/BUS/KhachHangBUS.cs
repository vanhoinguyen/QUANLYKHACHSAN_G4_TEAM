using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KhachHangBUS
    {
        public static List<KhachHangDTO> LayDSLoaiKhach()
        {
            return KhachHangDAO.LayDSLoaiKhach();
        }

        public static bool ThemKhachHang(KhachHangDTO kh)
        {
            return KhachHangDAO.ThemKhachHang(kh);
        }
    }
}