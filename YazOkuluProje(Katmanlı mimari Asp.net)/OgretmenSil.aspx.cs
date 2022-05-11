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
    public partial class OgretmenSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["OGRTID"]);
            EntityOgretmen ent = new EntityOgretmen();
            ent.Ogrtid = x;
            BLLOgretmen.OgrenciSil(x);
            Response.Redirect("OgretmenListesi.Aspx");
        }
    }
}