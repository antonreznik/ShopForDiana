using Context;
using CoreModels;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class WasherRepo : IRepository<Washer>
    {
        private EFContext _context;

        public WasherRepo(EFContext context)
        {
            this._context = context;
        }

        public void Create(Washer model)
        {
            _context.Washes.Add(model);
            _context.SaveChanges();
        }

        public void DeleteById(object id)
        {
            throw new NotImplementedException();
        }

        public void DeleteByModel(Washer model)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Washer> GetAll()
        {
            return _context.Washes;
        }

        public Washer GetOne(object id)
        {
            throw new NotImplementedException();
        }

        public void Update(Washer model)
        {
            throw new NotImplementedException();
        }
    }
}
