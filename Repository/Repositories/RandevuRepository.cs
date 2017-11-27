using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models;
using Repository.Data;

namespace Repository
{
    public class RandevuRepository : RepositoryBase<Randevu>
    {
        public List<Randevu> DoluSaatler(int ID)
        {
            using (HastaneRandevuContext context = new HastaneRandevuContext())
            {
                var liste = context.Randevus.Where(x => x.PoliklinikID == ID && x.RandevuTarihi > DateTime.Now).ToList();
                return liste;
            }
        }

        private DateTime TarihiAyarla(string RandevuSaati)
        {
            DateTime RandevuTarihi = new DateTime();
            if (DateTime.Now.DayOfWeek.ToString() == "Friday")
                RandevuTarihi = Convert.ToDateTime(DateTime.Today.AddDays(3).AddHours(Convert.ToInt32(RandevuSaati.Substring(0, 2))).AddMinutes(Convert.ToInt32(RandevuSaati.Substring(3, 2))));
            else if (DateTime.Now.DayOfWeek.ToString() == "Saturday")
                RandevuTarihi = Convert.ToDateTime(DateTime.Today.AddDays(2).AddHours(Convert.ToInt32(RandevuSaati.Substring(0, 2))).AddMinutes(Convert.ToInt32(RandevuSaati.Substring(3, 2))));
            else
                RandevuTarihi = Convert.ToDateTime(DateTime.Today.AddDays(1).AddHours(Convert.ToInt32(RandevuSaati.Substring(0, 2))).AddMinutes(Convert.ToInt32(RandevuSaati.Substring(3, 2))));
            return RandevuTarihi;
        }

        /// <summary>
        /// Aldığı parametreler ile randevu kaydı yapar. Randevu saatini ilk iş günündeki saat olarak tarih ayarlanır.
        /// </summary>
        /// <param name="HastaTC"></param>
        /// <param name="HastaneID"></param>
        /// <param name="PolikkinikID"></param>
        /// <param name="RandevuSaati"></param>
        public void RandevuKaydet(string HastaTC, int HastaneID, int PoliklinikID, string RandevuSaati)
        {
            using (HastaneRandevuContext context = new HastaneRandevuContext())
            {
                DateTime RandevuTarihi = TarihiAyarla(RandevuSaati);
                decimal TC = Convert.ToDecimal(HastaTC);
                var HastaID = (from x in context.Kisilers
                               where x.TC == TC
                               select x.ID).First();
                    Randevu rd = new Randevu();
                    rd.HastaID = Convert.ToInt32(HastaID);
                    rd.HastaneID = HastaneID;
                    rd.PoliklinikID = PoliklinikID;
                    rd.RandevuTarihi = RandevuTarihi;
                    rd.OlusturulmaTarihi = DateTime.Now;
                    context.Randevus.Add(rd);
                    context.SaveChanges();                
            }
        }
       
        /// <summary>
        /// Randevu var ise True döner
        /// </summary>
        /// <param name="HastaTC"></param>
        /// <param name="PoliklinikID"></param>
        /// <returns></returns>
        public bool RandevuVarMi(string HastaTC, int PoliklinikID)
        {
            using (HastaneRandevuContext context = new HastaneRandevuContext())
            {
                decimal TC = Convert.ToDecimal(HastaTC);
                var HastaID = (from x in context.Kisilers
                               where x.TC == TC
                               select x.ID).First();
                return context.Randevus.Any(x => x.HastaID == HastaID && x.RandevuTarihi > DateTime.Now && x.PoliklinikID == PoliklinikID);
            }

        }

        /// <summary>
        /// Baslangic ve Bitis Tarihlerine göre randevu listeler
        /// </summary>
        /// <param name="baslangic tarihi"></param>
        /// <param name="bitis tarihi"></param>
        /// <returns name="nesne"></returns>
        public object Getir(DateTime baslangic, DateTime bitis)
        {
            using (HastaneRandevuContext context = new HastaneRandevuContext())
            {
                DateTime ba = Convert.ToDateTime(baslangic.AddHours(0).AddMinutes(0).ToShortDateString());
                DateTime bi = Convert.ToDateTime(bitis.AddDays(1).AddHours(0).AddMinutes(0).ToShortDateString());
                var liste = (from r in context.Randevus
                             from k in context.Kisilers
                             from h in context.Hastanes
                             from p in context.Polikliniks
                             where
                             r.HastaID == k.ID && r.HastaneID == h.ID && r.PoliklinikID == p.ID && r.RandevuTarihi >= ba && r.RandevuTarihi <= bi
                             orderby r.RandevuTarihi descending
                             select new
                             {
                                 Ad = k.Ad,
                                 Soyad = k.Soyad,
                                 TC = k.TC,
                                 Hastane = h.Adi,
                                 Poliklinik = p.Adi,
                                 RandevuTarihi = r.RandevuTarihi,
                                 OlustumaTarihi = r.OlusturulmaTarihi
                             }).ToList();
                return liste;
            }
        }

        /// <summary>
        /// Aldığı Hasta Tc numarasına göre randevuları getirir
        /// </summary>
        /// <param name="TC numarası"></param>
        /// <returns></returns>
        public object Getir(string TC)
        {
            using (HastaneRandevuContext context = new HastaneRandevuContext())
            {
                decimal tc = Convert.ToDecimal(TC);
                var liste = (from r in context.Randevus
                             from k in context.Kisilers
                             from h in context.Hastanes
                             from p in context.Polikliniks
                             where r.HastaID == k.ID && r.HastaneID == h.ID && r.PoliklinikID == p.ID && k.TC == tc
                             select new
                             {
                                 Ad = k.Ad,
                                 Soyad = k.Soyad,
                                 TC = k.TC,
                                 Hastane = h.Adi,
                                 Poliklinik = p.Adi,
                                 RandevuTarihi = r.RandevuTarihi,
                                 OlustumaTarihi = r.OlusturulmaTarihi
                             }).ToList();
                return liste;
            }
        }
    }
}
