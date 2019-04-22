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
        public IActionResult ComponentLeavings(bool IsComponent)
        {
         
                if (IsComponent)
                    ViewBag.IsComponent = true;
                else
                    ViewBag.IsComponent = false;
            
            return View();
        }

        public ActionResult ProfitRaport()
        {
            ProfitRaportVM raportVm = new ProfitRaportVM();
            raportVm.DateFrom= Convert.ToDateTime(System.DateTime.Now.ToShortDateString());
            raportVm.DateTo=DateTime.Today;
            return View(raportVm);
        }
        [HttpPost]
        public ActionResult ProfitRaport(ProfitRaportVM profitRaport)
        {

            return View(profitRaport);
        }
        public ActionResult ProfitRaport_Partial(DateTime DateFrom, DateTime DateTo)
        {
           
            double MoneyIncome = 0.0;
            double MoneyProfit = 0.0;
           List<Order> ordersPerDay= _context.Set<Order>().Where(x => x.OrderDateTime.Date >= DateFrom.Date && x.OrderDateTime<=DateTo).ToList();
            foreach (var order in ordersPerDay)
            {
                MoneyIncome += order.FinalPrice;
                MoneyProfit += order.OrderCost;
            }

            ViewBag.MoneyIncome = MoneyIncome;
            ViewBag.MoneyProfit = MoneyProfit;
            return PartialView(ordersPerDay);
        }
    }
}