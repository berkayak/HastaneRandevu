using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using Common.Models;
using System.Web.Security;

namespace WebApplication1
{
    public partial class HastaneEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["RoleID"].StringYap() != "2")
                Response.Redirect("Giris.aspx");            
            if (!IsPostBack)
            {
                ilGetir();
                ilceGetir();
                HastaneGetir();
            }
        }

        protected void cbIller_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilceGetir();
            HastaneGetir();
        }

        protected void cbIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            HastaneGetir();
        }

        private void ilGetir()
        {
            GetLists listeler = new GetLists();
            cbIller.DataSource = listeler.IlGetir();
            cbIller.DataValueField = "ID";
            cbIller.DataTextField = "Adi";
            cbIller.DataBind();
        }

        private void ilceGetir()
        {
            GetLists listeler = new GetLists();
            cbIlce.DataSource = listeler.IlceGetir(Convert.ToInt32(cbIller.SelectedValue));
            cbIlce.DataValueField = "ID";
            cbIlce.DataTextField = "Adi";
            cbIlce.DataBind();
        }

        private void HastaneGetir()
        {
            GetLists listeler = new GetLists();
            lbHastaneler.DataSource = listeler.HastaneGetir(Convert.ToInt32(cbIlce.SelectedValue), true);
            lbHastaneler.DataValueField = "ID";
            lbHastaneler.DataTextField = "Adi";
            lbHastaneler.DataBind();
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            HastaneBusiness hs = new HastaneBusiness();
            Hastane hastane = new Hastane();
            hastane.Adi = txtHastane.Text.YaziyiDuzelt();
            hastane.IlceID = Convert.ToInt32(cbIlce.SelectedValue);
            hastane.IlID = Convert.ToInt32(cbIller.SelectedValue);
            hs.Ekle(hastane);
            Temizle();
        }

        protected void btnSil_Click(object sender, EventArgs e)
        {
            Hastane hItem = new Hastane();
            hItem.ID = Convert.ToInt32(lbHastaneler.SelectedItem.Value);
            HastaneBusiness bHastane = new HastaneBusiness();
            Result silmeSonucu = bHastane.Sil(hItem);
            ClientScript.RegisterStartupScript(this.GetType(), "myAlert", "alert('" + silmeSonucu.SonucMesajı + "');", true);
            HastaneGetir();
            Temizle();
        }

        protected void lbHastaneler_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtHastane.Text = lbHastaneler.SelectedItem.Text;
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            Hastane hs = new Hastane();
            hs.Adi = txtHastane.Text.YaziyiDuzelt();
            hs.ID = Convert.ToInt32(lbHastaneler.SelectedItem.Value);
            hs.IlID = Convert.ToInt32(cbIller.SelectedValue);
            hs.IlceID = Convert.ToInt32(cbIlce.SelectedValue);
            HastaneBusiness bs = new HastaneBusiness();
            bs.Guncelle(hs);
            Temizle();
        }

        private void Temizle()
        {
            txtHastane.Text = "";
            HastaneGetir();
        }
    }
}