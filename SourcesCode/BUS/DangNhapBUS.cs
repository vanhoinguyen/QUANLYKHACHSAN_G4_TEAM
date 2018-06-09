using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class DangNhapBUS
    {
        public static List<DangNhapDTO> LayThongTinNguoiDung()
        {
            return DangNhapDAO.LayThongTinNguoiDung();
        }
        public static int DemSoLuongTK()
        {
            return DangNhapDAO.DemSoLuongTK();
        }
    }
}
