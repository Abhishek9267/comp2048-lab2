using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {

            string[] product = new string[3];
            product[0] = "Laptop";
            product[1] = "Tablet";
            product[2] = "Desktop";
            ViewData["product"] = product;
            return View();
        }
        public string Details(string product)
        {



            string message = "You have selected the product" + product;
            return message;
        }

    }
}