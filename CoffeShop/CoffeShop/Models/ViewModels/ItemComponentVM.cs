using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeShop.Models.ViewModels
{
    public class ItemComponentVM
    {
        public ItemComponent ItemComponentCurrent { get; set; }
        public List<Component> ComponentsList { get; set; }
    }
}
