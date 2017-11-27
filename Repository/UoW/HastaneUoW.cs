using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models;
using Repository.Data;
using System.Data.Sql;
using System.Data.OleDb;

namespace Repository.UoW
{
    public class HastaneUoW : IUnitOfWork<Hastane>
    {
        public void Delete(Hastane entity)
        {
            using (HastaneRandevuContext context = new HastaneRandevuContext())
            {
                RandevuSil(entity.ID, context);
                DoktorSil(entity.ID, context);
                PoliklinikSil(entity.ID, context);
                HastaneSil(entity.ID, context);
                Commit(context);
                
                
                var liste = context.Database.ExecuteSqlCommand("EXEC sp_HastaneRandevuSistemi", "@TranType=13", "@ilceID=3");
            }
        }

        private void HastaneSil(int HastaneID, HastaneRandevuContext context)
        {
            var liste = context.Hastanes.Where(x => x.ID == HastaneID).ToList();
            context.Hastanes.RemoveRange(liste);
        }

        private void PoliklinikSil(int HastaneID, HastaneRandevuContext context)
        {
            var liste = context.Polikliniks.Where(x => x.HastaneID == HastaneID).ToList();
            context.Polikliniks.RemoveRange(liste);
        }

        private void DoktorSil(int HastaneID, HastaneRandevuContext context)
        {
            var liste = context.Doktors.Where(x => x.Poliklinik.Hastane.ID == HastaneID).ToList();
            context.Doktors.RemoveRange(liste);
        }

        private void RandevuSil(int HastaneID, HastaneRandevuContext context)
        {
            var liste = context.Randevus.Where(x => x.Poliklinik.Hastane.ID == HastaneID).ToList();
            context.Randevus.RemoveRange(liste);
        }

        public void Commit(Data.HastaneRandevuContext context)
        {
            context.SaveChanges();
        }
    }
}
