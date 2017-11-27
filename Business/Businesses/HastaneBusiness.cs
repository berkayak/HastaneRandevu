using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models;
using Repository;

namespace Business
{
    public class HastaneBusiness : BaseBusiness<Hastane>
    {
        public override Result Sil(Hastane entity)
        {
            HastaneRepository temp = new HastaneRepository();
            Result result = new Result();
            try
            {
                temp.Sil(entity);
                result.HataYok();
                return result;
            }
            catch (Exception)
            {
                result.HataVar();
                return result;
            }
        }
    }
}
