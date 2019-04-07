using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeShop.Data;
using CoffeShop.Models;
using CoffeShop.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoffeShop.Controllers
{
    public class RaportController : Controller
    {
        private readonly IRepository<ComponentDelivery, CoffeShopContext> _componentDeliveryRepository;
        private readonly IRepository<Component, CoffeShopContext> _componentRepository;
        private readonly CoffeShopContext _context;
        public RaportController(CoffeShopContext context, IRepository<ComponentDelivery, CoffeShopContext> componentDeliveryRepository, IRepository<Component, CoffeShopContext> componentRepository)
        {
            _context = context;
            _componentDeliveryRepository = componentDeliveryRepository;
            _componentRepository = componentRepository;
        }
        public IActionResult ComponentLeavings()
        {
            List<ComponentLeavingVM> componentLeavings = new List<ComponentLeavingVM>();

            foreach (var component in _componentRepository.GetAll())
            {
                double delivered=0.0;
                double selled=0.0;
                Units unit=Units.Штуки;
                foreach (var delivery in _context.Set<ComponentDelivery>()
                    .Include(item => item.ComponentDelivered).Where(x => x.ComponentDelivered.Id == component.Id)
                    .ToList())
                {
                    delivered += delivery.Amount;
                    unit = (Units)delivery.UnitsDelivered;
                }


                foreach (var order in _context.Set<Order>().Include(item => item.OrderItems).ToList())
                {
                    foreach (var orderedItem in order.OrderItems)
                    {
                        List<ItemComponent> itemComponents = _context.Set<ItemComponent>()
                            .Include(item => item.ComponentItem).Where(x => x.ComponentItem.Id == orderedItem.ItemId)
                            .ToList();

                        if (itemComponents.Count != 0)
                        {
                            ItemComponent itemComponent = itemComponents.Where(x => x.CurrentComponent.Id == component.Id)
                                .FirstOrDefault();
                            if(itemComponent!=null)
                            selled += itemComponent.Amount;
                               
                        }

                    }                
                }
                componentLeavings.Add(new ComponentLeavingVM(component,delivered-selled,unit));
            }

           
            return View(componentLeavings);
        }
    }
}