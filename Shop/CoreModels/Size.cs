using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreModels
{
    public class Size
    {
        public int SizeId { get; set; }
        public string Name { get; set; }
        public bool IsAvailable { get; set; }
        public virtual IEnumerable<Product> Products { get; set; }
    }
}
