using Context;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private EFContext _databaseContext;
        private DbSet<T> _dbSet;

        public GenericRepository()
        {
            _databaseContext = new EFContext();
            _dbSet = _databaseContext.Set<T>();
        }

        public void Create(T model)
        {
            _dbSet.Add(model);
            _databaseContext.SaveChanges();
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet;
        }

        public T GetOne(int id)
        {
            return _dbSet.Find(id);
        }

        public void Update(T model)
        {
            _databaseContext.Entry(model).State = EntityState.Modified;
            _databaseContext.SaveChanges();
        }

        public void Visibility(T model)
        {
            throw new NotImplementedException();
        }
    }
}
