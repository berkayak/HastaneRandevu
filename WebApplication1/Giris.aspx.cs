using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using System.Web.Security;
using Common.Models;
using System.Web.Services;


namespace WebApplication1
{
    public partial class Giris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["KullaniciAdi"] == null)
            {
                if (!IsPostBack)
                {
                    for (int i = 1; i < 32; i++)
                    {
                        Gunler2.Items.Add(i.ToString());
                    }
                    for (int i = 2016; i > 1900; i--)
                    {
                        Yillar2.Items.Add(i.ToString());
                    }
                }
            }
            else
                Response.Redirect("RandevuAl.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtTC.Text != null && txtSifre.Text != null)
            {
                Kisiler kisi = new Kisiler();
                Kimlik kimlik = new Kimlik();
                kisi = kimlik.KimlikBilgileriGetir(txtTC.Text);
                if (kisi.Parola == txtSifre.Text)
                {                    
                    
                     HttpCookie cook = new HttpCookie("Kullanici");
                    cook["TC"] = txtTC.Text;
                    cook["Adi"] = kisi.Ad;
                    cook["soyad"] = kisi.Soyad;
                    cook.Expires = DateTime.Now.AddYears(1);
                    Response.Cookies.Add(cook);
                    Session.Add("KullaniciAdi", txtTC.Text);
                    Session.Add("RoleID", kisi.RoleID);
                    Session.Timeout = 3;

                    Cache.Insert("Kullanici", kisi);
                    Kisiler b = new Kisiler();

                    Response.Cache.SetExpires(DateTime.Now.AddMonths(1));
                    Response.Redirect("RandevuAl.aspx");
                }
            }
        }

        private DateTime TarihGetir(byte type)
        {
            return Convert.ToDateTime(Gunler2.SelectedValue.ToString() + "." + Aylar2.SelectedValue.ToString() + "." + Yillar2.SelectedValue.ToString());

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void btnUyeOl_Click(object sender, EventArgs e)
        {
            if (TextBoxlarDoluMu())
            {
                Kisiler YeniKisi = new Kisiler();
                YeniKisi.Ad = txtAd.Text;
                YeniKisi.Soyad = txtSoyad.Text;
                YeniKisi.TC = Convert.ToDecimal(txtKayitTc.Text);
                YeniKisi.Cinsiyet = Convert.ToByte(cbCinsiyet.SelectedIndex);
                YeniKisi.DogumTarihi = TarihGetir(2);
                YeniKisi.Parola = "123";
                KisilerBusiness kisi = new KisilerBusiness();
                kisi.Ekle(YeniKisi);
            }
        }

        private bool TextBoxlarDoluMu()
        {
            if (txtAd.Text == "") return false;
            if (txtSoyad.Text == "") return false;
            if (txtKayitTc.Text == "") return false;
            if (txtEMail.Text == "") return false;
            return true;
        }

        [WebMethod]
        public static bool GirisYap(string UserName, string UserPassword)
        {
            if (UserName != null && UserPassword != null)
            {                
                Kisiler kisi = new Kisiler();
                Kimlik kimlik = new Kimlik();
                kisi = kimlik.KimlikBilgileriGetir(UserName);
               
                if (kisi.Parola == UserPassword)
                {
                    return true;
                }
            }
            return false;
        }


    }
}