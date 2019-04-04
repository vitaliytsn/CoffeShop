﻿using CoffeShop.Repository;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoffeShop.Models
{
    public class Item : IRepoEntity
    {
        public Item()
        {
            Images= new List<ItemImage>();
            Group = new ItemGroup();
            Active = true;
        }
        [Display(Name = "Назва Товару")]
        public string Name { get; set; }
        [Display(Name = "Опис")]
        public string Description { get; set; }

        public ItemGroup Group { get; set; }
        public List<ItemComponent> ItemComponents { get; set; }
        public List<ItemImage> Images { get; set; }
        [Display(Name = "Ціна")]
        public double Price { get; set; }
        public bool Active { get; set; }
    }
}
