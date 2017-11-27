using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Data;

namespace Repository
{
    public interface IUnitOfWork<T>
    {

        void Commit(HastaneRandevuContext context);
    }


}
