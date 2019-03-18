﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CoffeShop.Repository;

namespace CoffeShop.Models
{
    public class Component: IRepoEntity
    {
        [Display(Name="Назва")]
        public string Name { get; set; }
        [Display(Name = "Опис")]
        public  string Description { get; set; }
    }
}
