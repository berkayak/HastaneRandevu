using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using Common.Models;
using Business;
using Common.Models;

namespace WebApplication1
{
    public static class FormExtensions
    {
        public static string CinsiyetAl(byte deger)
        {
            if (deger == 0)
                return "Erkek";
            else if (deger == 1)
                return "Kadın";
            else
                return "Hata";
        }

        public static void UygunSaatleriGetir(this DropDownList lbUygunSaatler, string PoliklinikID)
        {
            List<Randevu> liste = null;
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
            if (PoliklinikID != "" && Convert.ToInt32(PoliklinikID) != -1) 
                liste = DoluSaatler(Convert.ToInt32(PoliklinikID));
            if (liste != null)
            {
                foreach (var item in liste)
                    for (int i = 0; i < lbUygunSaatler.Items.Count; i++)
                        if (Convert.ToDateTime(item.RandevuTarihi).TimeOfDay == Convert.ToDateTime(lbUygunSaatler.Items[i] + ":00").TimeOfDay)
                        {
                            lbUygunSaatler.Items.RemoveAt(i);
                            lbUygunSaatler.DataBind();
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
