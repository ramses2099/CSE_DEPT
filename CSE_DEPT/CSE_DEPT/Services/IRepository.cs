using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE_DEPT.Services
{
    public interface IRepository<T> where T : class
    {
        void CrateObject(T obj);
        void DeleteObject(T obj);
        void UpdateObject(T obj);
        List<T> GetObject();

    }
}
