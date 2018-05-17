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
    }
}
