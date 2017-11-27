using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using Common.Models;
using Business;



namespace WebArayuzJavascript
{
    public partial class Giris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Kullanici"].StringYap() != null)
                {
                    Response.Redirect("RandevuAl.aspx");
                }
            }
        }

        [WebMethod(enableSession:true)]
        public static bool GirisYap(string Username, string Password)
        {
            Kimlik newLogin = new Kimlik();
            Kisiler newPerson = new Kisiler();
            if (newLogin.GirisYap(Username, Password))
            {
                HttpContext.Current.Session["Kullanici"] = Username;
                HttpContext.Current.Session["RoleID"] = newLogin.RoleIDGetir(Username);
                HttpContext.Current.Session.Timeout = 5;
                HttpCookie cookie = new HttpCookie("User");
                cookie["Name"] = Username;
                cookie.Expires.AddYears(1);                
                HttpContext.Current.Response.Cookies.Add(cookie);
                return true;                
            }
            return false;
        }

        [WebMethod]
        public static bool KayitOl(string name, string surname, string TC, string eMail, DateTime birthday, string password)
        {
            Kisiler newPerson = new Kisiler();
            newPerson.Ad = name;
            newPerson.Soyad = surname;
            newPerson.TC = Convert.ToDecimal(TC);
            newPerson.eMail = eMail;
            newPerson.DogumTarihi = birthday;
            newPerson.Parola = password;
            newPerson.RoleID = 1;
            KisilerBusiness personBs = new KisilerBusiness();
            if (personBs.Ekle(newPerson).HataDurumu)
                return true;
            else
                return false;
        }
    }
}