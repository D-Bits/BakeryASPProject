using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BakeryASP.Models;



/// Controller for registering new customers

namespace BakeryASP.Controllers
{

    public class RegistrationController : Controller

    {

        BakeryEntities1 db = new BakeryEntities1();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]

        [ValidateAntiForgeryToken]

        public ActionResult Index
            ([Bind(Include =
            "PersonLastName, " +
            "PersonFirstName, " +
            "PersonEmail, " +
            "PersonPhone, ")
            ]Person p)

        {
            p.PersonDateAdded = DateTime.Now;
            db.People.Add(p);
            db.SaveChanges();

            return View("Result");

        }

        public ActionResult Result()
        {
            return View();
        }

    }

}