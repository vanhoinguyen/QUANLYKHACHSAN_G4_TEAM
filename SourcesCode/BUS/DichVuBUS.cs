using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DichVuBUS
    {
        public static List<DichVuDTO> LoadDanhSachDichVu()
        {
            return DichVuDAO.LoadDanhSachDichVu();
        }

        public static bool ThemDichVu()
        {
            return DichVuDAO.ThemDichVu();
        }
    }
}
