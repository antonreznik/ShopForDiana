using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class SizeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<ColorViewModel> Colors { get; set; }
    }
}
