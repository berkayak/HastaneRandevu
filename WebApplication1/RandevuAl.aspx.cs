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
    public partial class RandevuAl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["RoleID"] == null)
                Response.Redirect("Giris.aspx");
            if (!IsPostBack)
            {
                for (int i = 1; i < 32; i++)
                {
                    DropDownList1.Items.Add(i.ToString());
                }
                for (int i = 2016; i < 1900; i--)
                {
                    DropDownList3.Items.Add(i.ToString());
                }
                IlGetir();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (SaatSecimi())
            {
                RandevuKaydet();
            }
        }

        private bool SaatSecimi()
        {
            if (cbPoliklinik.SelectedIndex == -1) return false;
            if (cbRandevuSaati.SelectedIndex == -1) return false;
            return true;
        }

        private void RandevuKaydet()
        {
            RandevuBusiness bsr = new RandevuBusiness();
            Result rs = bsr.RandevuKaydet(Session["KullaniciAdi"].StringYap(), Convert.ToInt32(cbHastane.SelectedValue.StringYap()),
                Convert.ToInt32(cbPoliklinik.SelectedValue.StringYap()), cbRandevuSaati.Text);
            if (!rs.HataDurumu == true)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "error", "alert('oops');", true);
            }
            else
            {
                KisilerBusiness ks = new KisilerBusiness();
                GetLists gl = new GetLists();
                var liste = gl.DoluSaatler(Convert.ToInt32(cbPoliklinik.SelectedValue));
                foreach (Randevu item in liste)
                {
                    if (ks.KisiTCGetir(Convert.ToInt32(item.HastaID)).StringYap() == txtTC.Text && item.PoliklinikID == Convert.ToInt32(cbPoliklinik.SelectedValue))
                    {
                        //MessageBox.Show(rs.SonucMesajı + "\nRandevu Tarihi: " + item.RandevuTarihi + "\n" + "Poliklinik: " + cbPoliklinik.Text, "İşlem Sonucu",
                        //    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void IlGetir()
        {
            GetLists listeler = new GetLists();
            cbIl.DataSource = listeler.IlGetir();
            cbIl.DataTextField = "Adi";
            cbIl.DataValueField = "ID";
            cbIl.DataBind();
            ilceGetir();
        }

        private void ilceGetir()
        {
            GetLists listeler = new GetLists();
            cbIlce.DataSource = listeler.IlceGetir(Convert.ToInt32(cbIl.SelectedValue));
            cbIlce.DataValueField = "ID";
            cbIlce.DataTextField = "Adi";
            cbIlce.DataBind();
            HastaneGetir();
        }

        private void HastaneGetir()
        {
            if (cbIlce.SelectedValue != "")
            {
                GetLists listeler = new GetLists();
                cbHastane.DataSource = listeler.HastaneGetir(Convert.ToInt32(cbIlce.SelectedValue));
                cbHastane.DataValueField = "ID";
                cbHastane.DataTextField = "Adi";
                cbHastane.DataBind();
                PoliklinikGetir();
            }
        }

        private void PoliklinikGetir()
        {
            if (cbHastane.SelectedValue != "")
            {
                GetLists listeler = new GetLists();
                cbPoliklinik.DataSource = listeler.PoliklinikGetir(Convert.ToInt32(cbHastane.SelectedValue));
                cbPoliklinik.DataValueField = "ID";
                cbPoliklinik.DataTextField = "Adi";
                cbPoliklinik.DataBind();
                cbRandevuSaati.UygunSaatleriGetir(cbPoliklinik.SelectedValue.ToString());
            }
            else
            {
                cbPoliklinik.Items.Clear();
                cbPoliklinik.DataBind();
                cbPoliklinik.SelectedIndex = -1;
            }
        }

        protected void cbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilceGetir();
        }

        protected void cbIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            HastaneGetir();
        }

        protected void cbHastane_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbHastane.SelectedIndex != -1)
                PoliklinikGetir();
            else
                cbPoliklinik.Items.Clear();
        }

        protected void cbPoliklinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPoliklinik.SelectedIndex != -1)
                cbRandevuSaati.UygunSaatleriGetir(cbPoliklinik.SelectedValue.ToString());
            else
                cbRandevuSaati.Items.Clear();
        }
    }
}