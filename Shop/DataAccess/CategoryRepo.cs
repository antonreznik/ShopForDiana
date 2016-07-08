using Context;
using CoreModels;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            return _context.ProductCategories.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Category model)
        {
            var categoryFromBase = GetOne(model.Id);
            if (categoryFromBase != null)
            {
                categoryFromBase.Name = model.Name;
                _context.SaveChanges();
            }
        }

        public void Visibility(Category model)
        {
            var categoryFromBase = GetOne(model.Id);
            if (categoryFromBase != null)
            {
                categoryFromBase.IsShown = model.IsShown;
                _context.SaveChanges();
            }
        }    
    }
}
