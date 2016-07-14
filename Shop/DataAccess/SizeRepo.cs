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
    public class SizeRepo : IRepository<Size>
    {
        private EFContext _context;

        public SizeRepo(EFContext context)
        {
            _context = context;
        }

        public void Create(Size model)
        {
            _context.Sizes.Add(model);
            _context.SaveChanges();
        }

        public IQueryable<Size> GetAll()
        {
            return _context.Sizes;
        }

        public Size GetOne(int id)
        {
            return _context.Sizes.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Size model)
        {
            throw new NotImplementedException();
        }

        public void Visibility(Size model)
        {
            var sizeFromBase = GetOne(model.Id);
            if (sizeFromBase != null)
            {
                sizeFromBase.IsAvailable = model.IsAvailable;
                _context.SaveChanges();
            }
        }
    }
}
