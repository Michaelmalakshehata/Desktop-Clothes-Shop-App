using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EFCRUD
{
    public class GenericDataServiceSoftDelete<T>:IDataServiceSoftDelete<T> where T :BaseModel
    {
        private readonly EntityContextFactory _contextFactory;
        private readonly NonqueryDataService<T> nonqueryDataService;
        public GenericDataServiceSoftDelete(EntityContextFactory entityContextFactory)
        {
            _contextFactory = entityContextFactory;
            nonqueryDataService = new NonqueryDataService<T>(entityContextFactory);
        }

        public T Create(T entity)
        {
            return nonqueryDataService.Create(entity);
        }

        public bool SoftDelete(T entity)
        {
           entity.IsDeleted = true;
            entity.DeleteDate = DateTime.Now;
           var T= Update(entity);
            if(T is null)
            {
                return false;
            }
            else
            {
                return true;
            }   
        }

        public T FindName(string name)
        {
            using EntityContext context = _contextFactory.CreateDbContext();
            return context.Set<T>().Where(b => b.Name == name &&b.IsDeleted==false).FirstOrDefault();
           
        }

        public IEnumerable<T> GetAll()
        {
            using EntityContext context = _contextFactory.CreateDbContext();
            return context.Set<T>().Where(b => b.IsDeleted == false).ToList();
        }

        public IEnumerable<T> GetallSoftDeleted()
        {
            using EntityContext context = _contextFactory.CreateDbContext();
            return context.Set<T>().Where(b => b.IsDeleted == true).ToList();
        }

        public T GetById(int id)
        {
            using EntityContext context = _contextFactory.CreateDbContext();
            return context.Set<T>().Find(id);
        }
        public T Update(T entity)
        {
            return nonqueryDataService.Update(entity);
        }

        public bool RestoreItem(T entity)
        {
            entity.IsDeleted = false;
            entity.RestoreDate= DateTime.Now;
           var T= Update(entity);
            if(T is null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public T FindDeletedItem(string item)
        {
            using EntityContext context = _contextFactory.CreateDbContext();
            return context.Set<T>().Where(b => b.Name==item && b.IsDeleted == true).FirstOrDefault();
        }
    }
}
