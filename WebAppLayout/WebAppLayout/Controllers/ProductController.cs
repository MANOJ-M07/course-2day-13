using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppLayout.Models;

namespace WebAppLayout.Controllers
{
    public class ProductController : Controller
    {
        List<Product> listProducts = new List<Product>()
        {
            new Product() {Id=1, Name="EarBuds",Company="Oppo",Price=2500},
              new Product() {Id=2, Name="Laptop",Company="Xiaomi",Price=65000},
                new Product() {Id=3, Name="EarPhone",Company="OnePlus",Price=4200},
                  new Product() {Id=4, Name="Wifi",Company="TpLink",Price=3500},
                  new Product() {Id=5,Name="Keyboard",Company="Microsoft",Price=2300}
        };
        // GET: Product
        public ActionResult Index()
        {
            //viewBag
            //ViewData
            //TempData
            ViewData["Message"] = "Welcome to products";
            ViewBag.noP = listProducts.Count;
            return View(listProducts);
        }

        public ActionResult TempEx()
        {
            TempData["msg"] = "I am coming from temp Example";
            return RedirectToAction("Index","Home");
        }
    }
}