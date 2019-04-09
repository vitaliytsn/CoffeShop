using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeShop.Models
{
    public class Leavings
    {
        public Component Component { get; set; }
        public Item Item { get; set; }

        public double Amount { get; set; }
        public double LeavingsPrice { get; set; }
    }
}
