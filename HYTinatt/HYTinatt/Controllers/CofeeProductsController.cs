using HYTinatt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HYTinatt.Controllers
{
    public class CofeeProductsController : Controller
    {
        // GET: CofeeProducts
        DataEntities data = new DataEntities();
        public ActionResult Index()
        {
            return View(data.CoffeeProducts.ToList());
        }
    }
}