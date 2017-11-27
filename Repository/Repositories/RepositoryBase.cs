using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models;
using Repository.Data;


namespace Repository
{
    public class RepositoryBase<T> where T : class
    {
        public List<T> Listele()
        {
            using (HastaneRandevuContext context = new HastaneRandevuContext())
            {
                return context.Set<T>().ToList();
            }
        }

        public virtual void Ekle(T entity)
        {
            using (HastaneRandevuContext context = new HastaneRandevuContext())
            {
                context.Set<T>().Add(entity);
                context.SaveChanges();
            }
        }

        public virtual void Sil(T entity)
        {
            using (HastaneRandevuContext context = new HastaneRandevuContext())
            {
                context.Set<T>().Attach(entity);
                context.Set<T>().Remove(entity);
                context.SaveChanges();
            }
        }

        public void Guncelle(T entity)
        {
            using (HastaneRandevuContext context = new HastaneRandevuContext())
            {
                context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
