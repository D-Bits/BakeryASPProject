using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BakeryASP.Models;
using BakeryASP.Controllers;

/// Controller for registering new customers
namespace BakeryASP.Controllers
{
    public class RegistrationController : Controller
    {

        BakeryEntities db = new BakeryEntities();

        public ActionResult Index()
        {
           
        }

    }
}