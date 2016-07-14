using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreModels
{
    public class Size
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsAvailable { get; set; }
        public virtual IEnumerable<Color> Colors { get; set; }
        public virtual IEnumerable<Product> Products { get; set; }
    }
}
