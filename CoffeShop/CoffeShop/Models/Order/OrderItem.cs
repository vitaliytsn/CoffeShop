﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeShop.Repository;

namespace CoffeShop.Models
{
    public class OrderItem:IRepoEntity
    {
        public OrderItem()
        {
                
        }
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }

        public double ItemPrice { get; set; }

        public double ItemCost { get; set; }
    }
}
