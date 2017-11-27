using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using Common.Models;

namespace WebApplication1
{
    public partial class UyelikBilgileri : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["KullaniciAdi"].StringYap() == null)
            {
                Response.Redirect("Giris.aspx");
            }
            if (!IsPostBack)
            {
                Kimlik kisi = new Kimlik();
                Kisiler gelenKisi = kisi.KimlikBilgileriGetir(Session["KullaniciAdi"].ToString());              
                txtAd.Text = gelenKisi.Ad;
                txtSoyad.Text = gelenKisi.Soyad;
                txtKayitTc.Text = gelenKisi.TC.StringYap();
                txtEMail.Text = gelenKisi.eMail;
                cbCinsiyet.SelectedIndex = Convert.ToInt32(gelenKisi.Cinsiyet);
            }
        }
    }
}