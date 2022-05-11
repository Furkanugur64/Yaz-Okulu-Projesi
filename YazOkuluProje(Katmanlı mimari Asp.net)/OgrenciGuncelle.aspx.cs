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
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["OGRID"].ToString());
            TxtId.Text = id.ToString();
            TxtId.Enabled = false;
            if (Page.IsPostBack == false)
            {
                
                List<EntityOgrenci> Ogrlist = BLLOgrenci.BLLDetay(id);
                TxtAd.Text = Ogrlist[0].Ad.ToString();
                TxtSoyad.Text = Ogrlist[0].Soyad.ToString();
                TxtNo.Text = Ogrlist[0].Numara.ToString();
                TxtMail.Text = Ogrlist[0].Mail.ToString();
                TxtSifre.Text = Ogrlist[0].Sifre.ToString();
                TxtBakiye.Text = Ogrlist[0].Bakiye.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.Id = Convert.ToInt32(TxtId.Text);
            ent.Ad = TxtAd.Text;
            ent.Soyad = TxtSoyad.Text;
            ent.Numara = TxtNo.Text;
            ent.Mail = TxtMail.Text;
            ent.Sifre = TxtSifre.Text;
            ent.Bakiye = Convert.ToDouble(TxtBakiye.Text);
            BLLOgrenci.OgrenciGuncelle(ent);
            Response.Redirect("OgrenciListesi.Aspx");
        }
    }
}