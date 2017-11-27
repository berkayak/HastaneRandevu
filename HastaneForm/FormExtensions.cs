using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Common.Models;

namespace HastaneForm
{
    public static class FormExtensions
    {
        public static void SadeceHarf(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter((char)e.KeyChar) || e.KeyChar == (char)8 || e.KeyChar == (char)32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public static void SadeceRakam(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber((char)e.KeyChar) || e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public static string CinsiyetAl(byte deger)
        {
            if (deger == 0)
                return "Erkek";
            else if (deger == 1)
                return "Kadın";
            else
                return "Hata";
        }

        public static void ComboboxaIlGetir(this ComboBox cbIl)
        {
            if (cbIl.DataSource == null)
            {
                GetLists gl = new GetLists();
                cbIl.DataSource = gl.IlGetir();
                cbIl.DisplayMember = "Adi";
                cbIl.ValueMember = "ID".ToString();
                cbIl.SelectedIndex = 0;
            }
        }

        public static void ComboboxaIlceGetir(this ComboBox cbIlce, string IlID)
        {
            if (IlID.IsNumeric())
            {
                GetLists wk = new GetLists();
                cbIlce.DataSource = wk.IlceGetir(Convert.ToInt32(IlID.ToString()));
                cbIlce.DisplayMember = "Adi";
                cbIlce.ValueMember = "ID".ToString();
                cbIlce.Enabled = true;
            }
        }

        public static void ComboboxaHastaneGetir(this ComboBox cbHastane, string IlceID, bool eklenecekMi)
        {
            if (IlceID.IsNumeric())
            {
                GetLists wk = new GetLists();
                cbHastane.DataSource = wk.HastaneGetir(Convert.ToInt32(IlceID.ToString()),eklenecekMi);
                cbHastane.DisplayMember = "Adi";
                cbHastane.ValueMember = "ID".ToString();
                cbHastane.Enabled = true;
            }
        }

        public static void ComboboxaHastaneGetir(this ComboBox cbHastane, string IlceID)
        {
            ComboboxaHastaneGetir(cbHastane, IlceID, false);
        }

        public static void ComboboxaPoliklinikGetir(this ComboBox cbPoliklinik, string HastaneID, bool eklenecekMi)
        {
            if (HastaneID.IsNumeric())
            {
                GetLists wk = new GetLists();
                cbPoliklinik.DataSource = wk.PoliklinikGetir(Convert.ToInt32(HastaneID.ToString()),eklenecekMi);
                cbPoliklinik.DisplayMember = "Adi";
                cbPoliklinik.ValueMember = "ID".ToString();
                cbPoliklinik.Enabled = true;
            }
        }

        public static void ComboboxaPoliklinikGetir(this ComboBox cbPoliklinik, string HastaneID)
        {
            ComboboxaPoliklinikGetir(cbPoliklinik, HastaneID, false);
        }

        public static void ListboxaPoliklinikGetir(this ListBox lbPoliklinikler, string HastaneID)
        {
            if (HastaneID.IsNumeric())
            {
                GetLists wk = new GetLists();
                lbPoliklinikler.DataSource = wk.PoliklinikGetir(Convert.ToInt32(HastaneID.ToString()),true);
                lbPoliklinikler.DisplayMember = "Adi";
                lbPoliklinikler.ValueMember = "ID";
            }
            lbPoliklinikler.SelectedIndex = -1;
        }

        public static void ListboxaHastaneGetir(this ListBox lbHastaneler, string IlceID)
        {
            if (IlceID.IsNumeric())
            {
                GetLists wk = new GetLists();
                lbHastaneler.DataSource = wk.HastaneGetir(Convert.ToInt32(IlceID.ToString()),true);
                lbHastaneler.DisplayMember = "Adi";
                lbHastaneler.ValueMember = "ID";
            }
            lbHastaneler.SelectedIndex = -1;
        }

        public static void DatagridviewaDoktorGetir(this DataGridView dgvDoktorlar, string PoliklinikID)
        {
            if (PoliklinikID.IsNumeric())
            {
                GetLists wk = new GetLists();
                dgvDoktorlar.DataSource = wk.DoktorGetir(Convert.ToInt32(PoliklinikID.ToString()));
                dgvDoktorlar.Columns[0].Visible = false;
                dgvDoktorlar.Columns[3].Visible = false;
                dgvDoktorlar.Columns[4].Visible = false;
                dgvDoktorlar.Columns[1].Width = 65;
                dgvDoktorlar.Columns[2].Width = 65;
            }
        }

        public static void UygunSaatleriGetir(this ListBox lbUygunSaatler, string PoliklinikID)
        {
            lbUygunSaatler.Items.Clear();
            lbUygunSaatler.Items.Add("09:00");
            lbUygunSaatler.Items.Add("09:30");
            lbUygunSaatler.Items.Add("10:00");
            lbUygunSaatler.Items.Add("10:30");
            lbUygunSaatler.Items.Add("11:00");
            lbUygunSaatler.Items.Add("11:30");
            lbUygunSaatler.Items.Add("12:00");
            lbUygunSaatler.Items.Add("12:30");
            lbUygunSaatler.Items.Add("13:00");
            lbUygunSaatler.Items.Add("13:30");
            lbUygunSaatler.Items.Add("14:00");
            lbUygunSaatler.Items.Add("14:30");
            lbUygunSaatler.Items.Add("15:00");
            lbUygunSaatler.Items.Add("15:30");
            lbUygunSaatler.Refresh();
            List<Randevu> liste = FormExtensions.DoluSaatler(Convert.ToInt32(PoliklinikID));
            if (liste != null)
            {
                foreach (var item in liste)
                    for (int i = 0; i < lbUygunSaatler.Items.Count; i++)
                        if (Convert.ToDateTime(item.RandevuTarihi).TimeOfDay == Convert.ToDateTime(lbUygunSaatler.Items[i] + ":00").TimeOfDay)
                        {
                            lbUygunSaatler.Items.RemoveAt(i);
                            lbUygunSaatler.Refresh();
                        }
            }
        }

        public static List<Randevu> DoluSaatler(int ID)
        {
            GetLists wk = new GetLists();
            return wk.DoluSaatler(ID);
        }
    }
}
