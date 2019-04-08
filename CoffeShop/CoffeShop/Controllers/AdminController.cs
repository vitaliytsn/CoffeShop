using CoffeShop.Data;
using CoffeShop.Models;
using CoffeShop.Models.ViewModels;
using CoffeShop.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;


namespace CoffeShop.Controllers
{
    public class AdminController : Controller
    {
        private readonly IRepository<ItemGroup, CoffeShopContext> _itemGroupRepository;
        private readonly IRepository<Item, CoffeShopContext> _itemRepository;
        private readonly IRepository<Component, CoffeShopContext> _componentRepository;
        private readonly IRepository<ItemComponent, CoffeShopContext> _itemComponentRepository;
        private readonly IRepository<Models.CoffeShop, CoffeShopContext> _coffeShopRepository;
        private readonly IRepository<User, CoffeShopContext> _userRepository;
        private readonly IRepository<Role, CoffeShopContext> _roleRepository;
        private readonly IRepository<ItemImage, CoffeShopContext> _itemImageRepository;
        private readonly IRepository<ComponentDelivery, CoffeShopContext> _componentDeliveryRepository;
        private readonly CoffeShopContext _context;
        public AdminController(IRepository<ComponentDelivery, CoffeShopContext> componentDeliveryRepository, IRepository<ItemImage, CoffeShopContext> itemImageRepository, IRepository<Role, CoffeShopContext> roleRepository, IRepository<User, CoffeShopContext> userRepository, IRepository<Models.CoffeShop, CoffeShopContext> coffeShopRepository, IRepository<ItemComponent, CoffeShopContext> itemComponentRepository, IRepository<Component, CoffeShopContext> componentRepository, CoffeShopContext context, IRepository<ItemGroup, CoffeShopContext> itemGroupRepository, IRepository<Item, CoffeShopContext> itemRepository)
        {
            _componentDeliveryRepository = componentDeliveryRepository;
            _componentRepository = componentRepository;
            _itemImageRepository = itemImageRepository;
            _roleRepository = roleRepository;
            _userRepository = userRepository;
            _coffeShopRepository = coffeShopRepository;
            _itemComponentRepository = itemComponentRepository;
            _itemGroupRepository = itemGroupRepository;
            _componentRepository = componentRepository;
            _context = context;
            _itemRepository = itemRepository;
            _itemGroupRepository = itemGroupRepository;
        }

        #region ItemGroup

        public async Task<IActionResult> ItemGroup_List()
        {
            return View(_itemGroupRepository.GetByQuery(x => x.Active == true));
        }


        public IActionResult ItemGroup_Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ItemGroup_Create([Bind("Id,Name,Description")] ItemGroup itemGroup)
        {
            if (ModelState.IsValid)
            {
                itemGroup.Active = true;
                _itemGroupRepository.Add(itemGroup);
                return RedirectToAction(nameof(ItemGroup_List));
            }
            return View(itemGroup);
        }


        public async Task<IActionResult> ItemGroup_Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemGroup = _itemGroupRepository.GetByID((int)id);
            if (itemGroup == null)
            {
                return NotFound();
            }
            return View(itemGroup);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ItemGroup_Edit(int id, [Bind("Id,Name,Description")] ItemGroup itemGroup)
        {
            if (id != itemGroup.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _itemGroupRepository.Update(itemGroup);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemGroupExists(itemGroup.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(ItemGroup_List));
            }
            return View(itemGroup);
        }
        private bool ItemGroupExists(int id)
        {
            return _itemGroupRepository.GetByID(id) == null;
        }
        #endregion


        #region Items

        public ActionResult Item_Create(int groupId)
        {
            Item item = new Item();
            ViewBag.GroupId = groupId;
            item.Group = _itemGroupRepository.GetByID(groupId);
            return View(new ItemVM { CurrentItem = item });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Item_Create(ItemVM itemVM)
        {
            itemVM.CurrentItem.Group = _itemGroupRepository.GetByID(itemVM.CurrentItem.Group.Id);
            itemVM.CurrentItem.Active = true;
            _itemRepository.Add(itemVM.CurrentItem);
            ViewBag.GroupId = itemVM.CurrentItem.Group.Id;

            ItemImage imageToSave;
            if (itemVM.UploadImage != null)
            {
                using (var stream = new MemoryStream())
                {
                    await itemVM.UploadImage.CopyToAsync(stream);
                    imageToSave = new ItemImage()
                    {
                        Active = true,
                        image = stream.ToArray(),
                        itemId = itemVM.CurrentItem.Id
                    };

                }
            }
            else
            {
                string[] arr = DefaultImage.image.Split(",");
                byte[] bytearr = new byte[arr.Length - 1];
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    bytearr[i] = Convert.ToByte(arr[i]);
                }
                imageToSave = new ItemImage()
                {
                    Active = true,
                    image = bytearr,
                    itemId = itemVM.CurrentItem.Id
                };
            }
            _itemImageRepository.Add(imageToSave);


            return RedirectToAction(nameof(ItemGroup_Edit), new { id = itemVM.CurrentItem.Group.Id });
        }
        public ActionResult Item_ListPartial(int X, int Y, int groupId)
        {
            ViewBag.Width = X / 10;
            ViewBag.Height = Y / 10;
            ViewBag.GroupId = groupId;

            List<Item> items = _context.Set<Item>().Include(item => item.Group).Include(item => item.Images).Where(x => x.Group.Id == groupId && x.Active == true)
                .ToList();

            // List<Item> items = _itemRepository.GetAll().Where(x=>x.Group.Id==groupId).ToList();
            return PartialView(items);
        }
        public ActionResult Item_Edit(int X, int Y, int itemId)
        {
            ViewBag.Width = X * 3;
            ViewBag.Height = Y * 3;
            Item item = _context.Set<Item>().Include(items => items.Group).Include(items => items.Images).Where(x => x.Id == itemId)
                .ToList().FirstOrDefault();
            ViewBag.GroupId = item.Group.Id;

            return View(new ItemVM { CurrentItem = item });
        }
        [HttpPost]
        public async Task<ActionResult> Item_Edit(ItemVM itemVM)
        {

            if (itemVM.UploadImage != null)
            {
                using (var stream = new MemoryStream())
                {
                    await itemVM.UploadImage.CopyToAsync(stream);

                    ItemImage imageToSave = new ItemImage()
                    {
                        Active = true,
                        image = stream.ToArray(),
                        itemId = itemVM.CurrentItem.Id
                    };
                    ItemImage itemToUpdate = _itemImageRepository.GetByQuery(x => x.itemId == itemVM.CurrentItem.Id)
                        .FirstOrDefault();
                    itemToUpdate.image = imageToSave.image;
                    _itemImageRepository.Update(itemToUpdate);

                }
            }

            _itemRepository.Update(itemVM.CurrentItem);
            return RedirectToAction(nameof(ItemGroup_Edit), new { id = itemVM.CurrentItem.Group.Id });
        }

        public ActionResult Item_Delete(int itemId)
        {
            return View(_context.Set<Item>().Include(y => y.Group).Where(x => x.Id == itemId).ToList().FirstOrDefault());
        }
        [HttpPost]
        public ActionResult Item_Delete(Item item)
        {
            Item itemToDelete = _itemRepository.GetByID(item.Id);
            itemToDelete.Active = false;
            _itemRepository.Update(itemToDelete);
            return RedirectToAction(nameof(ItemGroup_Edit), new { id = item.Group.Id });
        }
        #endregion

        #region Components

        public ActionResult Component_List()
        {
          
            return View(_componentRepository.GetByQuery(x => x.Active == true));
        }

        public ActionResult Component_Create()
        {
            List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> unitSelectListItems = new List<SelectListItem>
            {
                new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(Units.Штуки.ToString(),
                    Convert.ToString((int)Units.Штуки)),
                new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(Units.Грами.ToString(),
                    Convert.ToString((int)Units.Грами)),
                new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(Units.МіліЛітри.ToString(),
                    Convert.ToString((int)Units.МіліЛітри))
            };

            ViewBag.Units = unitSelectListItems;
            return View();
        }
        [HttpPost]
        public ActionResult Component_Create(Component component)
        {
            component.Active = true;
            _componentRepository.Add(component);
         
            return RedirectToAction(nameof(Component_List));
        }

        public ActionResult Component_Edit(int componentId)
        {
            List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> unitSelectListItems = new List<SelectListItem>
            {
                
                new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(Units.Штуки.ToString(),
                    Convert.ToString((int)Units.Штуки)){Selected = false},
                new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(Units.Грами.ToString(),
                    Convert.ToString((int)Units.Грами)){Selected = false},
            
                new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem("    ", "0"){Selected = true},
                new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(Units.МіліЛітри.ToString(),
                    Convert.ToString((int)Units.МіліЛітри)){Selected = false}
            };
            Component component = _componentRepository.GetByID(componentId);
            ViewBag.OldUnit= component.Unit;
            ViewBag.Units = unitSelectListItems;
            return View(component);
        }
        [HttpPost]
        public ActionResult Component_Edit(Component component)
        {
            if (component.Unit == 0) component.Unit = _componentRepository.GetByID(component.Id).Unit;
            _componentRepository.Update(component);
            return RedirectToAction(nameof(Component_List));
        }

        public ActionResult Component_Delete(int componentId)
        {
            return View(_componentRepository.GetByID(componentId));
        }
        [HttpPost]
        public ActionResult Component_Delete(Component component)
        {
            component = _componentRepository.GetByID(component.Id);
            component.Active = false;
            _componentRepository.Update(component);
            return RedirectToAction(nameof(Component_List));
        }
        #endregion

        #region ItemComponents

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

        public ActionResult ItemComponent_Edit(int itemComponentId)
        {
            ItemComponent itemComponent = _context.Set<ItemComponent>().Include(y => y.CurrentComponent).Include(y => y.ComponentItem)
                .Where(x => x.Id == itemComponentId).ToList().FirstOrDefault();

            return View(itemComponent);
        }
        [HttpPost]
        public ActionResult ItemComponent_Edit(ItemComponent itemComponent)
        {
            _itemComponentRepository.Update(itemComponent);

            return RedirectToAction(nameof(Item_Edit), new { itemId = itemComponent.ComponentItem.Id });
        }

        public ActionResult ItemComponent_Create(int itemId)
        {
            ItemComponent itemComponent = new ItemComponent
            {
                ComponentItem = _itemRepository.GetByID(itemId)
            };
            ViewBag.itemid = itemId;
            List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> selectListItems = new List<SelectListItem>();
            foreach (var component in _componentRepository.GetByQuery(x=>x.Active==true))
            {
                selectListItems.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(component.Name, component.Id.ToString()));
            }
            ViewBag.Components = selectListItems;
            return View(itemComponent);
        }

        [HttpPost]
        public ActionResult ItemComponent_Create(ItemComponent itemComponent)
        {
            itemComponent.ComponentItem = _itemRepository.GetByID(itemComponent.ComponentItem.Id);
            itemComponent.CurrentComponent = _componentRepository.GetByID(itemComponent.CurrentComponent.Id);
            itemComponent.Active = true;
            _itemComponentRepository.Add(itemComponent);
            ViewBag.itemId = itemComponent.ComponentItem.Id;
            return RedirectToAction(nameof(Item_Edit), new { itemId = itemComponent.ComponentItem.Id });
        }

        public ActionResult ItemComponent_Delete(int itemComponentId)
        {

            ItemComponent itemComponent = _context.Set<ItemComponent>().Include(item => item.ComponentItem).Include(item => item.CurrentComponent)
                .Where(x => x.Id == itemComponentId)
                .ToList().FirstOrDefault();
            ViewBag.itemId = itemComponent.ComponentItem.Id;
            return View(itemComponent);
        }
        [HttpPost]
        public ActionResult ItemComponent_Delete(ItemComponent itemComponent)
        {
            ItemComponent componentToDelete = _itemComponentRepository.GetByID(itemComponent.Id);
            componentToDelete.Active = false;
            _itemComponentRepository.Update(componentToDelete);
            return RedirectToAction(nameof(Item_Edit), new { itemId = itemComponent.ComponentItem.Id });
        }

        #endregion

        #region CoffeShop

        public ActionResult CoffeShop_List()
        {
            return View(_coffeShopRepository.GetAll());
        }

        public ActionResult CoffeShop_Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CoffeShop_Create(Models.CoffeShop coffeShop)
        {
            _coffeShopRepository.Add(coffeShop);
            return RedirectToAction(nameof(CoffeShop_List));
        }

        public ActionResult CoffeShop_Edit(int coffeShopId)
        {
            return View(_coffeShopRepository.GetByID(coffeShopId));
        }
        [HttpPost]
        public ActionResult CoffeShop_Edit(Models.CoffeShop coffeShop)
        {
            _coffeShopRepository.Update(coffeShop);
            return RedirectToAction(nameof(CoffeShop_List));
        }
        #endregion

        #region User

        public ActionResult User_ListPartial(int coffeShopId)
        {
            ViewBag.CoffeShopId = coffeShopId;
            List<User> users = _context.Set<User>().Include(item => item.UserShop)
                .Where(x => x.UserShop.Id == coffeShopId && x.Active).ToList();

            return PartialView(users);
        }

        public ActionResult User_Create(int coffeShopId)
        {
            User user = new User();
            user.UserShop.Id = coffeShopId;
            return View(user);
        }

        [HttpPost]
        public ActionResult User_Create(User user)
        {
            user.UserShop = _coffeShopRepository.GetByID(user.UserShop.Id);
            user.Active = true;
            user.UserRole = _roleRepository.GetByQuery(x => x.Name == "User").ToList().FirstOrDefault();
            _userRepository.Add(user);
            return RedirectToAction(nameof(CoffeShop_Edit), new { coffeShopId = user.UserShop.Id });
        }

        public ActionResult User_Edit(int userId)
        {
            User user = _context.Set<User>().Include(item => item.UserShop)
                .Where(x => x.Id == userId).ToList().FirstOrDefault();
            return View(user);
        }
        [HttpPost]
        public ActionResult User_Edit(User user)
        {
            _userRepository.Update(user);
            return RedirectToAction(nameof(CoffeShop_Edit), new { coffeShopId = user.UserShop.Id });
        }

        public ActionResult User_Delete(int userId)
        {
            User user = _context.Set<User>().Include(item => item.UserShop)
                .Where(x => x.Id == userId).ToList().FirstOrDefault();
            return View(user);
        }
        [HttpPost]
        public ActionResult User_Delete(User user)
        {
            user = _context.Set<User>().Include(item => item.UserShop).Include(item => item.UserRole)
                .Where(x => x.Id == user.Id).ToList().FirstOrDefault();
            user.Active = false;
            _userRepository.Update(user);
            return RedirectToAction(nameof(CoffeShop_Edit), new { coffeShopId = user.UserShop.Id });
        }
        #endregion

        #region ComponentDelivery

        public ActionResult ComponentDelivery_List()
        {
            if (HttpContext.Session.GetString("userRole") == null ||
                HttpContext.Session.GetString("userRole") != "Administrator")
                return RedirectToAction("Login", "Account");
            return View(_context.Set<ComponentDelivery>().Include(item => item.ComponentDelivered).Include(item => item.ItemDelivered).Where(x => x.Active == true));
        }

        public ActionResult ComponentDelivery_Create()
        {
            if (HttpContext.Session.GetString("userRole") == null ||
                HttpContext.Session.GetString("userRole") != "Administrator")
                return RedirectToAction("Login", "Account");
            List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> componentSelectListItems = new List<SelectListItem>();
            foreach (var component in _componentRepository.GetByQuery(x=>x.Active==true))
            {
                componentSelectListItems.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(component.Name +": "+ component.Unit.ToString().ToUpper(), component.Id.ToString()));
            }
            List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> coffeShopSelectListItems = new List<SelectListItem>();
            foreach (var coffeShop in _coffeShopRepository.GetAll())
            {
                coffeShopSelectListItems.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(coffeShop.Name + " " + coffeShop.Adress, coffeShop.Id.ToString()));
            }
        

            ViewBag.CoffeShops = coffeShopSelectListItems;
            ViewBag.Components = componentSelectListItems;
            return View();
        }
        [HttpPost]
        public ActionResult ComponentDelivery_Create(ComponentDelivery componentDelivery)
        {
            if (componentDelivery.ComponentDelivered != null)
                componentDelivery.ComponentDelivered =
                    _componentRepository.GetByID(componentDelivery.ComponentDelivered.Id);

            if (componentDelivery.ItemDelivered != null)
                componentDelivery.ItemDelivered = _itemRepository.GetByID(componentDelivery.ItemDelivered.Id);

            componentDelivery.CoffeShop = _coffeShopRepository.GetByID(componentDelivery.CoffeShop.Id);
            componentDelivery.DeliveryTime = DateTime.Now;
            componentDelivery.Active = true;
            _componentDeliveryRepository.Add(componentDelivery);
            return RedirectToAction("ComponentDelivery_List");
        }

        public ActionResult ItemDelivery_Create()
        {
            if (HttpContext.Session.GetString("userRole") == null ||
                HttpContext.Session.GetString("userRole") != "Administrator")
                return RedirectToAction("Login", "Account");
            List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> itemSelectListItems = new List<SelectListItem>();
            foreach (var item in _context.Set<Item>().Include(item => item.ItemComponents).Where(x => x.ItemComponents.Count == 0 && x.Active==true))
            {
                itemSelectListItems.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(item.Name, item.Id.ToString()));
            }
            List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> coffeShopSelectListItems = new List<SelectListItem>();
            foreach (var coffeShop in _coffeShopRepository.GetAll())
            {
                coffeShopSelectListItems.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(coffeShop.Name + " " + coffeShop.Adress, coffeShop.Id.ToString()));
            }


            ViewBag.Items = itemSelectListItems;
            ViewBag.CoffeShops = coffeShopSelectListItems;
         

            return View();
        }

        #endregion



    }
}
