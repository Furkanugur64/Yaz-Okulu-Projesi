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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.Ad = TxtAd.Text;
            ent.Soyad = TxtSoyad.Text;
            ent.Numara = TxtNo.Text;
            ent.Mail = TxtMail.Text;
            ent.Sifre = TxtSifre.Text;
            BLLOgrenci.OgrenciEkleBLL(ent);

        }

        protected void TxtSifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}