using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeShop.Models
{
    public class ItemImage
    {
        public ItemImage()
        {

        }
        public ItemImage(Item item, byte[] Image)
        {
            itemId = item.Id;
            image = Image;
        }
        [Key]
        public int id { get; set; }
        public int itemId { get; set; }
        public byte[] image { get; set; }
    }
}
