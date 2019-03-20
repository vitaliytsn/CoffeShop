using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CoffeShop.Repository;

namespace CoffeShop.Models
{
    public class ItemImage : IRepoEntity
    {
        public ItemImage()
        {
            Active = true;
        }
        public ItemImage(Item item, byte[] Image)
        {
            itemId = item.Id;
            image = Image;
        }
        public int itemId { get; set; }
        public byte[] image { get; set; }
        public bool Active { get; set; }
    }
}
