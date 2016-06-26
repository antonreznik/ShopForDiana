using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceInterfaces
{
    public interface IService<T>
    {
        void Create(T model);
        T GetOne(object id);
        IEnumerable<T> GetAll();
        void Update(T model);
        void DeleteById(object id);
        void DeleteByModel(T model);
    }
}
