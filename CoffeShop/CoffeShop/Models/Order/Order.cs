using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeShop.Repository;

namespace CoffeShop.Models
{
    public class Order : IRepoEntity
    {
        public User CreatorUser { get; set; }
        public List<Item> OrderedItems { get; set; }
    }
}
