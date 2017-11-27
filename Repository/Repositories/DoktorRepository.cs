using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models;
using Repository.Data;

namespace Repository
{
    public class DoktorRepository : RepositoryBase<Doktor>
    {
        public List<Doktor> DoktorGetir(int PoliklinikID)
        {
            using (HastaneRandevuContext context = new HastaneRandevuContext())
            {
                var Doktorlar = context.Doktors.Where(x => x.PoliklinikID == PoliklinikID).ToList();
                return Doktorlar;
            }
        }        
    }
}
