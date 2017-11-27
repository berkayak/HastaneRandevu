using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Web.Script.Serialization;
using Business;
using Common.Models;

namespace WebArayuzJavascript
{
    public partial class Doktorlar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Kullanici"].StringYap() != "99999999999")
                Response.Redirect("Giris.aspx");    
        }

        [WebMethod]
        public static string ilGetir()
        {
            JavaScriptSerializer newConverter = new JavaScriptSerializer();
            GetLists newList = new GetLists();
            var list = newList.IlGetir().Select(x => new { x.Adi, x.ID }).ToList();
            var json = newConverter.Serialize(list);
            return json;
        }

        [WebMethod]
        public static string ilceGetir(int ID)
        {
            if (ID > 0)
            {
                JavaScriptSerializer newConverter = new JavaScriptSerializer();
                GetLists newList = new GetLists();
                var list = newList.IlceGetir(ID).Select(x => new { x.Adi, x.ID }).ToList();
                var json = newConverter.Serialize(list);
                return json;
            }
            return null;
        }

        [WebMethod]
        public static string hastaneGetir(int ID)
        {
            if (ID > 0)
            {
                JavaScriptSerializer newConverter = new JavaScriptSerializer();
                GetLists newList = new GetLists();
                var list = newList.HastaneGetir(ID, true).Select(x => new { x.Adi, x.ID }).ToList();
                var json = newConverter.Serialize(list);
                return json;
            }
            return null;
        }

        [WebMethod]
        public static string poliklinikGetir(int ID)
        {
            if (ID > 0)
            {
                JavaScriptSerializer newConverter = new JavaScriptSerializer();
                GetLists newList = new GetLists();
                var list = newList.PoliklinikGetir(ID, true).Select(x => new { x.Adi, x.ID }).ToList();
                var json = newConverter.Serialize(list);
                return json;
            }
            return null;
        }

        [WebMethod]
        public static bool doktorKaydet(string Adi, string Soyadi, int PoliklinikID, int ID = -1)
        {
            BaseBusiness<Doktor> newPol = new BaseBusiness<Doktor>();
            Doktor d = new Doktor();
            if (ID > -1 && Adi.Trim() != "" && Soyadi.Trim() != "" && PoliklinikID > -1)
            {
                d.ID = ID;
                d.Ad = Adi.ToUpper();
                d.Soyad = Soyadi.ToUpper();
                d.PoliklinikID = PoliklinikID;
                return newPol.Guncelle(d).HataDurumu;
            }
            else if (Adi.Trim() != "" && Soyadi.Trim() != "" && PoliklinikID > -1)
            {
                try
                {
                    d.Ad = Adi.ToUpper();
                    d.Soyad = Soyadi.ToUpper();
                    d.PoliklinikID = PoliklinikID;
                    newPol.Ekle(d);
                    return true;
                }
                catch { return false; }
            }
            return false;
        }

        [WebMethod]
        public static string doktorGetir(int ID)
        {
            if (ID > 0)
            {
                JavaScriptSerializer newConverter = new JavaScriptSerializer();
                GetLists newList = new GetLists();
                var list = newList.DoktorGetir(ID).Select(x => new { x.Ad, x.Soyad, x.ID }).ToList();
                var json = newConverter.Serialize(list);
                return json;
            }
            return null;
        }
    }
}