using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoffeShop.Models
{
    public class Item
    {
        public Item()
        {
                Group = new ItemGroup();
        }
        public int Id { get; set; }
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
