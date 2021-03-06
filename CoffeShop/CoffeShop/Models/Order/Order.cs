﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CoffeShop.Repository;

namespace CoffeShop.Models
{
    public class Order : IRepoEntity
    {
        public Order()
        {
            Active = true;
            Temp = true;
            OrderItems= new List<OrderItem>();
        }
        public bool Temp { get; set; }
        public User CreatorUser { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public bool Active { get; set; }
        [Display(Name="Час замовлення")]
        public DateTime OrderDateTime { get; set; }
        [Display(Name = "Ціна замовлення")]
        public double FinalPrice { get; set; }
        [Display(Name = "Собівартість")]
        public double OrderCost { get; set; }
    }
}
