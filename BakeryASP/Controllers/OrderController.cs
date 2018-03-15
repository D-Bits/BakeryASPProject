using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BakeryASP.Models;

namespace BakeryASP.Controllers
{
    public class OrderController : Controller
    {
        BakeryEntities2 db = new BakeryEntities2();
        
        Order o = new Order();

        // GET: Order

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "SaleDate, EmployeeKey, " +
                                                  "CustomerKey, ProductKey, SaleDetailPriceCharged, " +
                                                  "SaleDetailQuantity, SaleDetailDiscount, SaleDetailSaleTaxPercent, " +
                                                  "SaleDetailEatInTax, ItemsOrdered, SubTotal, Total")]Order o)
        {
            
            o.ItemsOrdered = o.ProductKey + o.SaleDetailQuantity;
            o.SubTotal = o.ItemsOrdered * o.SaleDetailPriceCharged;
            o.Total = o.SubTotal * (1 + o.SaleDetailSaleTaxPercent);
            if(o.EatIn > 0)
            {
                o.EatIn = o.Total * (1 + o.SaleDetailEatInTax);
            }

            return View("Result");

        }
        public ActionResult Result()
        {
            return View();
        }

        
    }
}