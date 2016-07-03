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

        [Required(ErrorMessage = "Введите наименование категории")]
        [Display(Name="Enter new category name")]
        public string Name { get; set; }
        public bool IsShown { get; set; }
    }
}
