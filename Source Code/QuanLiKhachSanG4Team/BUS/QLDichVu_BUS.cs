using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class QLDichVu_BUS
    {
            public static List<QLDichVu_DTO> LoadDanhSachDichVu()
        {
            return QLDichVu_DAO.LoadDanhSachDichVu();
        }
    }
}
