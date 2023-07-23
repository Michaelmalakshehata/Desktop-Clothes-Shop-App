using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EFCRUD
{
    public interface IDataServiceSoftDelete<T> where T :class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        T Create(T entity);
        T Update(T entity);
        bool SoftDelete(T entity);
        T FindName(string name);
        IEnumerable<T> GetallSoftDeleted();
        bool RestoreItem(T entity);
        T FindDeletedItem(string item);
    }
}
