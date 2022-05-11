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
    public partial class OgretmenListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityOgretmen> Ogrlistesi =BLLOgretmen.BLLlistele();
            Repeater1.DataSource = Ogrlistesi;
            Repeater1.DataBind();
        }
    }
}