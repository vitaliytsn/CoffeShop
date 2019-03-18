using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeShop.Repository;

namespace CoffeShop.Models
{
    public class ItemComponent : IRepoEntity
    {
        public Component CurrentComponent { get; set; }
        public double Amount { get; set; }
        public Item ComponentItem { get; set; }
    }
}
