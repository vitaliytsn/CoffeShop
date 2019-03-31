using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using CoffeShop.Data;
using CoffeShop.Models;
using CoffeShop.Models.ViewModels;
using CoffeShop.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoffeShop.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        private readonly IRepository<ItemGroup, CoffeShopContext> _itemGroupRepository;
        private readonly IRepository<Item, CoffeShopContext> _itemRepository;
        private readonly IRepository<Component, CoffeShopContext> _componentRepository;
        private readonly IRepository<ItemComponent, CoffeShopContext> _itemComponentRepository;
        private readonly IRepository<Models.CoffeShop, CoffeShopContext> _coffeShopRepository;
        private readonly IRepository<User, CoffeShopContext> _userRepository;
        private readonly IRepository<Role, CoffeShopContext> _roleRepository;
        private readonly CoffeShopContext _context;

        public UserController(IRepository<Role, CoffeShopContext> roleRepository, IRepository<User, CoffeShopContext> userRepository, IRepository<Models.CoffeShop, CoffeShopContext> coffeShopRepository, IRepository<ItemComponent, CoffeShopContext> itemComponentRepository, IRepository<Component, CoffeShopContext> componentRepository, CoffeShopContext context,IRepository<ItemGroup, CoffeShopContext> itemGroupRepository, IRepository<Item, CoffeShopContext> itemRepository)
        {
            _roleRepository = roleRepository;
            _userRepository = userRepository;
            _coffeShopRepository = coffeShopRepository;
            _itemComponentRepository = itemComponentRepository;
            _itemGroupRepository = itemGroupRepository;
            _componentRepository = componentRepository;
            _context = context;
            _itemRepository = itemRepository;
            
        }
    public ActionResult MainOrder(List<int> items)
    {
        List<Item> orderItems = (from item in items select _itemRepository.GetByID(item)).ToList(); 
            ViewBag.arr = items;
            return View(orderItems);
        }

        public ActionResult ItemGroup_ListPartial(List<int> items)
        {
            List<ItemGroup> groups= _itemGroupRepository.GetAll().ToList();
            ViewBag.arr = items;
            return PartialView(groups);
        }
        public ActionResult ItemGroup_Components(int? itemGroupId, List<int> items)
        {
            if (itemGroupId == null)
            {
                return NotFound();
            }

            var itemGroup = _itemGroupRepository.GetByID((int)itemGroupId);
            if (itemGroup == null)
            {
                return NotFound();
            }
            ViewBag.arr = items;
            return PartialView(itemGroup);
        }

        [HttpGet]
        public ActionResult Item_AddToOrder(int ItemId, List<int> items)
        {
            items.Add(ItemId);
            return RedirectToAction(nameof(MainOrder), new { items = items });
        }

        [HttpGet]
        public ActionResult Item_RemoveFromOrder(int ItemId, List<int> items)
        {
            items.Remove(ItemId);
            return RedirectToAction(nameof(MainOrder), new { items = items });
        }

        public ActionResult Order_Accept(List<int> items)
        {
            List<Item> orderedItems = (from item in items select _itemRepository.GetByID(item)).ToList();
            User employee = _userRepository.GetByID((int)HttpContext.Session.GetInt32("userId"));
            OrderVM acceptedOrder = new OrderVM(orderedItems,employee);
            foreach (var orderedItem in orderedItems)
            {
                acceptedOrder.FinalPrice += orderedItem.Price;
            }

            Order order = new Order();
            order.CreatorUser = employee;
            order.OrderedItems = orderedItems;
            _context.Set<Order>().Add(order);
            return View(acceptedOrder);
        }

        public ActionResult Item_ListPartial(int X, int Y, int groupId, List<int> items)
        {
            ViewBag.Width = X / 12;
            ViewBag.Height = Y / 12;
            ViewBag.GroupId = groupId;
            ViewBag.arr = items;
            List<Item> groupItems = _context.Set<Item>().Include(item => item.Group).Where(x => x.Group.Id == groupId && x.Active == true)
                .ToList();

            return PartialView(groupItems);
        }

    }
}