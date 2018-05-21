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

        public static object LayMaPhongDaThue()
        {
            return HoaDonDAO.LayMaPhongDaThue();
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

        /*public static decimal ThanhTien(int snt, decimal dg, decimal pt, decimal hs , decimal pdv)
        {
            decimal thanhtien = 0;
            if(snt == 0)
            {
                return (thanhtien = dg + pdv);
            }
            else
            {
                thanhtien = dg * snt;
                thanhtien = thanhtien + dg * pt + pdv;
                if(hs != 0)
                {
                    thanhtien *= hs;
                    return thanhtien;
                }
                else
                {
                    return thanhtien;
                }
            }
        }*/
        public static decimal ThanhTien(int snt, decimal dg, decimal pt, decimal hs)
        {
            decimal thanhtien = 0;
            if (snt == 0)
            {
                return (thanhtien = dg );
            }
            else
            {
                thanhtien = dg * snt;
                thanhtien = thanhtien + dg * pt ;
                if (hs != 0)
                {
                    thanhtien *= hs;
                    return thanhtien;
                }
                else
                {
                    return thanhtien;
                }
            }
        }

        public static int? LayMaHDCuoiCung()
        {
            return HoaDonDAO.LayMaHDCuoiCung();
        }

        public static bool LapHoaDon(HoaDonDTO infor)
        {
            return HoaDonDAO.LapHoaDon(infor);
        }

        public static List<HoaDonDTO> LayMaPhieuThue(int maphong)
        {
            return HoaDonDAO.LayMaPhieuThue(maphong);
        }

        public static bool LapChiTietHoaDon(HoaDonDTO infor, HoaDonDTO inforHD)
        {
            return HoaDonDAO.LapChiTietHoaDon(infor, inforHD);
        }

        public static bool XoaChiTietPhieuThue(HoaDonDTO inforHD)
        {
            return HoaDonDAO.XoaChiTietPhieuThue(inforHD);
        }

        public static bool XoaPhieuThue(HoaDonDTO inforHD)
        {
            return HoaDonDAO.XoaPhieuThue( inforHD);
        }

        
    }
}
