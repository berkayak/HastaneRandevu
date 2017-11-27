using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
using System.Web.Services;
using Business;
using Common.Models;

namespace WebArayuzJavascript
{
    public partial class Hastaneler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Kullanici"].StringYap() != "99999999999")
                    Response.Redirect("Giris.aspx");                
            }

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
        public static bool hastaneKaydet(string Adi, int ilId, int ilceID, int ID = -1)
        {
            BaseBusiness<Hastane> newHospital = new BaseBusiness<Hastane>();
            Hastane h = new Hastane();
            if (ID > -1 && Adi.Trim() != "" && ilId > -1 && ilceID > -1)
            {
                h.ID = ID;
                h.Adi = Adi;
                h.IlID = ilId;
                h.IlceID = ilceID;
                return newHospital.Guncelle(h).HataDurumu;
            }
            else if (Adi.Trim() != "" && ilId > -1 && ilceID > -1)
            {
                try
                {
                    h.Adi = Adi;
                    h.IlID = ilId;
                    h.IlceID = ilceID;
                    newHospital.Ekle(h);
                    return true;
                }
                catch { return false; }
            }
            return false;
        }

    }
}