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
    public class QLPhong_DAO
    {
        

        static SqlConnection con;
        public static List<QLPhong_DTO> LoadDanhSachPhong()
        {
            string sTruyVan = "select * from PHONG AS p, LOAI_PHONG AS lp where p.MaLoaiPhong=lp.MaLoaiPhong";
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDataTable(sTruyVan, con);
            if(dt.Rows.Count==0)
            {
                return null;
            }
            List<QLPhong_DTO> lstPhong = new List<QLPhong_DTO>();
           
            for(int i=0;i<dt.Rows.Count;i++)
            {
                QLPhong_DTO p = new QLPhong_DTO();
                
                p.MaPhong = int.Parse(dt.Rows[i]["MaPhong"].ToString());
                p.TenPhong = dt.Rows[i]["TenPhong"].ToString();
                p.TenLoaiPhong = dt.Rows[i]["TenLoaiPhong"].ToString();
                p.TinhTrang = dt.Rows[i]["TinhTrang"].ToString();
                p.MaLoaiPhong = dt.Rows[i]["MaLoaiPhong"].ToString();
                p.GhiChu = dt.Rows[i]["GhiChu"].ToString();
                p.DonGia = decimal.Parse(dt.Rows[i]["DonGia"].ToString());

                lstPhong.Add(p);
                
                
            }
            return lstPhong;
          
        }
        public static bool ThemPhong(QLPhong_DTO phongDTO)
        {
            //tao cau truy van
            string sTruyVan = string.Format(@"insert into PHONG(MaPhong,TenPhong,MaLoaiPhong,GhiChu) values ({0},N'{1}',N'{2}',N'{3}'",phongDTO.MaPhong,phongDTO.TenPhong,phongDTO.MaLoaiPhong,phongDTO.GhiChu);
            con = DataProvider.KetNoi();//tao doi tuong ket noi
            try
            {
                DataProvider.ThucThiTruyVanNonQuery(sTruyVan,con);
                DataProvider.DongKetNoi(con);
                return true;
            }
            catch(Exception ex)
            {
                DataProvider.DongKetNoi(con);
                return false;
            }
            //Dong ket noi
            
            
        }
        


        }
}
