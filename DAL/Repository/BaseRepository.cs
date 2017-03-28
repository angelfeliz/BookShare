using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
   public class BaseRepository<T> : IRepository<T> where T : class
    {
        private BookShopContext Context;
        private DbSet<T> DbSet;
        public BaseRepository(BookShopContext context) {
            Context = context;
            DbSet = Context.Set<T>();
        }
        public void Add(T entity)
        {
            try
            {
                DbSet.Add(entity);
                Context.SaveChanges();
            }
            catch (Exception e) {
                throw;
            }            
        }

        public ICollection<T> GetAll()
        {
           return DbSet.ToList();
        }

        public T GetById(int Id)
        {
            return DbSet.Find(Id);
        }
    }
}
