using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class HoaDonBUS
    {
        public static List<HoaDonDTO> LoadMaPhong()
        {
            return HoaDonDAO.LoadDanhSach();
        }

        public static List<HoaDonDTO> LayThongTinPhongThue(HoaDonDTO infor)
        {
            return HoaDonDAO.LayThongTinPhongThue(infor);
        }

        public static bool TinhSoNgayDaThue(HoaDonDTO infor)
        {
            return HoaDonDAO.TinhSoNgayDaThue(infor);
        }

        public static List<HoaDonDTO> LaySoNgayDaThue()
        {
            return HoaDonDAO.LaySoNgayDaThue();
        }

        public static int LaySoLuongKhach(int maphieuthue)
        {
            return HoaDonDAO.LaySoLuongKhach(maphieuthue);
        }

        public static List<HoaDonDTO> LayKhachNuocNgoai()
        {
            return HoaDonDAO.LayKhachNuocNgoai();
        }

        public static List<HoaDonDTO> TinhPhuThu(int num)
        {
            return HoaDonDAO.TinhPhuThu(num);
        }

        public static int DemSoLuongKhachNuocNgoai(HoaDonDTO infor)
        {
            return HoaDonDAO.DemSoLuongKhachNuocNgoai(infor);
        }

        public static List<HoaDonDTO> TinhHeSo()
        {
            return HoaDonDAO.TinhHeSo();
        }
    }
}
