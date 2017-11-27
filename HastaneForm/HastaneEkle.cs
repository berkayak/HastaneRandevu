using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Common.Models;

namespace HastaneForm
{
    public partial class HastaneEkle : Form
    {
        public HastaneEkle()
        {
            InitializeComponent();
        }

        private void HastaneEkle_Load(object sender, EventArgs e)
        {
            cbIl.ComboboxaIlGetir();
            cbIlce.ComboboxaIlceGetir(cbIl.SelectedValue.ToString());
            lbHastaneler.ListboxaHastaneGetir(cbIlce.SelectedValue.ToString());
            txtHastaneAdi.Clear();
        }

        private void cbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbIlce.ComboboxaIlceGetir(cbIl.SelectedValue.ToString());
        }

        private void cbIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbHastaneler.ListboxaHastaneGetir(cbIlce.SelectedValue.ToString());
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            GetLists wk = new GetLists();
            var liste = wk.HastaneGetir(Convert.ToInt32(cbIlce.SelectedValue.ToString()));
            foreach (var item in liste)
            {
                if (item.Adi == txtHastaneAdi.Text.YaziyiDuzelt())
                {
                    MessageBox.Show("Bu isimde bir hastane ilçede zaten mevcut!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtHastaneAdi.Text = "";
                    break;
                }
            }
            if (cbIlce.SelectedIndex != -1 && txtHastaneAdi.Text != "")
            {
                BaseBusiness<Hastane> temp = new BaseBusiness<Hastane>();
                Hastane hs = new Hastane();
                hs.Adi = txtHastaneAdi.Text.YaziyiDuzelt();
                hs.IlID = Convert.ToInt32(cbIl.SelectedValue);
                hs.IlceID = Convert.ToInt32(cbIlce.SelectedValue);
                temp.Ekle(hs);
                lbHastaneler.ListboxaHastaneGetir(cbIlce.SelectedValue.ToString());
                MessageBox.Show("Hastane Eklendi", "Başarılı");
                txtHastaneAdi.Clear();
            }
            else
                MessageBox.Show("Bir Hata Gerçekleşti", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            btnGuncelle.Enabled = false;
        }

        private void txtHastaneAdi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnKaydet.PerformClick();
            }
        }

        private void HastaneEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Güncellemek istediğinizden emin misiniz?", "Emin Misininiz?", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                BaseBusiness<Hastane> hs = new BaseBusiness<Hastane>();
                Hastane temp = new Hastane();
                temp.Adi = txtHastaneAdi.Text.YaziyiDuzelt();
                temp.ID = Convert.ToInt32(lbHastaneler.SelectedValue);
                temp.IlceID = Convert.ToInt32(cbIlce.SelectedValue);
                temp.IlID = Convert.ToInt32(cbIl.SelectedValue);
                hs.Guncelle(temp);
                MessageBox.Show("Hastane Güncellendi", "Başarılı");
                lbHastaneler.ListboxaHastaneGetir(cbIlce.SelectedValue.ToString());
                txtHastaneAdi.Clear();
            }
            txtHastaneAdi.Text = "";
            lbHastaneler.SelectedIndex = -1;
            btnGuncelle.Enabled = false;
            btnKaydet.Enabled = true;
            lbHastaneler.Enabled = true;
        }

        private void seçileniSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SİLME İŞLEMİ
            if (lbHastaneler.SelectedIndex != -1)
            {
                DialogResult rs = MessageBox.Show("Seçili Kayıt Silinsin mi?", "Sil", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    Hastane hItem = new Hastane();
                    hItem = (Hastane)lbHastaneler.SelectedItem;
                    HastaneBusiness bHastane = new HastaneBusiness();
                    Result silmeSonucu = bHastane.Sil(hItem);
                    MessageBox.Show(silmeSonucu.SonucMesajı, "Silme İşlem Sonucu");
                    lbHastaneler.ListboxaHastaneGetir(cbIlce.SelectedValue.ToString());
                }
            }
        }

        private void seçileniDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DÜZENLEME İŞLEMİ
            if (lbHastaneler.SelectedIndex != -1)
            {
                DialogResult rs = MessageBox.Show("Kaydı Düzenle?", "Güncelle", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    btnKaydet.Enabled = false;
                    txtHastaneAdi.Text = lbHastaneler.Text;
                    btnGuncelle.Enabled = true;
                    lbHastaneler.Enabled = false;
                }
            }
        }

        private void ddToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void poliklinikEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = this.ParentForm;
            foreach (Form item in a.MdiChildren)
            {
                if ("Polikinik Ekle" == item.Name)
                {
                    item.Dispose();
                    break;
                }
            }
            PoliklinikEkle NewForm = new PoliklinikEkle();
            NewForm.Name = "Polikinik Ekle";
            NewForm.Text = "Polikinik Ekle";
            NewForm.MdiParent = ((AnaPencere)a);            
            NewForm.Show();
            NewForm.KisaYol(Convert.ToInt32(cbIl.SelectedValue), Convert.ToInt32(cbIlce.SelectedValue), Convert.ToInt32(lbHastaneler.SelectedValue));
            
        }
    }
}
