using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeShop.Models.ViewModels
{
    public class OrderedItemVm
    {
        public OrderedItemVm(Item item)
        {
            Item = item;
            Amount = 0;
        }
        public Item Item { get; set; }
        public int Amount { get; set; }
    }
}
