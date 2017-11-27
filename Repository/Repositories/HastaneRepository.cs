using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models;
using Repository.Data;

namespace Repository
{
    public class HastaneRepository : RepositoryBase<Hastane>
    {
        public List<Hastane> HastaneGetir(int IlceID, bool eklenecekMi)
        {
            using (HastaneRandevuContext context = new HastaneRandevuContext())
            {
                var Hastaneler = context.Hastanes.Where(x => (x.Polikliniks.Any(y=>y.Doktors.Any()) || eklenecekMi )&& x.Ilce.ID == IlceID).ToList();
                return Hastaneler;
            }
        }

        public List<Hastane> HastaneGetir(int IlceID)
        {
            return HastaneGetir(IlceID, false);
        }

        public override void Sil(Hastane entity)
        {
            UoW.HastaneUoW sil = new UoW.HastaneUoW();
            sil.Delete(entity);
        }
    }
}
