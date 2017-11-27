using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models;
using Repository.Data;

namespace Repository
{
    public class IlceRepositive
    {
        public List<Ilce> IlceGetir(int IlID)
        {
            using (HastaneRandevuContext context = new HastaneRandevuContext())
            {
                var Ilceler = context.Ilces.Where(x => x.IlID == IlID).ToList();
                return Ilceler;
            }
        }
    }
}
