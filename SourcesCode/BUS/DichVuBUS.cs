using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class DichVuBUS
    {
        public static List<DichVuDTO> LoadDanhSach()
        {
            return DichVuDAO.LoadDanhSach();
        }

        public static bool XoaDichVu(DichVuDTO infor)
        {
            return DichVuDAO.XoaDichVu(infor);
        }

        public static bool SuaThongTinDichVu(DichVuDTO infor)
        {
            return DichVuDAO.SuaThongTinDichVu(infor);
        }

        public static bool ThemDichVu(DichVuDTO infor)
        {
            return DichVuDAO.ThemDichVu(infor);
        }

        public static List<DichVuDTO> LayDonGia(int maDichVu)
        {
            return DichVuDAO.LayDonGia(maDichVu);
        }
    }
}
