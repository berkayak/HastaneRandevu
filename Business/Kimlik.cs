using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Repository;
using Common.Models;

namespace Business
{
    public class Kimlik
    {
        public bool GirisYap(string kullaniciTC, string sifre)
        {
            try
            {
                KisiRepository kisi = new KisiRepository();
                return kisi.GirisYap(kullaniciTC, sifre);
            }
            catch
            {
                return false;
            }
        }

        public byte RoleIDGetir(string kullaniciTC)
        {
            try
            {
                KisiRepository kisi = new KisiRepository();
                return kisi.RolIDGetir(kullaniciTC);
            }
            catch
            {
                return 0;
            }
        }

        public Kisiler KimlikBilgileriGetir(string TC)
        {
            try
            {
                KisiRepository kisi = new KisiRepository();
                return kisi.KisiGetir(TC);
            }
            catch {
                return null;
            }
        }
    }
}
