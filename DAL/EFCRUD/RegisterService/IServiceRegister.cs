using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EFCRUD.RegisterService
{
    public interface IServiceRegister<Registers>
    {
        Registers GetById(int id);
        IEnumerable<Registers> GetAll();
        Registers Create(Registers entity);
        Registers Update(Registers entity);
        bool HardDelete(Registers entity);
        Registers FindName(string name);
    }
}
