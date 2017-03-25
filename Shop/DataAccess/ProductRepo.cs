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
    public class ProductRepo : IRepository<Product>
    {
        private EFContext _context;

        public ProductRepo(EFContext context)
        {
            _context = context;
        }

        public void Create(Product model)
        {
            _context.Products.Add(model);
            _context.SaveChanges();
        }

        public IQueryable<Product> GetAll()
        {
            return _context.Products;
        }

        public Product GetOne(int id)
        {
            return _context.Products.FirstOrDefault(x => x.ProductId == id);
        }

        public void Update(Product model)
        {
            throw new NotImplementedException();
        }

        public void Visibility(Product model)
        {
            var productFromBase = GetOne(model.ProductId);
            if(productFromBase != null)
            {
                productFromBase.IsAvailable = model.IsAvailable;
                _context.SaveChanges();
            }
        }
    }
}
