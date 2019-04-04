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
        [Required]
        [EmailAddress]
        [Display(Name="Електронна пошта")]
        public string Email { get; set; }
        [Required]
        [Display(Name="Ім'я")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Прізвище")]
        public string Surname { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name="Пароль")]
        public string password { get; set; }
        [Required]
        public Role UserRole { get; set; }
        [Required]
        public CoffeShop UserShop { get; set; }
        public bool Active { get; set; }
    }
}
