using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EFCRUD.RegisterService
{
    public class ServiceRegister:IServiceRegister<Registers>
    {
        private readonly EntityContextFactory _contextFactory;
        private readonly NonqueryDataService<Registers> nonqueryDataService;
        public ServiceRegister(EntityContextFactory entityContextFactory)
        {
            _contextFactory = entityContextFactory;
            nonqueryDataService = new NonqueryDataService<Registers>(entityContextFactory);
        }

        public Registers Create(Registers entity)
        {
            return nonqueryDataService.Create(entity);
        }

        public bool HardDelete(Registers entity)
        {
            return nonqueryDataService.Delete(entity);
        }

        public Registers FindName(string name)
        {
            using EntityContext context = _contextFactory.CreateDbContext();
            return context.Set<Registers>().Where(b => b.Name == name).FirstOrDefault();
        }

        public IEnumerable<Registers> GetAll()
        {
            using EntityContext context = _contextFactory.CreateDbContext();
            return context.Set<Registers>().ToList();
        }

        public Registers GetById(int id)
        {
            using EntityContext context = _contextFactory.CreateDbContext();
            return context.Set<Registers>().Find(id);
        }
        public Registers Update(Registers entity)
        {
            return nonqueryDataService.Update(entity);
        }
    }
}
