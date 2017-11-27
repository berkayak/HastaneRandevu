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
    public partial class RandevuAl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Kullanici"].StringYap() == null )
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
                var list = newList.HastaneGetir(ID).Select(x => new { x.Adi, x.ID }).ToList();
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
                var list = newList.PoliklinikGetir(ID).Select(x => new { x.Adi, x.ID }).ToList();
                var json = newConverter.Serialize(list);
                return json;
            }
            return null;
        }

        [WebMethod]
        public static string uygunSaatleriGetir(int ID)
        {
            if (ID > 0)
            {
                JavaScriptSerializer newConverter = new JavaScriptSerializer();
                GetLists newList = new GetLists();
                List<string> liste = new List<string>();
                liste.Add("09:00");
                liste.Add("09:30");
                liste.Add("10:00");
                liste.Add("10:30");
                liste.Add("11:00");
                liste.Add("11:30");
                liste.Add("12:00");
                liste.Add("12:30");
                liste.Add("13:00");
                liste.Add("13:30");
                liste.Add("14:00");
                liste.Add("14:30");
                liste.Add("15:00");
                liste.Add("15:30");
                var doluListe = newList.DoluSaatler(Convert.ToInt32(ID)).Select(x => x.RandevuTarihi).ToList();
                if (doluListe != null)
                {
                    foreach (var item in doluListe)
                        for (int i = 0; i < liste.Count; i++)
                            if (Convert.ToDateTime(item).TimeOfDay == Convert.ToDateTime(liste[i]).TimeOfDay)
                                liste.RemoveAt(i);
                }
                return newConverter.Serialize(liste);
            }
            return null;
        }

        [WebMethod]
        public static bool randevuKaydet(int hastaneID, int poliklinikID, string saat, decimal kullaniciTC)
        {
            RandevuBusiness bsr = new RandevuBusiness();
            Result rs = bsr.RandevuKaydet(kullaniciTC.StringYap(), hastaneID, poliklinikID, saat);
            return rs.HataDurumu;
        }
    }
}