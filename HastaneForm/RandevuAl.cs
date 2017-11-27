using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Models;
using Business;

namespace HastaneForm
{
    public partial class RandevuAl : Form
    {
        public RandevuAl()
        {
            InitializeComponent();
        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormExtensions.SadeceHarf(sender, e);
        }

        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormExtensions.SadeceRakam(sender, e);
        }

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormExtensions.SadeceHarf(sender, e);
        }

        private bool KisiKaydet()
        {
            if (txtAd.Text == "") { MessageBox.Show("Kisi adı hatalı"); return false; }
            if (txtSoyad.Text == "") { MessageBox.Show("Kisi soyadı hatalı"); return false; }
            if (txtTC.Text.Length != 11) { MessageBox.Show("Kisi TC hatalı"); return false; }
            if (txtEMail.Text == "") { MessageBox.Show("E-Mail adı hatalı"); return false; }
            if (cbCinsiyet.SelectedIndex == -1) { MessageBox.Show("Kisi cinsiyet hatalı"); return false; }
            if (DateTime.Today.Subtract(dtpDogumTarihi.Value).Days / 365 <= 18) { MessageBox.Show("Kişi 18 yaşından büyük olmalı"); return false; }
            KisilerBusiness bs = new KisilerBusiness();
            Kisiler kisi = new Kisiler();
            kisi.Ad = txtAd.Text.YaziyiDuzelt();
            kisi.Soyad = txtSoyad.Text.YaziyiDuzelt();
            kisi.TC = Convert.ToDecimal(txtTC.Text);
            kisi.eMail = txtEMail.Text.Trim();
            kisi.DogumTarihi = Convert.ToDateTime(dtpDogumTarihi.Text);
            kisi.Cinsiyet = Convert.ToByte(cbCinsiyet.SelectedIndex);
            bs.Ekle(kisi);
            return true;
        }

        private bool SaatSecimi()
        {
            if (cbPoliklinik.SelectedIndex == -1) { MessageBox.Show("Poliklini seçimi hatalı"); return false; }
            if (lbUygunSaatler.SelectedIndex == -1) { MessageBox.Show("Saat seçimi hatalı"); return false; }
            return true;
        }

        private void RandevuKaydet()
        {
            RandevuBusiness bsr = new RandevuBusiness();
            Result rs = bsr.RandevuKaydet(txtTC.Text, Convert.ToInt32(cbHastane.SelectedValue.StringYap()),
                Convert.ToInt32(cbPoliklinik.SelectedValue.StringYap()), lbUygunSaatler.SelectedItem.StringYap());
            if (!rs.HataDurumu == true)
            {
                MessageBox.Show("Randevunuz kaydedildi:\n" + lblRandevuTarihi.Text
                    + " Tarihinde Saat: " + lbUygunSaatler.SelectedItem.StringYap());
                SetDefaults();
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
                        MessageBox.Show(rs.SonucMesajı + "\nRandevu Tarihi: " + item.RandevuTarihi + "\n" + "Poliklinik: " + cbPoliklinik.Text, "İşlem Sonucu",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (KisiKaydet() && SaatSecimi())
            {
                RandevuKaydet();
            }
        }

        private void SetDefaults()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtEMail.Clear();
            txtTC.Clear();
            cbCinsiyet.SelectedIndex = -1;
            SaatleriDoldur();
            cbIl.SelectedIndex = -1;
        }

        private void RandevuAl_Load(object sender, EventArgs e)
        {
            cbIl.ComboboxaIlGetir();
            RandevuTarihiGoster();
        }

        private void cbIl_Click(object sender, EventArgs e)
        {
            //this.Cursor = Cursors.AppStarting;
            //cbIl.ComboboxaIlGetir();
            //cbIlce.ComboboxaIlceGetir(cbIl.SelectedValue.StringYap());
            //cbHastane.ComboboxaHastaneGetir(cbIlce.SelectedValue.StringYap());
            //cbPoliklinik.ComboboxaPoliklinikGetir(cbHastane.SelectedValue.StringYap());
            //cbIl.SelectedIndex = -1;
            //this.Cursor = Cursors.Default;
        }
        private void RandevuTarihiGoster()
        {
            if (DateTime.Now.DayOfWeek.StringYap() == "Friday")
                lblRandevuTarihi.Text = DateTime.Today.AddDays(3).Date.ToShortDateString();
            else if (DateTime.Now.DayOfWeek.StringYap() == "Saturday")
                lblRandevuTarihi.Text = DateTime.Today.AddDays(2).Date.ToShortDateString();
            else
                lblRandevuTarihi.Text = DateTime.Today.AddDays(1).Date.ToShortDateString();
        }

        private void cbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIl.SelectedIndex == -1)
                cbIlce.SelectedIndex = -1;
            //if (cbIl.SelectedIndex != -1)
            //    cbIlce.ComboboxaIlceGetir(cbIl.SelectedValue.StringYap());
            //else
            //    cbIlce.SelectedIndex = -1;
        }

        private void cbIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cbIlce.SelectedIndex != -1)
            //    cbHastane.ComboboxaHastaneGetir(cbIlce.SelectedValue.StringYap());
            //else
            //{
            //    cbHastane.SelectedIndex = -1;
            //    cbPoliklinik.DataSource = null;
            //    cbPoliklinik.SelectedIndex = -1;
            //}
        }

        private void cbHastane_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cbHastane.SelectedIndex != -1)
            //    cbPoliklinik.ComboboxaPoliklinikGetir(cbHastane.SelectedValue.StringYap());
            //else
            //{
            //    cbPoliklinik.DataSource = null;
            //    cbPoliklinik.SelectedIndex = -1;
            //}
        }

        private void cbPoliklinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPoliklinik.SelectedValue != null && cbPoliklinik.SelectedValue.StringYap().IsNumeric())
            {
                SaatleriDoldur();
            }
        }

        private void SaatleriDoldur()
        {
            lbUygunSaatler.UygunSaatleriGetir(cbPoliklinik.SelectedValue.StringYap());
        }

        private void dtpDogumTarihi_CloseUp(object sender, EventArgs e)
        {
            int ts = DateTime.Today.Subtract(dtpDogumTarihi.Value).Days;
            if ((ts / 365) < 18)
                MessageBox.Show("Hasta en az 18 Yaşında olmalıdır. Aksi halde velisi adına randevu alınmalıdır.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void RandevuAl_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Randevu saatleri bugunden sonraki ilk iş günü içindir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbIl_SelectedValueChanged(object sender, EventArgs e)
        {
            cbIlce.ComboboxaIlceGetir(cbIl.SelectedValue.StringYap());
        }

        private void cbIlce_SelectedValueChanged(object sender, EventArgs e)
        {
            cbHastane.ComboboxaHastaneGetir(cbIlce.SelectedValue.StringYap());
            if (cbHastane.Items.Count == 0)
            {
                cbPoliklinik.DataSource = null;
            }
        }

        private void cbHastane_SelectedValueChanged(object sender, EventArgs e)
        {
            cbPoliklinik.ComboboxaPoliklinikGetir(cbHastane.SelectedValue.StringYap());
        }


    }
}
