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
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack==false)
            {
                DropDownList1.DataSource = BLLDers.BLLlistele();
                DropDownList1.DataTextField = "DersAd";
                DropDownList1.DataValueField = "Id";
                DropDownList1.DataBind();

                DropDownList2.DataSource = BLLOgrenci.BLLlistele();
                DropDownList2.DataTextField = "Ad";
                DropDownList2.DataValueField = "Id";
                DropDownList2.DataBind();
            }
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityBasvuruForm ent = new EntityBasvuruForm();
            ent.Basdersid = int.Parse(DropDownList1.SelectedValue);
            ent.Basogrid = int.Parse(DropDownList2.SelectedValue);
            DALDers.TalepEkle(ent);


        }
    }
}