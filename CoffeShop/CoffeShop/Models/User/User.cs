using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeShop.Repository;

namespace CoffeShop.Models
{
    public class User : IRepoEntity
    {
        public User()
        {
            Active = true;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Role UserRole { get; set; }
        public CoffeShop UserShop { get; set; }
        public bool Active { get; set; }
    }
}
