using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using EnityLayer;

namespace DataAccessLayer
{
    public class DALOgretmen
    {
        public static int OgretmenEKle(EntityOgretmen ent)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_OGRETMENLER (OGRTADSOYAD,OGRTBRANS) VALUES (@P1,@P2)", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {                
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@P1", ent.Ogrtad);
            komut.Parameters.AddWithValue("@p2", ent.Ogrtbrans);
            return komut.ExecuteNonQuery();
            
        }
        public static List<EntityOgretmen> ÖgretmenListesi()
        {
            List<EntityOgretmen> degerler = new List<EntityOgretmen>();
            SqlCommand komut = new SqlCommand("Select * from TBL_OGRETMENLER", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityOgretmen ent = new EntityOgretmen();
                ent.Ogrtid = Convert.ToInt32(dr["OGRTID"].ToString());
                ent.Ogrtad = dr["OGRTADSOYAD"].ToString();
                ent.Ogrtbrans = Convert.ToInt32(dr["OGRTBRANS"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static bool ÖğretmenGuncelle(EntityOgretmen ent)
        {
            SqlCommand komut = new SqlCommand("update TBL_OGRETMENLER set OGRTADSOYAD=@P1,OGRTBRANS=@P2 where OGRTID=@p3", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", ent.Ogrtad);
            komut.Parameters.AddWithValue("@p2", ent.Ogrtbrans);
            komut.Parameters.AddWithValue("@p3", ent.Ogrtid);
            return komut.ExecuteNonQuery() > 0;
        }
        public static List<EntityOgretmen> ÖgretmenDetay(int id)
        {
            List<EntityOgretmen> degerler = new List<EntityOgretmen>();
            SqlCommand komut = new SqlCommand("Select * from TBL_OGRETMENLER where OGRTID=@p1", Baglanti.bgl);
            komut.Parameters.AddWithValue("@p1", id);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityOgretmen ent = new EntityOgretmen();
                ent.Ogrtid = Convert.ToInt32(dr["OGRTID"].ToString());
                ent.Ogrtad = dr["OGRTADSOYAD"].ToString();
                ent.Ogrtbrans = Convert.ToInt32(dr["OGRTBRANS"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static bool OgretmenSil(int p)
        {
            SqlCommand komut = new SqlCommand("Delete from TBL_OGRETMENLER where OGRTID=@P1", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", p);
            return komut.ExecuteNonQuery() > 0;
        }
    }
}
