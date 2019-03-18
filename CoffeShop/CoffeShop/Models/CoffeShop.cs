using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeShop.Repository;

namespace CoffeShop.Models
{
    public class CoffeShop : IRepoEntity
    {
        public int Id { get;set; }
        public string Name { get; set; }

        public string Adress { get; set; }
    }
}
