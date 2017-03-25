using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Create(T model);
        T GetOne(int id);
        IQueryable<T> GetAll();
        void Update(T model);
        void Visibility(T model);
    }
}
