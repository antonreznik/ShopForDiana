using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class SubCategoryViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Введите наименование подкатегории")]
        [Display(Name = "Enter new subcategory name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Выберите категорию")]
        public int CategoryId { get; set; }

        public bool IsShown { get; set; }
        public IEnumerable<ProductViewModel> Products { get; set; }
    }
}
