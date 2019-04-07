using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CoffeShop.Repository;

namespace CoffeShop.Models
{
    public enum Units
    {
        Штуки=1,
        Грами = 2,
        МіліЛітри = 3,
    }
    public class ComponentDelivery : IRepoEntity
    {      
        public  bool Active { get; set; }
        public DateTime DeliveryTime { get; set; }
        public CoffeShop CoffeShop { get; set; }
        public Component ComponentDelivered { get; set; }
        public Item ItemDelivered { get; set; }
        [Display(Name = "Одиниця")]
        public Units UnitsDelivered { get; set; }
        [Display(Name="Кількість")]
        public double Amount { get; set; }

    }
}
