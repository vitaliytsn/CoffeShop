using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CoffeShop.Repository;

namespace CoffeShop.Models
{
    public class Item : IRepoEntity
    {
        public Item()
        {
                Group = new ItemGroup();
        }
        [Display(Name="Назва")]
        public string Name { get; set; }
        [Display(Name = "Опис")]
        public string Description { get; set; }
        
        public ItemGroup Group { get; set; }
        public List<ItemComponent> ItemComponents { get; set; }
        public List<ItemImage> Images { get; set; }
        public double Price { get; set; }
    }
}
