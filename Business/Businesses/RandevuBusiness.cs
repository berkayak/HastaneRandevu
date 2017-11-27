using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models;

namespace Business
{
    public class RandevuBusiness : BaseBusiness<Randevu>
    {
        /// <summary>
        /// Alıdığı parametreler ile veritabanına randevu kaydeder
        /// </summary>
        public Result RandevuKaydet(string HastaTC, int HastaneID, int PolikkinikID, string RandevuTarihi)
        {
            Result rs = new Result();
            try
            {
                RandevuRepository temp = new RandevuRepository();
                if (!temp.RandevuVarMi(HastaTC, PolikkinikID))
                {
                    temp.RandevuKaydet(HastaTC, HastaneID, PolikkinikID, RandevuTarihi);
                    rs.HataYok();
                }
                else
                    rs.HataVar("Aynı TC ile aynı poliklinikten yalnız bir randevu alabilirsiniz");
                return rs;
            }
            catch (Exception ex)
            {
                rs.HataVar(ex.Message);
                return rs;
            }
        }

    }
}
