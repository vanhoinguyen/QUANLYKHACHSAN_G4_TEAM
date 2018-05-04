using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
namespace DAO
{
    public class LoaiPhong_DAO
    {
        static SqlConnection con;
        public static List<LoaiPhong_DTO> LoadDanhSachLoaiPhong()
        {
            string sTruyVan = "select * from LOAI_PHONG";
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDataTable(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<LoaiPhong_DTO> lstLoaiPhong = new List<LoaiPhong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LoaiPhong_DTO p = new LoaiPhong_DTO();
                p.MaLoaiPhong = dt.Rows[i]["MaLoaiPhong"].ToString();
                p.TenLoaiPhong = dt.Rows[i]["TenLoaiPhong"].ToString();
                p.DonGia =decimal.Parse( dt.Rows[i]["DonGia"].ToString());
                lstLoaiPhong.Add(p);
            }
            return lstLoaiPhong;
        }
    }
}
