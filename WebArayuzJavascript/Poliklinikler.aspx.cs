using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Web.Script.Serialization;
using Common.Models;
using Business;

namespace WebArayuzJavascript
{
    public partial class Poliklinikler : System.Web.UI.Page
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
                var list = newList.HastaneGetir(ID,true).Select(x => new { x.Adi, x.ID }).ToList();
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
                var list = newList.PoliklinikGetir(ID,true).Select(x => new { x.Adi, x.ID }).ToList();
                var json = newConverter.Serialize(list);
                return json;
            }
            return null;
        }

        [WebMethod]
        public static bool poliklinikKaydet(string Adi, int HastaneID, int ID = -1)
        {
            BaseBusiness<Poliklinik> newPol = new BaseBusiness<Poliklinik>();
            Poliklinik p = new Poliklinik();
            if (ID > -1 && Adi.Trim() != "" && HastaneID > -1)
            {
                p.ID = ID;
                p.Adi = Adi;
                p.HastaneID = HastaneID;
                return newPol.Guncelle(p).HataDurumu;
            }
            else if (Adi.Trim() != "" && HastaneID > -1)
            {
                try
                {
                    p.Adi = Adi;
                    p.HastaneID = HastaneID;
                    newPol.Ekle(p);
                    return true;
                }
                catch { return false; }
            }
            return false;
        }

    }
}