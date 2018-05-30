using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class OderDichVuBUS
    {
        public static List<OderDichVuDTO> LoadDanhSachMaPhong()
        {
            return OderDichVuDAO.LoadDanhSachMaPhong();
        }

        public static List<OderDichVuDTO>  LoadDanhSachDichVu()
        {
            return OderDichVuDAO.LoadDanhSachDichVu();
        }

        public static bool DangKiDichVu(OderDichVuDTO infor)
        {
            if (infor.SoLuong > 0)
                return OderDichVuDAO.DangKiDichVu(infor);
            else return false;
        }

        public static List<OderDichVuDTO> LayMaDichVuDangKi(string tendichvu)
        {
            return OderDichVuDAO.LayMaDichVuDangKi(tendichvu);
        }

        public static int LaySoLuongDichVuDK(int? maPhong)
        {
            return OderDichVuDAO.LaySoLuongDichVuDK(maPhong);
        }

        public static List<OderDichVuDTO> DanhSachDichVuDK(int? maPhong)
        {
            return OderDichVuDAO.DanhSachDichVuDK(maPhong);
        }

        public static bool XoaDichVuPhongDK(HoaDonDTO inforHD)
        {
            return OderDichVuDAO.XoaDichVuPhongDK(inforHD);
        }
    }
}
