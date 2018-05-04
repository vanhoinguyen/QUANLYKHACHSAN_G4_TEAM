using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class QLPhong_BUS
    {
        public static List<QLPhong_DTO> LoadDanhSachPhong()
        {
            return QLPhong_DAO.LoadDanhSachPhong();
        }
        //Them Phong
        public static bool ThemPhong(QLPhong_DTO phongDTO)
        {
            return QLPhong_DAO.ThemPhong(phongDTO);
        }
    }
}
