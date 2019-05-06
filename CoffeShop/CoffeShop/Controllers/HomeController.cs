using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CoffeShop.Data;
using Microsoft.AspNetCore.Mvc;
using CoffeShop.Models;
using Microsoft.AspNetCore.Http;

namespace CoffeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly CoffeShopContext _context;
        public HomeController(CoffeShopContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            try
            {
                ViewBag.Text = _context.Set<User>().Where(x => x.Id == (int)HttpContext.Session.GetInt32("userId")).ToList().FirstOrDefault().UserRole + "кабінет";

            }
            catch (Exception e)
            {
                ViewBag.Text = "Залогуйся щоб розпочати роботу";
            }
        

            return View();
        }
       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
