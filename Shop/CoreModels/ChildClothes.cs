using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreModels
{
    public class ChildClothes : BaseProduct
    {
        public virtual IEnumerable<Size> Sizes { get; set; }
        public virtual IEnumerable<Color> Colors { get; set; }
    }
}
