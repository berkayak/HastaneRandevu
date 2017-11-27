using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models;
using Repository;

namespace Business
{
    public class KisilerBusiness : BaseBusiness<Kisiler>
    {
        public Result Ekle(Kisiler kisi)
        {
            Result rs = new Result();
            try
            {
                KisiRepository ks = new KisiRepository();
                ks.Ekle(kisi);
                rs.HataYok();
                return rs;
            }
            catch (Exception ex)
            {
                rs.HataVar(ex.Message);
                return rs;
            }
        }

        public string KisiTCGetir(int ID)
        {
            KisiRepository ks = new KisiRepository();
            return ks.KisiTCGetir(ID);
        }
    }
}
