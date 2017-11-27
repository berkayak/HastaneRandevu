using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HastaneForm
{
    public partial class AnaPencere : Form
    {
        public AnaPencere()
        {
            InitializeComponent();
        }

        public void OpenForm(string formClass)
        {
            this.Cursor = Cursors.AppStarting;

            if (formClass == "RandevuAl" && !FormAcikMi("Randevu Al"))
            {
                RandevuAl NewForm = new RandevuAl();
                NewForm.Name = "Randevu Al";
                NewForm.Text = "Randevu Al";
                NewForm.MdiParent = this;               
                NewForm.Show();
            }
            else if (formClass == "RandevularıGoruntule" && !FormAcikMi("Randevuları Goruntule"))
            {
                RandevularıGoruntule NewForm = new RandevularıGoruntule();
                NewForm.Name = "Randevuları Goruntule";
                NewForm.Text = "Randevuları Goruntule";
                NewForm.MdiParent = this;
                NewForm.Show();
            }
            else if (formClass == "HastaneEkle" && !FormAcikMi("Hastane Ekle"))
            {
                HastaneEkle NewForm = new HastaneEkle();
                NewForm.Name = "Hastane Ekle";
                NewForm.Text = "Hastane Ekle";
                NewForm.MdiParent = this;
                NewForm.Show();
            }
            else if (formClass == "PoliklinikEkle" && !FormAcikMi("Polikinik Ekle"))
            {
                PoliklinikEkle NewForm = new PoliklinikEkle();
                NewForm.Name = "Polikinik Ekle";
                NewForm.Text = "Polikinik Ekle";
                NewForm.MdiParent = this;
                NewForm.Show();
            }
            else if (formClass == "DoktorEkle" && !FormAcikMi("Doktor Ekle"))
            {                      
                DoktorEkle NewForm = new DoktorEkle();
                NewForm.Name = "Doktor Ekle";
                NewForm.Text = "Doktor Ekle";
                NewForm.MdiParent = this;
                NewForm.Show();                
            }
            this.Cursor = Cursors.Default;
        }

        public bool FormAcikMi(string formName)
        {
            foreach (Form item in MdiChildren)
            {
                if (formName == item.Name)
                {
                    item.Activate();
                    return true;
                }
            }
            return false;
        }

        private void randevuAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm("RandevuAl");
        }

        private void randevularıGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm("RandevularıGoruntule");
        }

        private void hastaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm("HastaneEkle");
        }

        private void poliklinikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm("PoliklinikEkle");
        }

        private void doktorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm("DoktorEkle");
        }

        private void AnaPencere_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

    }
}
