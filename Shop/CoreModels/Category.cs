using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreModels
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsShown { get; set; }
        public virtual IEnumerable<Product> Products { get; set; }
    }
}
