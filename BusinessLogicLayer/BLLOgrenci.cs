using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// sistem kütüphaneleri
using EnityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLOgrenci
    {
        public static int OgrenciEkleBLL(EntityOgrenci ent)
        {
           // bu katmanda verilen şartlar yerine getirilirse return ile dataaccesslayerdaki sınıfın içindeki metodu çalıştırması istenir
           
            if (ent.Ad != "" && ent.Soyad != "" && ent.Mail != "" && ent.Numara != "" && ent.Sifre != "")
            {
                return DALOgrenci.OgrenciEkle(ent);
            }
            return -1;
        }

        public static List<EntityOgrenci> BLLlistele()
        {
            return DALOgrenci.ÖgrenciListesi();
        }
        public static bool OgrenciSil(int p)
        {
            if (p != null)
            {
                return DALOgrenci.OgrenciSil(p);
            }
            return false;
        }
        public static List<EntityOgrenci> BLLDetay(int p)
        {
            return DALOgrenci.ÖgrenciDetay(p);
        }

        public static bool OgrenciGuncelle(EntityOgrenci p)
        {
            if (p.Ad != null && p.Soyad != null && p.Numara != null && p.Mail != null && p.Sifre!=null)
            {
                return DALOgrenci.OgrenciGuncelle(p);
            }
            return false;
        }
    }
}
