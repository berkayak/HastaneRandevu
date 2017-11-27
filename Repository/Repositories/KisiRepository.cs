using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models;
using Repository.Data;

namespace Repository
{
    public class KisiRepository : RepositoryBase<Kisiler>
    {
        private bool KisiVarMi(string TC)
        {
            using (HastaneRandevuContext context = new HastaneRandevuContext())
            {
                decimal Tc = Convert.ToDecimal(TC);
                if (context.Kisilers.Any(x => x.TC == Tc))
                    return true;
                else
                    return false;
            }
        }

        public bool GirisYap(string kullaniciTC, string sifre)
        {
            var TC = Convert.ToDecimal(kullaniciTC);
            using (HastaneRandevuContext context = new HastaneRandevuContext())
            {
                if (KisiVarMi(kullaniciTC))
                {
                    var test = context.Kisilers.Where(x => x.TC == TC).First();
                    if (sifre == test.Parola) return true;
                    else return false;
                }
                else
                    return false;
            }
        }

        public override void Ekle(Kisiler kisi)
        {
            using (HastaneRandevuContext context = new HastaneRandevuContext())
            {
                if (!KisiVarMi(kisi.TC.ToString()))
                {
                    context.Kisilers.Add(kisi);
                    context.SaveChanges();
                }
            }
        }

        public string KisiTCGetir(int ID)
        {
            using (HastaneRandevuContext context = new HastaneRandevuContext())
            {
                var TC = (from x in context.Kisilers
                          where x.ID == ID
                          select x.TC).First();
                return TC.StringYap(); ;
            }
        }

        public byte RolIDGetir(string kullaniciTC)
        {
            using (HastaneRandevuContext context = new HastaneRandevuContext())
            {
                decimal TC = Convert.ToDecimal(kullaniciTC);
                var RoleID = (from x in context.Kisilers where x.TC == TC select x.RoleID).First();
                return Convert.ToByte(RoleID);
            }
        }

        public Kisiler KisiGetir(string tc)
        {
            decimal TC = Convert.ToDecimal(tc);
            using(HastaneRandevuContext context = new HastaneRandevuContext())
            {
                return context.Kisilers.Where(x => x.TC == TC).First();
            }
        }
    }
}

