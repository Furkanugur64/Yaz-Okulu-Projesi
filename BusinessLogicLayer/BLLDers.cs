using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLDers
    {
        public static List<EntityDersler> BLLlistele()
        {
            return DALDers.DersListesi();
        }

        public static int BLLTalepEkle(EntityBasvuruForm p)
        {
            if (p.Basdersid != null && p.Basogrid != null)
            {
                return DALDers.TalepEkle(p);
            }
            return -1;
        }
        public static int DersEkleBLL(EntityDersler ent)
        {
            if (ent.Dersad!="" && ent.Min!=null && ent.Max!=null)
            {
                return DALDers.DersEkle(ent);
            }
            return -1;
        }
    }
}
