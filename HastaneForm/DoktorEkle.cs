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
    public partial class DoktorEkle : Form
    {
        public DoktorEkle()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormExtensions.SadeceHarf(sender, e);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cbIl.SelectedIndex != -1 && cbIlce.SelectedIndex != -1
                    && cbHastane.SelectedIndex != -1 && cbPoliklinik.SelectedIndex != -1 && txtDoktorAdi.Text != "" && txtDoktorSoyadi.Text != "")
            {
                if (dgvDoktorlar.RowCount > 0)
                {
                    DialogResult rs = MessageBox.Show("Bu Poliklinikte Halihazırda Çalışmakta Olan Bir Doktor Mevcut.\n"
                    + txtDoktorAdi.Text.YaziyiDuzelt() + " " + txtDoktorSoyadi.Text.YaziyiDuzelt()
                    + " İsimli Doktoru Eklemek İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        Doktor dr = new Doktor();
                        BaseBusiness<Doktor> temp = new BaseBusiness<Doktor>();
                        dr.Ad = txtDoktorAdi.Text.YaziyiDuzelt();
                        dr.Soyad = txtDoktorSoyadi.Text.YaziyiDuzelt();
                        dr.PoliklinikID = Convert.ToInt32(cbPoliklinik.SelectedValue.ToString());
                        temp.Ekle(dr);
                        dgvDoktorlar.DatagridviewaDoktorGetir(cbPoliklinik.SelectedValue.ToString());
                        txtDoktorAdi.Clear();
                        txtDoktorSoyadi.Clear();
                    }
                    else if (rs == DialogResult.No)
                    {
                        MessageBox.Show("Değişiklikler iptal edildi", "İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtDoktorAdi.Clear();
                        txtDoktorSoyadi.Clear();
                    }
                }
                else
                {
                    Doktor dr = new Doktor();
                    BaseBusiness<Doktor> temp = new BaseBusiness<Doktor>();
                    dr.Ad = txtDoktorAdi.Text.YaziyiDuzelt();
                    dr.Soyad = txtDoktorSoyadi.Text.YaziyiDuzelt();
                    dr.PoliklinikID = Convert.ToInt32(cbPoliklinik.SelectedValue.ToString());
                    temp.Ekle(dr);
                    dgvDoktorlar.DatagridviewaDoktorGetir(cbPoliklinik.SelectedValue.ToString());
                    txtDoktorAdi.Clear();
                    txtDoktorSoyadi.Clear();
                }
            }
            else
                MessageBox.Show("Giriş Bilgileri Hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtDoktorSoyadi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnKaydet.PerformClick();
            }
        }

        private void DoktorEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void txtDoktorAdi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnKaydet.PerformClick();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Onaylıyor Musunuz?", "Onay", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                BaseBusiness<Doktor> bs = new BaseBusiness<Doktor>();
                Doktor dr = new Doktor();
                dr.Ad = txtDoktorAdi.Text.YaziyiDuzelt();
                dr.Soyad = txtDoktorSoyadi.Text.YaziyiDuzelt();
                dr.PoliklinikID = Convert.ToInt32(cbPoliklinik.SelectedValue);
                dr.ID = Convert.ToInt32(dgvDoktorlar.CurrentRow.Cells["ID"].Value);
                bs.Guncelle(dr);
                btnGuncelle.Enabled = false;
                btnKaydet.Enabled = true;
                dgvDoktorlar.Enabled = true;
                txtDoktorAdi.Text = "";
                txtDoktorSoyadi.Text = "";
                dgvDoktorlar.DatagridviewaDoktorGetir(cbPoliklinik.SelectedValue.ToString());
            }
        }

        private void seçileniDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Kaydı Güncelle?", "Güncelle", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                DataGridViewRow dr = ((DataGridViewRow)dgvDoktorlar.CurrentRow);
                txtDoktorAdi.Text = dr.Cells["Ad"].Value.ToString();
                txtDoktorSoyadi.Text = dr.Cells["Soyad"].Value.ToString();
                btnGuncelle.Enabled = true;
                dgvDoktorlar.Enabled = false;
                btnKaydet.Enabled = false;
            }
            else
            {
                txtDoktorAdi.Text = "";
                txtDoktorSoyadi.Text = "";
            }
        }

        private void seçileniSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Seçilen Doktor Silinsin mi?", "İşlem Onayı", MessageBoxButtons.YesNo);
            if (rs == System.Windows.Forms.DialogResult.Yes)
            {
                DataGridViewRow dr = ((DataGridViewRow)dgvDoktorlar.CurrentRow);
                Doktor doktor = new Doktor();
                doktor.Ad = dr.Cells["Ad"].Value.ToString();
                doktor.Soyad = dr.Cells["Soyad"].Value.ToString();
                doktor.ID = Convert.ToInt32(dr.Cells["ID"].Value);
                BaseBusiness<Doktor> bDoktor = new BaseBusiness<Doktor>();
                Result result = bDoktor.Sil(doktor);
                MessageBox.Show(result.SonucMesajı, "İşlem Sonucu");
                dgvDoktorlar.DatagridviewaDoktorGetir(cbPoliklinik.SelectedValue.ToString());
            }
        }

        private void cbIl_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            cbIl.ComboboxaIlGetir();
            this.Cursor = Cursors.Default;
        }

        private void cbIl_SelectedValueChanged(object sender, EventArgs e)
        {
            cbIlce.ComboboxaIlceGetir(cbIl.SelectedValue.ToString());
        }

        private void cbIlce_SelectedValueChanged(object sender, EventArgs e)
        {
            cbHastane.ComboboxaHastaneGetir(cbIlce.SelectedValue.ToString(),true);
            if (cbHastane.SelectedValue == null)
                cbPoliklinik.DataSource = null;
        }

        private void cbHastane_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbHastane.SelectedValue != null)
                cbPoliklinik.ComboboxaPoliklinikGetir(cbHastane.SelectedValue.ToString(),true);

        }

        private void cbPoliklinik_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbPoliklinik.SelectedValue != null)
            {
                dgvDoktorlar.DatagridviewaDoktorGetir(cbPoliklinik.SelectedValue.ToString());
            }
            else
                dgvDoktorlar.DataSource = null;
        }
    }
}
