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
    public class CategoryRepo : IRepository<Category>
    {
        private EFContext _context;

        public CategoryRepo(EFContext context)
        {
            _context = context;    
        }

        public void Create(Category model)
        {
            _context.ProductCategories.Add(model);
            _context.SaveChanges();
        }

        public IQueryable<Category> GetAll()
        {
            return _context.ProductCategories;
        }

        public Category GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public void Hide(int id)
        {
            throw new NotImplementedException();
        }

        public void Show(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Category model)
        {
            throw new NotImplementedException();
        }
    }
}
