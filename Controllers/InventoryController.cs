using Inventory.Data;
using Inventory.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Sockets;

namespace Inventory.Controllers
{
    public class InventoryController : Controller
    {
        private readonly DataContext _context;

        public InventoryController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Inventories.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddInventory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddInventory(InventoryItem item)
        {
            if (ModelState.IsValid)
            {
                if (item.Id == 0)
                    _context.Inventories.Add(item);
                else
                    _context.Update(item);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(item);
        }

        [HttpGet]
        public IActionResult DeleteInventory(int id)
        {
            var item = _context.Inventories.Find(id);
            if (item != null)
            {
                _context.Inventories.Remove(item);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
