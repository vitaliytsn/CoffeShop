using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CoffeShop.Repository;

namespace CoffeShop.Models
{
    public class CoffeShop : IRepoEntity
    {
        [Display(Name= "Назва кав'ярні")]
        public string Name { get; set; }
        [Display(Name = "Адреса кав'ярні")]
        public string Adress { get; set; }
    }
}
