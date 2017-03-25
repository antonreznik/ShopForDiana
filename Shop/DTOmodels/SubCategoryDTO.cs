using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOmodels
{
    public class SubCategoryDTO
    {
        public int SubCategoryId { get; set; }
        public string Name { get; set; }
        public bool IsShown { get; set; }
        public int CategoryId { get; set; }
        public IEnumerable<ProductDTO> Products { get; set; }
    }
}
