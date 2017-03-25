using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreModels
{
    public class SubCategory
    {
        public int SubCategoryId { get; set; }
        public string Name { get; set; }
        public bool IsShown { get; set; }
        public virtual IEnumerable<Product> Products { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
