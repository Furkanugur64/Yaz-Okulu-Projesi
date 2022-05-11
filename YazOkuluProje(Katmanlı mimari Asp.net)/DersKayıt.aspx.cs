using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EnityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

namespace YazOkuluProje_Katmanlı_mimari_Asp.net_
{
    public partial class DersKayıt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void BtnEkle_Click(object sender, EventArgs e)
        {
            EntityDersler ent = new EntityDersler();
            ent.Dersad = TxtDersAd.Text;
            ent.Min = Convert.ToInt32(TxtMin.Text);
            ent.Max = Convert.ToInt32(TxtMax.Text);
            BLLDers.DersEkleBLL(ent);
        }
    }
}