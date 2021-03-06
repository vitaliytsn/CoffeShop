﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CoffeShop.Repository;

namespace CoffeShop.Models
{
    public class ItemComponent : IRepoEntity
    {
        public ItemComponent()
        {
            Active = true;
        }
        public Component CurrentComponent { get; set; }
        [Display(Name = "Кількість")]
        public double Amount { get; set; }
        public Item ComponentItem { get; set; }
        public bool Active { get; set; }
    }
}
