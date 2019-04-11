using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CoffeShop.Repository;

namespace CoffeShop.Models
{
  
    public class ComponentDelivery : IRepoEntity
    {      
        public  bool Active { get; set; }
        [Display(Name = "Використано")]
        public bool AlreadyUsed { get; set; }
        [Display(Name = "Дата Доставки")]
        public DateTime DeliveryTime { get; set; }
        public CoffeShop CoffeShop { get; set; }
        public Component ComponentDelivered { get; set; }
        public Item ItemDelivered { get; set; }
        [Display(Name="Кількість")]
        [Required]
        public double Amount { get; set; }
        [Display(Name = "Залишилось")]
        public double LeftOver { get; set; }

        [Display(Name = "Ціна")]
        [Required]
        public double DeliveryPrice { get; set; }

    }
}
