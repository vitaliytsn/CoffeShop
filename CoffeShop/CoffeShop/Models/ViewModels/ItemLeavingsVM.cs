using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeShop.Models
{
    public class ItemLeavingsVM
    {
        public ItemLeavingsVM(Item item, double amount, Units unit)
        {
            Item = item;
            Amount = amount;
            Unit = unit;
        }

        public Item Item { get; set; }
        [Display(Name = "Кількість")]
        public double Amount { get; set; }
        [Display(Name = "Одиниця")]
        public Units Unit { get; set; }
    }
}
