using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ElectronicStore.Models;

namespace ElectronicStore.Controllers
{
    public class ProductController : Controller
    {
        public bool islog = false;
        public ViewResult Index()
        {   
            ViewBag.log = islog ? true : false;
            return View();
        }

        public ViewResult Login()
        {
            return View();
        }

        public ViewResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public ViewResult AddProduct(Product producto)
        {
            Repository.AddProduct(producto);
            return View("Thanks",producto);
        }
    }
}
