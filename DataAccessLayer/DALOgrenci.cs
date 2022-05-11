using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Sİstem Kütüphaneleri
using System.Data;
using System.Data.SqlClient;
using EnityLayer;

namespace DataAccessLayer
{
    public class DALOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci ent)
        {
            /*
              DataAccessLayer katmanında temel CRUD işlemleri gerçekleştirilir eklenecek tablodan bir nesne türetip parametrelere o nesne yardımıyla veriler çekilir             
            */
            SqlCommand komut = new SqlCommand("insert into TBL_OGRENCILER (OGRAD,OGRSOYAD,OGRNUMARA,OGRMAIL,OGRSIFRE) values (@p1,@p2,@p3,@p4,@p5)", Baglanti.bgl);
            if (komut.Connection.State !=ConnectionState.Open)
            {
                // bağlantı açık değilse açmak için kullanılır
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1",ent.Ad);
            komut.Parameters.AddWithValue("@p2",ent.Soyad);
            komut.Parameters.AddWithValue("@p3",ent.Numara);
            komut.Parameters.AddWithValue("@p4",ent.Mail);
            komut.Parameters.AddWithValue("@p5",ent.Sifre);           
            return komut.ExecuteNonQuery();
            
        }
        public static List<EntityOgrenci> ÖgrenciListesi()
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut = new SqlCommand("Select * from TBL_OGRENCILER", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                // bağlantı açık değilse açmak için kullanılır
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.Id = Convert.ToInt32(dr["OGRID"].ToString());
                ent.Ad = dr["OGRAD"].ToString();
                ent.Soyad = dr["OGRSOYAD"].ToString();
                ent.Numara = dr["OGRNUMARA"].ToString();
                ent.Mail = dr["OGRMAIL"].ToString();
                ent.Sifre = dr["OGRSIFRE"].ToString();
                ent.Bakiye =Convert.ToDouble( dr["OGRBAKIYE"].ToString());
                degerler.Add(ent);
                
            }
            dr.Close();
            return degerler;
        }
        public static bool OgrenciSil(int p)
        {
            SqlCommand komut = new SqlCommand("Delete from TBL_OGRENCILER where OGRID=@P1", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {              
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", p);
            return komut.ExecuteNonQuery() > 0; 
        }

        public static List<EntityOgrenci> ÖgrenciDetay(int id)
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut = new SqlCommand("Select * from TBL_OGRENCILER where OGRID=@p1", Baglanti.bgl);
            komut.Parameters.AddWithValue("@p1", id);
            if (komut.Connection.State != ConnectionState.Open)
            {
                // bağlantı açık değilse açmak için kullanılır
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();               
                ent.Ad = dr["OGRAD"].ToString(); 
                ent.Soyad = dr["OGRSOYAD"].ToString();
                ent.Numara = dr["OGRNUMARA"].ToString();
                ent.Mail = dr["OGRMAIL"].ToString();
                ent.Sifre = dr["OGRSIFRE"].ToString();
                ent.Bakiye = Convert.ToDouble(dr["OGRBAKIYE"].ToString());
                degerler.Add(ent);

            }
            dr.Close();
            return degerler;
        }
        public static bool OgrenciGuncelle(EntityOgrenci deger)
        {
            SqlCommand komut = new SqlCommand("update TBL_OGRENCILER set OGRAD=@P1,OGRSOYAD=@P2,OGRNUMARA=@P3,OGRMAIL=@P4,OGRSIFRE=@P5,OGRBAKIYE=@P6 WHERE OGRID=@P7", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", deger.Ad);
            komut.Parameters.AddWithValue("@p2", deger.Soyad);
            komut.Parameters.AddWithValue("@p3", deger.Numara);
            komut.Parameters.AddWithValue("@p4", deger.Mail);
            komut.Parameters.AddWithValue("@p5", deger.Sifre);
            komut.Parameters.AddWithValue("@p6", deger.Bakiye);
            komut.Parameters.AddWithValue("@p7", deger.Id);
            return komut.ExecuteNonQuery() > 0;
            
        }
    }
}
