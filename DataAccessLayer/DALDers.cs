using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EnityLayer;

namespace DataAccessLayer
{
    public class DALDers
    {
        public static List<EntityDersler> DersListesi()
        {
            List<EntityDersler> degerler = new List<EntityDersler>();
            SqlCommand komut = new SqlCommand("Select * from TBL_DERSLER", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityDersler x = new EntityDersler();
                x.Id = Convert.ToInt32(dr["DERSID"].ToString());
                x.Dersad = dr["DERSAD"].ToString();
                x.Min = int.Parse(dr["DERSMINKONT"].ToString());
                x.Max = int.Parse(dr["DERSMAKSKONT"].ToString());
                degerler.Add(x);

            }
            dr.Close();
            return degerler;
        }
        public static int TalepEkle(EntityBasvuruForm ent)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_BASVURUFORM (OGRENCIID,DERSID) VALUES (@P1,@P2)", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", ent.Basogrid);
            komut.Parameters.AddWithValue("@p2", ent.Basdersid);
            return komut.ExecuteNonQuery();
        }

        public static int DersEkle(EntityDersler ent)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_DERSLER (DERSAD,DERSMINKONT,DERSMAKSKONT) VALUES (@P1,@P2,@P3)", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@P1", ent.Dersad);
            komut.Parameters.AddWithValue("@P2", ent.Min);
            komut.Parameters.AddWithValue("@P3", ent.Max);
            return komut.ExecuteNonQuery();
        }
    }
}
