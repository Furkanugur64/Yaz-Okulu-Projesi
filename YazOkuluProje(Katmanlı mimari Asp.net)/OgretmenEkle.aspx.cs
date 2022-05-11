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
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack==false)
            {
                DropDownList1.DataSource = BLLDers.BLLlistele();
                DropDownList1.DataTextField = "DersAd";
                DropDownList1.DataValueField = "Id";
                DropDownList1.DataBind();
            }
        }

       

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityOgretmen ent = new EntityOgretmen();
            ent.Ogrtad = TxtAd.Text;
            ent.Ogrtbrans = int.Parse(DropDownList1.SelectedValue);
            BLLOgretmen.OgretmenEkleBLL(ent);
        }
    }
}