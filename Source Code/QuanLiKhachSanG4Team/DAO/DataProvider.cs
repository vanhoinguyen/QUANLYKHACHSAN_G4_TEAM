using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class DataProvider
    {
        //Ket Noi
        public static SqlConnection KetNoi()
        {
            string sChuoiKetNoi = @"Data Source=TeeMax;Initial Catalog=QLKS_DATA;Integrated Security=True";
            SqlConnection con = new SqlConnection(sChuoiKetNoi);
            con.Open();
            return con;              
        }

        public static void DongKetNoi(SqlConnection con)
        {
            con.Close();
        }

        //Lay DataTable 
        public static DataTable LayDataTable(string sTruyVan,SqlConnection con)
        {
            SqlDataAdapter da = new SqlDataAdapter(sTruyVan, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static bool ThucThiTruyVanNonQuery(string sTruyVan,SqlConnection con)
        {
            try
            {
                SqlCommand com = new SqlCommand(sTruyVan, con);
                com.ExecuteNonQuery();
                return true;
            }
         catch(Exception ex)
            {
                return false;
            }

        }

    }
}
