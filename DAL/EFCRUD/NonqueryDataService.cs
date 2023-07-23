using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EFCRUD
{
    public class NonqueryDataService<T> where T : class
    {
        private readonly EntityContextFactory _contextFactory;
        public NonqueryDataService(EntityContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }
        public T Create(T entity)
        {
            using EntityContext context = _contextFactory.CreateDbContext();
           EntityEntry<T> createResult =  context.Set<T>().Add(entity);
             context.SaveChanges();
            return createResult.Entity;
        }
        public bool Delete(T entity)
        {
            using EntityContext context = _contextFactory.CreateDbContext();
             context.Set<T>().Remove(entity);
             context.SaveChanges();
            return true;
        }

        public T Update(T entity)
        {
            using EntityContext context = _contextFactory.CreateDbContext();
              context.Set<T>().Update(entity);
             context.SaveChanges();
            return entity;
        }
    }
}
