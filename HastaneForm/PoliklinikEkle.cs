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
    public partial class PoliklinikEkle : Form
    {
        public PoliklinikEkle()
        {
            InitializeComponent();
        }

        private void PoliklinikEkle_Load(object sender, EventArgs e)
        {
            cbIl.ComboboxaIlGetir();
            cbIlce.ComboboxaIlceGetir(cbIl.SelectedValue.ToString());
            cbHastane.ComboboxaHastaneGetir(cbIlce.SelectedValue.ToString(),true);
            lbPoliklinikler.ListboxaPoliklinikGetir(cbHastane.SelectedValue.StringYap());
            lbPoliklinikler.SelectedIndex = -1;
        }

        private void cbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbIlce.ComboboxaIlceGetir(cbIl.SelectedValue.ToString());
        }

        private void cbIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbHastane.ComboboxaHastaneGetir(cbIlce.SelectedValue.ToString(),true);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            GetLists wk = new GetLists();
            var liste = wk.PoliklinikGetir(Convert.ToInt32(cbHastane.SelectedValue.ToString()));
            foreach (var item in liste)
            {
                if (item.Adi == txtPoliklinikAdi.Text.YaziyiDuzelt())
                {
                    MessageBox.Show("Bu isimde bir poliklinik hastanede zaten mevcut!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtPoliklinikAdi.Clear();
                    break;
                }
            }
            if (cbHastane.SelectedIndex != -1 && txtPoliklinikAdi.Text != "")
            {
                Poliklinik temp = new Poliklinik();
                BaseBusiness<Poliklinik> bs = new BaseBusiness<Poliklinik>();
                temp.Adi = txtPoliklinikAdi.Text.YaziyiDuzelt();
                temp.HastaneID = Convert.ToInt32(cbHastane.SelectedValue);
                bs.Ekle(temp);
                MessageBox.Show("Poliklinik Eklendi", "Başarılı");
                txtPoliklinikAdi.Clear();
            }
            else
                MessageBox.Show("Bir Hata Gerçekleşti", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            lbPoliklinikler.ListboxaPoliklinikGetir(cbHastane.SelectedValue.ToString());
        }


        private void cbHastane_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbHastane.SelectedIndex >= 0)
            {
                lbPoliklinikler.ListboxaPoliklinikGetir(cbHastane.SelectedValue.ToString());
            }
            else if (cbHastane.SelectedIndex == -1)
            {
                lbPoliklinikler.Items.Clear();
            }
        }

        private void PoliklinikEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void txtPoliklinikAdi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnKaydet.PerformClick();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Güncellemek istediğinizden emin misiniz?", "Emin Misininiz?", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                BaseBusiness<object> bs = new BaseBusiness<object>();
                Poliklinik temp = new Poliklinik();
                temp.Adi = txtPoliklinikAdi.Text.YaziyiDuzelt(); ;
                temp.ID = Convert.ToInt32(lbPoliklinikler.SelectedValue);
                temp.HastaneID = Convert.ToInt32(cbHastane.SelectedValue);
                bs.Guncelle(temp);
                lbPoliklinikler.ListboxaPoliklinikGetir(cbHastane.SelectedValue.ToString());
                MessageBox.Show("Poliklinik Güncellendi", "Başarılı");
            }
            txtPoliklinikAdi.Text = "";
            lbPoliklinikler.SelectedIndex = -1;
            btnGuncelle.Enabled = false;
            btnKaydet.Enabled = true;
            lbPoliklinikler.Enabled = true;
        }

        private void seçileniDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbPoliklinikler.SelectedIndex != -1)
            {
                DialogResult rs = MessageBox.Show("Kaydı Düzenle?", "Güncelle", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    txtPoliklinikAdi.Text = lbPoliklinikler.Text;
                    btnKaydet.Enabled = false;
                    btnGuncelle.Enabled = true;
                    lbPoliklinikler.Enabled = false;
                }
            }
        }

        private void seçileniSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaseBusiness<Poliklinik> pl = new BaseBusiness<Poliklinik>();
            Poliklinik pItem = new Poliklinik();
            pItem = (Poliklinik)lbPoliklinikler.SelectedItem;
            Result rs = new Result();
            rs = pl.Sil(pItem);
            MessageBox.Show(rs.SonucMesajı, "İşlem Sonucu");
        }

        public void KisaYol(int ilID, int ilceID, int hastaneID)
        {            
            cbIl.SelectedValue = ilID;
            cbIlce.SelectedValue = ilceID;
            cbHastane.SelectedValue = hastaneID;
        }
    }
}
