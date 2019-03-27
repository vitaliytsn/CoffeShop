using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using CoffeShop.Data;
using CoffeShop.Models;
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
    public ActionResult MainOrder(bool newOrder)
        {            
            List<Item> items = _itemRepository.GetAll().ToList();
            List<int> arr = (from item in items select item.Id).ToList();
            ViewBag.arr = arr;
            return View(items);
        }

        public ActionResult ItemGroup_Partial(List<int> items)
        {
            List<ItemGroup> groups= _itemGroupRepository.GetAll().ToList();
            ViewBag.arr = items;
            return PartialView(groups);
        }
        public async Task<IActionResult> ItemGroup_Components(int? itemGroupId)
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
            return PartialView(itemGroup);
        }

        public ActionResult Item_ListPartial(int X, int Y, int groupId)
        {
            ViewBag.Width = X / 12;
            ViewBag.Height = Y / 12;
            ViewBag.GroupId = groupId;

            List<Item> items = _context.Set<Item>().Include(item => item.Group).Where(x => x.Group.Id == groupId && x.Active == true)
                .ToList();

            // List<Item> items = _itemRepository.GetAll().Where(x=>x.Group.Id==groupId).ToList();
            return PartialView(items);
        }

    }
}