using CoreModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
    public class EFContext : DbContext
    {
        public EFContext() : base("Shop") {}
        public DbSet<Category> ProductCategories { get; set; }
        public DbSet <Product> Products { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<SubCategory> ProductSubCategories { get; set; }
    }
}
