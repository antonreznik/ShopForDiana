using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name="Enter category name")]
        public string Name { get; set; }
        public bool IsShown { get; set; }
    }
}
