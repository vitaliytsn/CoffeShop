using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeShop.Models
{
    public class Component
    {
        public  int Id { get; set; }
        [Display(Name="Назва")]
        public string Name { get; set; }

    }
}
