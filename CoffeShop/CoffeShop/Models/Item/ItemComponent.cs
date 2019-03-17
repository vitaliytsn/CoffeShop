using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeShop.Models
{
    public class ItemComponent
    {
        public int Id { get; set; }
        public Component CurrentComponent { get; set; }
        public double amount { get; set; }
    }
}
