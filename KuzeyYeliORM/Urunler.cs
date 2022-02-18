using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using KuzeyYeliEntity;

namespace KuzeyYeliORM
{
    public class Urunler
    {
       public static DataTable listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select*from Urunler", Tools.Baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        //select,insert,update,delete işlemleri yapılacak Urun tablosu için
        public static bool Ekle(Urun u)
        {
            SqlCommand komut = new SqlCommand("UrunEkle", Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@ad", u.UrunAdi);
            komut.Parameters.AddWithValue("@fiyat", u.Fiyat);
            komut.Parameters.AddWithValue("@stok", u.Stok);
            komut.Parameters.AddWithValue("@tedarikciID", u.TedarikciID);
            komut.Parameters.AddWithValue("@kategoriID", u.KategoriID);
            Tools.Baglanti.Open();
            int sonuc=komut.ExecuteNonQuery();
            Tools.Baglanti.Close();
            if (sonuc > 0)
                return true;
            else return false;
        }
    }
    
}
