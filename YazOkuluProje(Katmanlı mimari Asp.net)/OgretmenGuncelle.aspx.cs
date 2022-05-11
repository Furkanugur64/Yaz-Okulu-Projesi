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
    public partial class OgretmenGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["OGRTID"].ToString());
            TxtId.Text = id.ToString();
            TxtId.Enabled = false;
            if (Page.IsPostBack == false)
            {
                DropDownList1.DataSource = BLLDers.BLLlistele();
                DropDownList1.DataTextField = "DersAd";
                DropDownList1.DataValueField = "Id";
                DropDownList1.DataBind();


                List<EntityOgretmen> Ogrlist = BLLOgretmen.BLLDetay(id);
                TxtId.Text = Ogrlist[0].Ogrtid.ToString();
                TxtAd.Text = Ogrlist[0].Ogrtad.ToString();


            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            EntityOgretmen ent = new EntityOgretmen();
            ent.Ogrtid = Convert.ToInt32(TxtId.Text);
            ent.Ogrtad = TxtAd.Text;
            ent.Ogrtbrans = int.Parse(DropDownList1.SelectedValue);
            BLLOgretmen.OgretmenGuncelle(ent);
            Response.Redirect("OgretmenListesi.Aspx");


        }
    }
}