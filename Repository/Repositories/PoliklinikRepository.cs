using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models;
using Repository.Data;

namespace Repository
{
    public class PoliklinikRepository : RepositoryBase<Poliklinik>
    {
        public List<Poliklinik> PoliklinikGetir(int HastaneID, bool eklenecekMi)
        {
            using (HastaneRandevuContext context = new HastaneRandevuContext())
            {
                var Poliklinikler = context.Polikliniks.Where(x => (x.Doktors.Any() || eklenecekMi ) && x.HastaneID == HastaneID).ToList();
                return Poliklinikler;
            }
        }

        public List<Poliklinik> PoliklinikGetir(int HastaneID)
        {
            return PoliklinikGetir(HastaneID, false);
        }
    }
}
