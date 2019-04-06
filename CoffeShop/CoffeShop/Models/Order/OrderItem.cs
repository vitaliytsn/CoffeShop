using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeShop.Models
{
    public class OrderItem
    {
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
