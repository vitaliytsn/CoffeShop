using CoffeShop.Data;
using CoffeShop.Models;
using CoffeShop.Models.ViewModels;
using CoffeShop.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public UserController(IRepository<Role, CoffeShopContext> roleRepository, IRepository<User, CoffeShopContext> userRepository, IRepository<Models.CoffeShop, CoffeShopContext> coffeShopRepository, IRepository<ItemComponent, CoffeShopContext> itemComponentRepository, IRepository<Component, CoffeShopContext> componentRepository, CoffeShopContext context, IRepository<ItemGroup, CoffeShopContext> itemGroupRepository, IRepository<Item, CoffeShopContext> itemRepository)
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
        public ActionResult MainOrder(string selected, List<int> items, int X, int Y)
        {

            if (HttpContext.Session.GetString("userRole") == null)
                return RedirectToAction("Login", "Account");
            if (selected != null)
            {
                List<MainOrderDataModel> modms = JsonConvert.DeserializeObject<MainOrderDataModel[]>(selected).ToList();
                foreach (MainOrderDataModel modm in modms)
                {
                    for (int i = 0; i < modm.Amount; i++)
                    {
                        items.Add(modm.ItemId); 
                    }
                }
            }
            List<Item> orderItems = new List<Item>();
            orderItems = (from item in items.ToList() select _context.Set<Item>().Include(x => x.Group).Include(x => x.Images).Where(y => y.Id == item).FirstOrDefault()).ToList();

           


            ViewBag.arr = items;
            ViewBag.Width = X/10;
            ViewBag.Height = Y/10;

            return View(orderItems);
        }

        public ActionResult ItemGroup_ListPartial(List<int> items)
        {
            List<ItemGroup> groups = _itemGroupRepository.GetAll().ToList();
            ViewBag.arr = items;
            return PartialView(groups);
        }
        public ActionResult ItemGroup_Components(int? itemGroupId, List<int> items)
        {
            if (HttpContext.Session.GetString("userRole") == null)
                return RedirectToAction("Login", "Account");
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
            return View(itemGroup);
        }
        [HttpPost]
        public ActionResult ItemGroup_Components(string get)
        {
            return View();
        }

        public ActionResult Order_Delete(int Id)
        {
            return View(_context.Set<Order>().Include(item => item.OrderItems).Where(x => x.Id == Id).FirstOrDefault());
        }
        [HttpPost]
        public ActionResult Order_Delete(Order order)
        {
            order = _context.Set<Order>().Where(x => x.Id == order.Id).FirstOrDefault();
            order.Active = false;
            _context.Update(order);
            _context.SaveChanges();
            return RedirectToAction("Order_ListOfUser");
        }

        [HttpGet]
        public ActionResult Item_AddToOrder(int ItemId, List<int> items, int X, int Y)
        {
            if (HttpContext.Session.GetString("userRole") == null)
                return RedirectToAction("Login", "Account");
            items.Add(ItemId);
            return RedirectToAction(nameof(MainOrder), new { items = items, X = X, Y = Y });
        }

        [HttpGet]
        public ActionResult Item_RemoveFromOrder(int ItemId, List<int> items)
        {
            items.Remove(ItemId);
            return RedirectToAction(nameof(MainOrder), new { items = items });
        }

        public ActionResult Order_Accept(List<int> items)
        {
            if (HttpContext.Session.GetString("userRole") == null)
                return RedirectToAction("Login", "Account");

            List<Item> orderedItems = (from item in items select _itemRepository.GetByID(item)).ToList();
            User employee = _userRepository.GetByID((int)HttpContext.Session.GetInt32("userId"));
            OrderVM acceptedOrder = new OrderVM(orderedItems, employee);
            double FinalPrice = 0.0;
            foreach (var orderedItem in orderedItems)
            {
                FinalPrice += orderedItem.Price;
            }

            acceptedOrder.FinalPrice = FinalPrice;
            Order order = new Order
            {
                CreatorUser = employee
            };

            // order.OrderItems = 
            order.FinalPrice = FinalPrice;
            order.OrderDateTime = DateTime.Now;
            order.Active = true;

            List<OrderItem> OrderItems = new List<OrderItem>();
            foreach (var orderedItem in orderedItems)
            {
                OrderItems.Add(new OrderItem() { Item = orderedItem, ItemId = orderedItem.Id });
            }
            //Przeniesc do servisu

            foreach (var orderItem in OrderItems)
            {
                List<ItemComponent> ItemComponents = _context.Set<Item>().Include(y => y.ItemComponents)
                    .Where(x => x.Id == orderItem.Item.Id).FirstOrDefault().ItemComponents;

                ItemComponents = (from ItemComponent in ItemComponents
                                  select _context.Set<ItemComponent>().Include(y => y.CurrentComponent).Where(y => y.Id == ItemComponent.Id)
                                      .FirstOrDefault()).ToList();


                if (ItemComponents.Count == 0)
                {
                    List<ComponentDelivery> deliveries = _context.Set<ComponentDelivery>().Include(y => y.ItemDelivered)
                        .Where(y => y.AlreadyUsed == false && y.ItemDelivered.Id == orderItem.Item.Id).OrderByDescending(x => x.DeliveryTime).ToList();
                    ComponentDelivery currentDelivery = deliveries.FirstOrDefault();
                    if (currentDelivery != null)
                    {
                        orderItem.ItemCost = currentDelivery.DeliveryPrice / currentDelivery.Amount;
                        currentDelivery.LeftOver -= 1;


                        if (currentDelivery.LeftOver == 0) currentDelivery.AlreadyUsed = true;
                    }
                }
                else
                {
                    foreach (var itemComponent in ItemComponents)
                    {
                        List<ComponentDelivery> deliveries = _context.Set<ComponentDelivery>().Include(x => x.ComponentDelivered).
                            Where(y => y.AlreadyUsed == false && y.ComponentDelivered.Id == itemComponent.CurrentComponent.Id).OrderByDescending(x => x.DeliveryTime).ToList();

                        ComponentDelivery currentDelivery = deliveries.FirstOrDefault();
                        if (currentDelivery != null)
                        {
                            orderItem.ItemCost += itemComponent.Amount / currentDelivery.Amount *
                                                  currentDelivery.DeliveryPrice;
                            if (currentDelivery.LeftOver >= itemComponent.Amount) currentDelivery.LeftOver -= itemComponent.Amount;
                            else
                            {
                                double toRemove = itemComponent.Amount - currentDelivery.LeftOver;
                                currentDelivery.LeftOver = 0;
                                currentDelivery.AlreadyUsed = true;
                                deliveries[1].LeftOver -= toRemove;
                            }
                        }
                    }
                }
                orderItem.ItemPrice = orderItem.Item.Price;
                // _context.Set<OrderItem>().Add(orderItem);
            }



            order.OrderItems = OrderItems;
            foreach (var orderItem in OrderItems) order.OrderCost += orderItem.ItemCost;

            _context.Set<Order>().Add(order);
            _context.SaveChanges();



            return View(acceptedOrder);
        }

        public ActionResult Order_ListOfUser()
        {
            if (HttpContext.Session.GetString("userRole") == null)
                return RedirectToAction("Login", "Account");
            return View(_context.Set<Order>().Include(x => x.CreatorUser).Where(item => item.CreatorUser.Id == (int)HttpContext.Session.GetInt32("userId")).OrderBy(x => x.OrderDateTime));
        }

        public ActionResult Item_ListPartial(int X, int Y, int groupId, List<int> items)
        {
            ViewBag.Width = X / 10;
            ViewBag.Height = Y / 10;
            ViewBag.GroupId = groupId;
            ViewBag.arr = items;

            List<Item> itemsVM = _context.Set<Item>().Include(item => item.Group).Include(item => item.Images).Where(x => x.Group.Id == groupId && x.Active == true)
                .ToList();
            List<OrderedItemVm> orderItemsVM = new List<OrderedItemVm>();
            foreach (var item in itemsVM)
            {
                orderItemsVM.Add(new OrderedItemVm(item));
            }

            return PartialView(orderItemsVM);
        }
        [HttpPost]
        public ActionResult Item_ListPartial(string getepassdata)
        {
            return View();
        }

        public ActionResult ItemInfo(int X, int Y, int itemId, List<int> items)
        {
            ViewBag.arr = items;
            ViewBag.Width = X * 3;
            ViewBag.Height = Y * 3;
            Item item = _context.Set<Item>().Include(Items => Items.Group).Include(Items => Items.Images).Where(x => x.Id == itemId)
                .ToList().FirstOrDefault();
            ViewBag.GroupId = item.Group.Id;

            return View(new ItemVM { CurrentItem = item });
        }

        public ActionResult ItemComponent_ListPartial(int itemId)
        {
            List<ItemComponent> itemComponents = new List<ItemComponent>();

            itemComponents = _context.Set<ItemComponent>().Include(y => y.CurrentComponent).Include(y => y.ComponentItem)
                .Where(x => x.ComponentItem.Id == itemId && x.Active == true)
                .ToList();
            //  itemComponents.Add(temComponent);


            ViewBag.ItemId = itemId;
            return PartialView(itemComponents);
        }

    }
}