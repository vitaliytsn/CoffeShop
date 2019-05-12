using CoffeShop.Data;
using CoffeShop.Models;
using CoffeShop.Models.ViewModels;
using CoffeShop.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeShop.Components
{
    public class ItemOrderListViewComponent : ViewComponent
    {
        private readonly IRepository<ItemGroup, CoffeShopContext> _itemGroupRepository;
        private readonly CoffeShopContext _context;
        public ItemOrderListViewComponent(IRepository<ItemGroup, CoffeShopContext> itemGroupRepository, CoffeShopContext context)
        {
            _context = context;
            _itemGroupRepository = itemGroupRepository;
        }
        public async Task<IViewComponentResult> InvokeAsync( int groupId, List<int> items)
        {
            int X = 1000;
            int Y = 800;
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

            return View(orderItemsVM);
        }
    }
}
