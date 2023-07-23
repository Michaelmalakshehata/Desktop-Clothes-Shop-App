using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EFCRUD.LogedService
{
    public interface ILoggedService<LogedIn> 
    {
        string GetUserName();
        LogedIn Create(LogedIn entity);
        LogedIn UpdateLoggedIn(string usernname);
        LogedIn UpdateLoggedOut();
        bool DeleteUserName(string username);
    }
}
