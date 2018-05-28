using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class ThamSoBUS
    {
        public static List<ThamSoDTO> LoadSoLuongKhach()
        {
            return ThamSoDAO.LoadSoLuongKhach();
        }

        public static List<ThamSoDTO> LoadHeSo()
        {
            return ThamSoDAO.LoadHeSo();
        }

        public static List<ThamSoDTO> LoadPhuThu()
        {
            return ThamSoDAO.LoadPhuThu();
        }

        public static bool CapNhatTSSoKhachToiDa(ThamSoDTO infor)
        {
            return ThamSoDAO.CapNhatTSSoKhachToiDa(infor);
        }

        public static bool CapNhatTSHeSo(ThamSoDTO infor)
        {
            return ThamSoDAO.CapNhatTSHeSo(infor);
        }

        public static bool CapNhatTSPhuThu(ThamSoDTO infor)
        {
            return ThamSoDAO.CapNhatTSPhuThu(infor);
        }

        public static List<ThamSoDTO> LayThongTinTS()
        {
            return ThamSoDAO.LayThongTinTS();
        }

        public static List<ThamSoDTO> LoadDonGia(string text)
        {
            return ThamSoDAO.LoadDonGia(text);
        }

        public static bool CapNhatTSDonGia(ThamSoDTO ts,string t)
        {
            if (ts.DonGia <= 0)
                return false;
            return ThamSoDAO.CapNhatTSDonGia(ts,t);
        }
    }
}
