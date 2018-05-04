using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class LoaiPhong_BUS
    {
        public static List<LoaiPhong_DTO> LoadDanhSachLoaiPhong()
        {
            return LoaiPhong_DAO.LoadDanhSachLoaiPhong();
        }
    }
}
