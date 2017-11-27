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
    public partial class PoliklinikEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["RoleID"].StringYap() != "2")
                Response.Redirect("Giris.aspx");
            if (!IsPostBack)
            {
                ilGetir();
            }

        }

        private void ilGetir()
        {
            GetLists listeler = new GetLists();
            cbIller.DataSource = listeler.IlGetir();
            cbIller.DataValueField = "ID";
            cbIller.DataTextField = "Adi";
            cbIller.DataBind();
            ilceGetir();
        }

        private void ilceGetir()
        {
            GetLists listeler = new GetLists();
            cbIlce.DataSource = listeler.IlceGetir(Convert.ToInt32(cbIller.SelectedValue));
            cbIlce.DataValueField = "ID";
            cbIlce.DataTextField = "Adi";
            cbIlce.DataBind();
            HastaneGetir();
        }

        private void HastaneGetir()
        {
            GetLists listeler = new GetLists();
            cbHastaneler.DataSource = listeler.HastaneGetir(Convert.ToInt32(cbIlce.SelectedValue), true);
            cbHastaneler.DataValueField = "ID";
            cbHastaneler.DataTextField = "Adi";
            cbHastaneler.DataBind();
            PoliklinikGetir();
        }

        private void PoliklinikGetir()
        {
            GetLists listeler = new GetLists();
            lbPoliklinikler.DataSource = listeler.PoliklinikGetir(Convert.ToInt32(cbHastaneler.SelectedValue), true);
            lbPoliklinikler.DataValueField = "ID";
            lbPoliklinikler.DataTextField = "Adi";
            lbPoliklinikler.DataBind();
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            Poliklinik p = new Poliklinik();
            BaseBusiness<Poliklinik> ps = new BaseBusiness<Poliklinik>();
            p.Adi = txtPoliklinik.Text;
            p.HastaneID = Convert.ToInt32(cbHastaneler.SelectedValue);
            ps.Ekle(p);
            Temizle();
        }

        private void Temizle()
        {
            txtPoliklinik.Text = "";
            PoliklinikGetir();
        }

        protected void cbIller_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilceGetir();
            HastaneGetir();
            PoliklinikGetir();
        }

        protected void cbIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            HastaneGetir();
            PoliklinikGetir();
        }

        protected void cbHastaneler_SelectedIndexChanged(object sender, EventArgs e)
        {
            PoliklinikGetir();
        }

        protected void btnSil_Click(object sender, EventArgs e)
        {
            Poliklinik p = new Poliklinik();
            p.ID = Convert.ToInt32(lbPoliklinikler.SelectedValue);
            BaseBusiness<Poliklinik> ps = new BaseBusiness<Poliklinik>();
            Result silmeSonucu = ps.Sil(p);
            ClientScript.RegisterStartupScript(this.GetType(), "myAlert", "alert('" + silmeSonucu.SonucMesajı + "');", true);
            Temizle();
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            Poliklinik p = new Poliklinik();
            p.ID = Convert.ToInt32(lbPoliklinikler.SelectedValue);
            p.Adi = txtPoliklinik.Text;
            p.HastaneID = Convert.ToInt32(cbHastaneler.SelectedValue);
            BaseBusiness<Poliklinik> ps = new BaseBusiness<Poliklinik>();
            ps.Guncelle(p);
            Temizle();
        }

        protected void lbPoliklinikler_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPoliklinik.Text = lbPoliklinikler.SelectedItem.Text;
        }


    }
}