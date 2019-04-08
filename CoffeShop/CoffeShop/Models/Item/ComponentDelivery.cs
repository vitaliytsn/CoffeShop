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
        public DateTime DeliveryTime { get; set; }
        public CoffeShop CoffeShop { get; set; }
        public Component ComponentDelivered { get; set; }
        public Item ItemDelivered { get; set; }
        [Display(Name="Кількість")]
        public double Amount { get; set; }

    }
}
