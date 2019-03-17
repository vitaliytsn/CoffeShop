using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeShop.Models
{
    public class ItemGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        private List<Item> GroupItems { get; set; }
    }
}
