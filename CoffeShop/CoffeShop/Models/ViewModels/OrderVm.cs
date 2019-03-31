using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeShop.Models.ViewModels
{
    public class OrderVM
    {
        public OrderVM(List<Item> orderItems, User employee)
        {
            OrderItems = orderItems;
            Employee = employee;
        }

        public List<Item> OrderItems { get; set; }
        public User Employee { get; set; }
        public double FinalPrice { get; set; }
    }
}
