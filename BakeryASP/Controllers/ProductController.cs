using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BakeryASP.Models;

namespace BakeryASP.Controllers
{
    public class ProductController : Controller
    {

        BakeryEntities2 db = new BakeryEntities2();

        // GET: Product
        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }
    }
}
 