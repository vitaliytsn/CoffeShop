using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeShop.Data;
using CoffeShop.Models;
using CoffeShop.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoffeShop.Controllers
{
    public class AccountController : Controller
    {
        private readonly IRepository<User, CoffeShopContext> _userRepository;
        private readonly IRepository<Role, CoffeShopContext> _roleRepository;
        private readonly CoffeShopContext _context;

        public AccountController(CoffeShopContext context,IRepository<Role, CoffeShopContext> roleRepository, IRepository<User, CoffeShopContext> userRepository)
        {
            _roleRepository = roleRepository;
            _userRepository = userRepository;
            _context = context;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            User repoUser = _context.Set<User>().Include(item => item.UserRole).Where(x => x.Email == user.Email && x.password==user.password)
                .ToList().FirstOrDefault();
            if (repoUser != null)
            {
                HttpContext.Session.SetInt32("userId", (repoUser.Id));
                // HttpContext.Session.SetString("userRole","Admin");
                HttpContext.Session.SetString("userRole", (repoUser.UserRole.Name));
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Error = "Невірний пароль або пошта";
                return View();
            }
        }

        public ActionResult Logout()
        {
            foreach (var cookie in Request.Cookies.Keys)
            {
                Response.Cookies.Delete(cookie);
            }

            return RedirectToAction("Login", "Account");
        }
   
    }
}