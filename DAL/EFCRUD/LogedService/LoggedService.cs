using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EFCRUD.LogedService
{
    public class LoggedService : ILoggedService<LogedIn>
    {
        private readonly EntityContextFactory _contextFactory;
        private readonly NonqueryDataService<LogedIn> nonqueryDataService;
        public LoggedService(EntityContextFactory entityContextFactory)
        {
            _contextFactory = entityContextFactory;
            nonqueryDataService = new NonqueryDataService<LogedIn>(entityContextFactory);
        }
        public LogedIn Create(LogedIn entity)
        {
            return nonqueryDataService.Create(entity);
        }

        public bool DeleteUserName(string username)
        {
            using EntityContext context = _contextFactory.CreateDbContext();
            LogedIn? user = context.Set<LogedIn>().Where(o => o.Name==username).FirstOrDefault();
            if (user is not null)
            {
                nonqueryDataService.Delete(user);
                return true;
            }
            return false;
        }

        public string GetUserName()
        {
            using EntityContext context = _contextFactory.CreateDbContext();
            string? username = context.Set<LogedIn>().Where(o => o.logged == true).Select(o=>o.Name).FirstOrDefault();
            if(username is null)
            {
                return string.Empty;
            }
            return username;
        }

        public LogedIn UpdateLoggedIn(string usernname)
        {
            using EntityContext context = _contextFactory.CreateDbContext();
            LogedIn? userLoged = context.Set<LogedIn>().Where(o => o.Name == usernname).FirstOrDefault();
            if(userLoged is null)
            {
                return new LogedIn();
            }
            userLoged.logged = true;
            return nonqueryDataService.Update(userLoged);
        }

        public LogedIn UpdateLoggedOut()
        {
            using EntityContext context = _contextFactory.CreateDbContext();
            LogedIn? userLoged = context.Set<LogedIn>().Where(o => o.logged == true).FirstOrDefault();
            if (userLoged is null)
            {
                return new LogedIn();
            }
            userLoged.logged = false;
            return nonqueryDataService.Update(userLoged);
        }
    }
}
