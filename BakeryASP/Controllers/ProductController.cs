using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BakeryASP.Models;
using BakeryASP.Controllers;

namespace BakeryASP.Controllers
{
    public class ProductController : Controller
    {

        BakeryEntities db = new BakeryEntities();

        // GET: Product
        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }
    }
}
 