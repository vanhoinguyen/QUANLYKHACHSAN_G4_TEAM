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
    }
}
