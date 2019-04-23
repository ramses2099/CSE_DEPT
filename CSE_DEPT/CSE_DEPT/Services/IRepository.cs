using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE_DEPT.Services
{
    public interface IRepository : IDisposable
    {
        void CrateObject(Object obj);
        void DeleteObject(Object obj);
        void UpdateObject(Object obj);
        List<Object> GetObject();

    }
}
