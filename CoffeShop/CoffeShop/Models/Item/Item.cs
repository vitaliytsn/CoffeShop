using System.Collections.Generic;

namespace CoffeShop.Models
{
    public class Item
    {
        public Item()
        {
                Group = new ItemGroup();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descrition { get; set; }
        public ItemGroup Group { get; set; }
        public List<ItemComponent> ItemComponents { get; set; }
        public List<ItemImage> Images { get; set; }
        public double Price { get; set; }
    }
}
