using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeShop.Models
{
    public class Order
    {
        public int Id { get; set; } 
        public User CreatorUser { get; set; }
        public List<Item> OrderedItems { get; set; }
    }
}
