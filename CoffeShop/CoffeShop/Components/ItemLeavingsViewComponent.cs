using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeShop.Data;
using CoffeShop.Models;
using CoffeShop.Models.ViewModels;
using CoffeShop.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoffeShop.Components
{
    public class ItemLeavingsViewComponent: ViewComponent
    {
        private CoffeShopContext _context;
        private readonly IRepository<ItemComponent, CoffeShopContext> _itemComponentRepository;
        private readonly IRepository<Item, CoffeShopContext> _itemRepository;
        public ItemLeavingsViewComponent(IRepository<Item, CoffeShopContext> itemRepository, CoffeShopContext context, IRepository<ItemComponent, CoffeShopContext> itemComponentRepository)
        {
            _itemRepository = itemRepository;
            _itemComponentRepository = itemComponentRepository;
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int groupId,bool Editible,int X,int Y)
        {
            List<ItemLeavingsVM> componentLeavings = new List<ItemLeavingsVM>();

            foreach (var item in _itemRepository.GetByQuery(x => x.Active == true).ToList())
            {
                double delivered = 0.0;
                double selled = 0.0;
                Units unit = Units.Штуки;
                foreach (var delivery in _context.Set<ComponentDelivery>()
                    .Include(y => y.ComponentDelivered).Where(x => x.ComponentDelivered.Id == item.Id)
                    .ToList())
                {
                    delivered += delivery.Amount;
                    // unit = (Units)delivery.UnitsDelivered;
                }


                foreach (var order in _context.Set<Order>().Include(y => y.OrderItems).ToList())
                {
                    foreach (var orderedItem in order.OrderItems)
                    {
                        List<ItemComponent> itemComponents = _context.Set<ItemComponent>()
                            .Include(y => y.ComponentItem).Where(x => x.ComponentItem.Id == orderedItem.ItemId)
                            .ToList();

                        if (itemComponents.Count != 0)
                        {
                            ItemComponent itemComponent = itemComponents.Where(x => x.CurrentComponent.Id == item.Id)
                                .FirstOrDefault();
                            if (itemComponent != null)
                                selled += itemComponent.Amount;

                        }

                    }
                }
                componentLeavings.Add(new ItemLeavingsVM(item, delivered - selled, unit));
            }



            return View(componentLeavings);
        }


    }
}
