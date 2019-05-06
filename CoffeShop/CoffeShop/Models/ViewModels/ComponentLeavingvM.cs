using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CoffeShop.Repository;

namespace CoffeShop.Models
{
    public class ComponentLeavingVM:IRepoEntity
    {
        public ComponentLeavingVM(Component component,double amount, Units unit)
        {
            Component = component;
            Amount = amount;
            Unit = unit;
        }

        public Component Component { get; set; }
        [Display(Name="Кількість")]
        public double Amount { get; set; }
        [Display(Name = "Одиниця")]
        public Units Unit { get; set; }

    }
}
