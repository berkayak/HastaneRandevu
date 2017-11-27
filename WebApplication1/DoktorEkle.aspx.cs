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
    public partial class DoktorEkle : System.Web.UI.Page
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

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            if (hfGizliAlan.Value == "" && hfGizliAlan2.Value == "")
            {
                Doktor d = new Doktor();
                d.Ad = txtDoktorAd.Text.YaziyiDuzelt();
                d.Soyad = txtDoktorSoyad.Text.YaziyiDuzelt();
                d.PoliklinikID = Convert.ToInt32(cbPoliklinikler.SelectedValue);
                BaseBusiness<Doktor> dr = new BaseBusiness<Doktor>();
                dr.Ekle(d);                
            }
            else
            {
                Doktor d = new Doktor();
                d.Ad = txtDoktorAd.Text.YaziyiDuzelt();
                d.Soyad = txtDoktorSoyad.Text.YaziyiDuzelt();
                d.PoliklinikID = Convert.ToInt32(hfGizliAlan2.Value);
                d.ID = Convert.ToInt32(hfGizliAlan.Value);
                BaseBusiness<Doktor> dr = new BaseBusiness<Doktor>();
                dr.Guncelle(d);
                hfGizliAlan.Value = null;
                hfGizliAlan2.Value = null;   
            }
            Temizle();
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
            cbPoliklinikler.DataSource = listeler.PoliklinikGetir(Convert.ToInt32(cbHastaneler.SelectedValue), true);
            cbPoliklinikler.DataValueField = "ID";
            cbPoliklinikler.DataTextField = "Adi";
            cbPoliklinikler.DataBind();
            DoktorGetir();
        }

        private void DoktorGetir()
        {
            if (cbPoliklinikler.SelectedValue != "" && Convert.ToInt32(cbPoliklinikler.SelectedValue) != -1)
            {
                GetLists listeler = new GetLists();
                dgDoktorlar.DataSource = listeler.DoktorGetir(Convert.ToInt32(cbPoliklinikler.SelectedValue));
            }
            else
                dgDoktorlar.DataSource = null;
            dgDoktorlar.DataBind();
        }

        protected void cbIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            HastaneGetir();
        }

        protected void cbHastaneler_SelectedIndexChanged(object sender, EventArgs e)
        {
            PoliklinikGetir();
        }

        protected void cbPoliklinikler_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoktorGetir();
        }

        protected void cbIller_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilceGetir();
        }

        protected void dgDoktorlar_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "duzenle")
            {
                txtDoktorAd.Text = dgDoktorlar.Rows[index].Cells[3].Text;
                txtDoktorSoyad.Text = dgDoktorlar.Rows[index].Cells[4].Text;
                hfGizliAlan.Value = dgDoktorlar.Rows[index].Cells[2].Text;
                hfGizliAlan2.Value = dgDoktorlar.Rows[index].Cells[5].Text;
            }
            else if (e.CommandName == "sil")
            {
                Doktor d = new Doktor();
                d.ID = Convert.ToInt32(dgDoktorlar.Rows[index].Cells[2].Text);
                BaseBusiness<Doktor> dr = new BaseBusiness<Doktor>();
                dr.Sil(d);
                Temizle();
            }
        }

        protected void dgDoktorlar_DataBound(object sender, EventArgs e)
        {

        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
                    
        }

        private void Temizle()
        {
            txtDoktorAd.Text = "";
            txtDoktorSoyad.Text = "";
            DoktorGetir();
        }
    }
}