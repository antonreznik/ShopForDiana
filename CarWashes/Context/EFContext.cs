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
        public EFContext() : base("Washes"){}
        public DbSet<Washer> Washes { get; set; }
    }
}
