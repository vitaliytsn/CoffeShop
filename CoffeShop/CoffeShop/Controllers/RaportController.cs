using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using CoffeShop.Data;
using CoffeShop.Models;
using CoffeShop.Models.ViewModels;
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

            foreach (var component in _componentRepository.GetByQuery(x=>x.Active==true).ToList())
            {
                double delivered=0.0;
                double selled=0.0;
                Units unit=Units.Штуки;
                foreach (var delivery in _context.Set<ComponentDelivery>()
                    .Include(item => item.ComponentDelivered).Where(x => x.ComponentDelivered.Id == component.Id)
                    .ToList())
                {
                    delivered += delivery.Amount;
                   // unit = (Units)delivery.UnitsDelivered;
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

        public ActionResult ProfitRaport()
        {
            ProfitRaportVM raportVm = new ProfitRaportVM();
            raportVm.DateFrom= Convert.ToDateTime(System.DateTime.Now.ToShortDateString());
            raportVm.DateTo=DateTime.Today;
            return View(raportVm);
        }
        public ActionResult ProfitRaport_Partial(DateTime DateFrom, DateTime DateTo)
        {
           
            double MoneyProfit = 0.0;
           List<Order> ordersPerDay= _context.Set<Order>().Where(x => x.OrderDateTime.Date >= DateFrom.Date && x.OrderDateTime<=DateTo).ToList();
            foreach (var order in ordersPerDay)
            {
                MoneyProfit += order.FinalPrice;
            }

            ViewBag.MoneyProfit = MoneyProfit;
            return PartialView(ordersPerDay);
        }
    }
}