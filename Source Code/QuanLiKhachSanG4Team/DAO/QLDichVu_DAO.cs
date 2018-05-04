using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class QLDichVu_DAO
    {
        //Khoi tao bien ket noi
        static SqlConnection con;

        public static List<QLDichVu_DTO> LoadDanhSachDichVu()
        {
           
            //Khai bao truy van sql
            string sTruyVan = "select * from DICH_VU";
            //Mo ket noi
            con = DataProvider.KetNoi();
            //Tien hanh truy van
            DataTable dt = DataProvider.LayDataTable(sTruyVan, con);
            if(dt.Rows.Count==0)
            {
                return null;
            }

            //Tao list QLDichVu_DTO
            List<QLDichVu_DTO> lstdv = new List<QLDichVu_DTO>();
            for (int i=0;i<dt.Rows.Count;i++)
            {
                QLDichVu_DTO dv = new QLDichVu_DTO();
                dv.MaDichVu = dt.Rows[i]["MaDichVu"].ToString();
                dv.TenDichVu = dt.Rows[i]["TenDichVu"].ToString();
                dv.DonViTinh = dt.Rows[i]["DonViTinh"].ToString();
                dv.DonGia = decimal.Parse(dt.Rows[i]["DonGia"].ToString());
                lstdv.Add(dv);
            }
            return lstdv;
        }
    }
}
