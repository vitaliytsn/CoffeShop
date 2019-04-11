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
        public bool AlreadyUsed { get; set; }
        public DateTime DeliveryTime { get; set; }
        public CoffeShop CoffeShop { get; set; }
        public Component ComponentDelivered { get; set; }
        public Item ItemDelivered { get; set; }
        [Display(Name="Кількість")]
        [Required]
        public double Amount { get; set; }

        public double LeftOver { get; set; }

        [Display(Name = "Ціна")]
        [Required]
        public double DeliveryPrice { get; set; }

    }
}
