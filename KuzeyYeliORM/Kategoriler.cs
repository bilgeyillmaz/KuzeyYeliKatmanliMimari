using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace KuzeyYeliORM
{
   public class Kategoriler
    {
        //Kategori tablosu için select,insert,update ve delete işlemi yapar.
        public static DataTable listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("Select * from Kategoriler", Tools.Baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
    }
}
