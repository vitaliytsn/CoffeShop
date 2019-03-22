using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CoffeShop.Repository;

namespace CoffeShop.Models
{
    public class Component: IRepoEntity
    {
        public Component()
        {
            Active = true;
        }
        [Display(Name="Назва Складника")]
        public string Name { get; set; }
        [Display(Name = "Опис")]
        public  string Description { get; set; }

        public bool Active { get; set; }
    }
}
