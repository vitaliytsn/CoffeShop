using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeShop.Repository;

namespace CoffeShop.Models
{
    public enum Units
    {
        Штуки=3,
        Кілограми = 2,
        Літри = 3,
    }
    public class ComponentDelivery : IRepoEntity
    {      
        public CoffeShop CoffeShop { get; set; }
        public Component ComponentDelivered { get; set; }

        public Units UnitsDelivered { get; set; }

    }
}
