using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FruitBazar.Models;
using System.Net.NetworkInformation;
using FruitBazar.Data;
using System.Security.Policy;

namespace FruitBazar.Controllers
{
    public class HomeController : Controller
    {
        private readonly FruitBazarDataContext _context;
        public HomeController(FruitBazarDataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {            
            return View();
        }

        public IActionResult FruitBoard()
        {
            return View(_context.fruits);
        }

        public IActionResult FruitDetails(int id)
        {            
            var fruit = _context.fruits.Find(id);
            return View(fruit);
        }

        public IActionResult About()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult About(GetInTouch getInTouch)
        {
            _context.getintouch.Add(getInTouch);
            _context.SaveChanges();
            return View();
        }
        

        public IActionResult Developer()
        {
            return View();
        }


        //[HttpPost]
        public IActionResult ShoppingCart(String fruitname, String quantity, String price)
        {
            var shoppingCart = new ShoppingCart()
            {
                fruit_name = fruitname,
                quantity = Convert.ToInt32(quantity),
                price = Convert.ToInt32(price)
            };

            if (shoppingCart.fruit_name != null)
            {
                _context.shoppingcart.Add(shoppingCart);
                _context.SaveChanges();

            }
            return View(_context.shoppingcart);
        }

        public IActionResult DeleteItem(int id)
        {
            var r = _context.shoppingcart.Find(id);
            _context.shoppingcart.Remove(r);
            _context.SaveChanges();
            return RedirectToAction("ShoppingCart");
        }

        public IActionResult Delivary()
        {
            return View();
        }

        public IActionResult CustomerLogin()
        {
            return View();
        }

        public IActionResult _Cash()
        {
            return View();
        }
        
        public IActionResult _bKashRocket()
        {
            return View();
        }

    }
}
