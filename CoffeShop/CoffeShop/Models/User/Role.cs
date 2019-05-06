using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeShop.Repository;

namespace CoffeShop.Models
{
    public class Role : IRepoEntity
    {
        public string Name { get; set; }
    }
}
