using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Common.Models;

namespace Business
{
    public class GetLists
    {
        public List<Il> IlGetir()
        {
            IlRepositive temp = new IlRepositive();
            return temp.Listele();
        }

        public List<Ilce> IlceGetir(int ID)
        {
            IlceRepositive temp = new IlceRepositive();
            return temp.IlceGetir(ID);
        }

        public List<Hastane> HastaneGetir(int ID, bool eklenecekMi)
        {
            HastaneRepository temp = new HastaneRepository();
            return temp.HastaneGetir(ID,eklenecekMi);
        }

        public List<Hastane> HastaneGetir(int ID)
        {
            return HastaneGetir(ID, false);
        }

        public List<Poliklinik> PoliklinikGetir(int ID, bool eklenecekMi)
        {
            PoliklinikRepository temp = new PoliklinikRepository();
            return temp.PoliklinikGetir(ID, eklenecekMi);
        }

        public List<Poliklinik> PoliklinikGetir(int ID)
        {
            return PoliklinikGetir(ID, false);
        }

        public List<Doktor> DoktorGetir(int ID)
        {
            DoktorRepository temp = new DoktorRepository();
            return temp.DoktorGetir(ID);
        }

        public List<Randevu> DoluSaatler(int ID)
        {
            RandevuRepository temp = new RandevuRepository();
            return temp.DoluSaatler(ID);
        }

        public object RandevularıListele(DateTime baslangic, DateTime bitis)
        {
            RandevuRepository rd = new RandevuRepository();
            return rd.Getir(baslangic, bitis);
        }

        public object RandevularıListele(string tc)
        {
            RandevuRepository rd = new RandevuRepository();
            return rd.Getir(tc);
        }
    }
}
