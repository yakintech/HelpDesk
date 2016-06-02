using HelpDesk.Data.Models.ORM.Context;
using HelpDesk.Data.Models.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Business.BL.Repository
{

    public class GenericRepository<T> : IDisposable where T : BaseEntity
    {
        public HelpDeskContext db;
        public DbSet<T> _dbcontext;
        public GenericRepository()
        {
            db = new HelpDeskContext();
            _dbcontext = db.Set<T>();
        }
        public void SaveChanges()
        {
            db.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _dbcontext.Where(x => x.IsDeleted == false).ToList();
        }




        public List<T> GetListWithQuery(Expression<Func<T, bool>> lambda)
        {
            return _dbcontext.Where(lambda).Where(x => x.IsDeleted == false).ToList();
        }

        public bool Any(Expression<Func<T, bool>> lambda)
        {
            return _dbcontext.Where(x => x.IsDeleted == false).Any(lambda);
        }

        public T FirstOrDefault(Expression<Func<T, bool>> lambda)
        {
            return _dbcontext.FirstOrDefault(lambda);
        }

        public bool Delete(int id)
        {
            var entity = db.Set<T>().FirstOrDefault(x => x.ID == id);

            if (entity != null)
            {
                entity.DeletedDate = DateTime.Now;
                entity.IsDeleted = true;
                db.SaveChanges();
                return true;
            }

            return false;
        }


        public bool Add(T entity)
        {
            if (entity != null)
            {
                entity.AddDate = DateTime.Now;
                entity.UpdateDate = DateTime.Now;
                entity.IsDeleted = false;
                _dbcontext.Add(entity);
                SaveChanges();
                return true;
            }
            return false;
        }

        //Db dispose etme işlemi aşağıda gerçekleşmektedir dispose database bağlantısını kapatır! 
        public void Dispose()
        {
            db.Dispose();
            GC.SuppressFinalize(db);
        }
    }

}
