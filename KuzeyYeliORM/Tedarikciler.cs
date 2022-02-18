using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeliORM
{
    public class Tedarikciler
    {
        public static DataTable listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("Select * from Tedarikciler", Tools.Baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
    }
}
