using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

namespace BusinessLogicLayer
{
    public class BLLOgretmen
    {
        public static int OgretmenEkleBLL(EntityOgretmen ent)
        {
            if (ent.Ogrtad != null && ent.Ogrtbrans != null && ent.Ogrtad != "")
            {
                return DALOgretmen.OgretmenEKle(ent);
            }
            return -1;
        }
        public static List<EntityOgretmen> BLLlistele()
        {
            return DALOgretmen.ÖgretmenListesi();
        }
        public static bool OgretmenGuncelle(EntityOgretmen ent)
        {
            if (ent.Ogrtad != null)
            {
                return DALOgretmen.ÖğretmenGuncelle(ent);
            }
            return false;
        }
        public static List<EntityOgretmen> BLLDetay(int p)
        {
            return DALOgretmen.ÖgretmenDetay(p);
        }

        public static bool OgrenciSil(int p)
        {
            if (p != null)
            {
                return DALOgretmen.OgretmenSil(p);
            }
            return false;
        }
    }
}
