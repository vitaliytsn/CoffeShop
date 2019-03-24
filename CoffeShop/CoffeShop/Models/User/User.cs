using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CoffeShop.Repository;
using Microsoft.AspNetCore.Http.Connections;

namespace CoffeShop.Models
{
    public class User : IRepoEntity
    {
        public User()
        {
            UserShop = new CoffeShop();
            Active = true;
        }
        [Display(Name="Ім'я")]
        public string Name { get; set; }
        [Display(Name = "Прізвище")]
        public string Surname { get; set; }
        public Role UserRole { get; set; }
        public CoffeShop UserShop { get; set; }
        public bool Active { get; set; }
    }
}
