using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CoffeShop.Data;
using CoffeShop.Models;
using CoffeShop.Repository;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CoffeShop.Controllers
{
    public class AdminController : Controller
    {
        private readonly IRepository<ItemGroup, CoffeShopContext> _itemGroupRepository;
        private readonly IRepository<Item, CoffeShopContext> _itemRepository;
        public AdminController(IRepository<ItemGroup, CoffeShopContext> itemGroupRepository, IRepository<Item, CoffeShopContext> itemRepository)
        {
            _itemRepository = itemRepository;
            _itemGroupRepository = itemGroupRepository;
        }

        public async Task<IActionResult> CoffeGroupsList()
        {
            return View(_itemGroupRepository.GetAll());
        }

     
        public async Task<IActionResult> CoffeGroupDetails(int? id)
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

       
        public IActionResult CreateCoffeGroup()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCoffeGroup([Bind("Id,Name,Description")] ItemGroup itemGroup)
        {
            if (ModelState.IsValid)
            {
                _itemGroupRepository.Add(itemGroup);
                return RedirectToAction(nameof(CoffeGroupsList));
            }
            return View(itemGroup);
        }

    
        public async Task<IActionResult> EditCoffeGroup(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemGroup = _itemGroupRepository.GetByID((int) id);
            if (itemGroup == null)
            {
                return NotFound();
            }
            return View(itemGroup);
        }

        public ActionResult CreateItemInGroup(int groupId)
        {
            Item item = new Item();
            item.Group = _itemGroupRepository.GetByID(groupId);
            return View(item);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateItemInGroup(Item item)
        {
            item.Group = _itemGroupRepository.GetByID(item.Group.Id);
            _itemRepository.Add(item);
            return RedirectToAction(nameof(CoffeGroupsList));
        }
        public ActionResult ItemListPartial(int X, int Y,int groupId)
        {
            ViewBag.Width = X / 12;
            ViewBag.Height = Y / 12;
            List<Item> items = _itemRepository.GetAll().Where(x=>x.Group.Id==groupId).ToList();
            return PartialView(items);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditCoffeGroup(int id, [Bind("Id,Name,Description")] ItemGroup itemGroup)
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
                return RedirectToAction(nameof(CoffeGroupsList));
            }
            return View(itemGroup);
        }

  /*      // GET: Admin/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemGroup = await _context.ItemGroups
                .FirstOrDefaultAsync(m => m.Id == id);
            if (itemGroup == null)
            {
                return NotFound();
            }

            return View(itemGroup);
        }

        // POST: Admin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var itemGroup = await _context.ItemGroups.FindAsync(id);
            _context.ItemGroups.Remove(itemGroup);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        */
        private bool ItemGroupExists(int id)
        {
            return _itemGroupRepository.GetByID(id)==null;
        }
    }
}
