using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArnGames.DataAccess.Abstract
{
    public interface IGenericRepository<T> where T : class
    {
        T Insert(T t);
        void Delete(int id);
        T Update(T t);
        List<T> GetAllList();
        T GetById(int id);
    }
}
