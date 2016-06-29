using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IRepository<T>
    {
        void Create(T model);
        T GetOne(int id);
        IQueryable<T> GetAll();
        void Update(T model);
        void Hide(int id);
        void Show(int id);
    }
}
