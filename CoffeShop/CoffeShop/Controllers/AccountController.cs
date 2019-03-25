using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeShop.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
           return RedirectToAction("Index", "Home");
        }
    }
}