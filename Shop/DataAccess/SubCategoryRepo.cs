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
    public class SubCategoryRepo : IRepository<SubCategory>
    {
        private EFContext _context;

        public SubCategoryRepo(EFContext context)
        {
            _context = context;
        }

        public void Create(SubCategory model)
        {
            _context.ProductSubCategories.Add(model);
            _context.SaveChanges();
        }

        public IQueryable<SubCategory> GetAll()
        {
            return _context.ProductSubCategories;
        }

        public SubCategory GetOne(int id)
        {
            return _context.ProductSubCategories.FirstOrDefault(x => x.SubCategoryId == id);
        }

        public void Update(SubCategory model)
        {
            var subCategoryFromBase = GetOne(model.SubCategoryId);
            if (subCategoryFromBase != null)
            {
                subCategoryFromBase.Name = model.Name;
                _context.SaveChanges();
            }
        }

        public void Visibility(SubCategory model)
        {
            var subCategoryFromBase = GetOne(model.SubCategoryId);
            if (subCategoryFromBase != null)
            {
                subCategoryFromBase.IsShown = model.IsShown;
                _context.SaveChanges();
            }
        }
    }
}
