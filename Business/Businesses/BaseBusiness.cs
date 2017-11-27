using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models;
using Repository;


namespace Business
{
    public class BaseBusiness<T> where T : class
    {
        /// <summary>
        /// Generic ekleme islemi.
        /// </summary>
        public virtual void Ekle(T entity)
        {
            RepositoryBase<T> temp = new RepositoryBase<T>();
            temp.Ekle(entity);
        }

        /// <summary>
        /// Generic guncelleme islemi. Result nesnesi dondurur
        /// </summary>
        public virtual Result Guncelle(T entity)
        {
            Result rs = new Result();
            try
            {
                RepositoryBase<T> temp = new RepositoryBase<T>();
                temp.Guncelle(entity);
                rs.HataYok();
                return rs;
               }
            catch(Exception ex)
            {
                rs.HataVar(ex.Message);
                return rs;
            }
        }

        /// <summary>
        /// Generic silme islemi. Result nesnesi döndürür
        /// </summary>
        public virtual Result Sil(T entity)
        {
            Result rs = new Result();
            try
            {
                RepositoryBase<T> temp = new RepositoryBase<T>();
                temp.Sil(entity);
                rs.HataYok();
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
