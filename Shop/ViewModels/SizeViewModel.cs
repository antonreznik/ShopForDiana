using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class SizeViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Введите наименование размера")]
        [Display(Name = "Enter new size")]
        public string Name { get; set; }
        public bool IsAvailable { get; set; }
    }
}
