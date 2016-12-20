using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreModels;
using Context;

namespace DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private EFContext _context = new EFContext();
        private IRepository<Category> _categoryRepository;
        private IRepository<Product> _productRepository;
        private IRepository<Size> _sizeRepository;
        private IRepository<SubCategory> _subCategoryRepository;

        public IRepository<Category> CategoryRepository => _categoryRepository ?? new CategoryRepo(_context);
        public IRepository<Product> ProductRepository => _productRepository ?? new ProductRepo(_context);
        public IRepository<Size> SizeRepository => _sizeRepository ?? new SizeRepo(_context);
        public IRepository<SubCategory> SubCategoryRepository => _subCategoryRepository ?? new SubCategoryRepo(_context);       
    }
}
