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

        public IRepository<Category> CategoryRepository => _categoryRepository ?? new CategoryRepo(_context);
    }
}
