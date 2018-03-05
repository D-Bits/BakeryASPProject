using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BakeryASP.Models;

namespace BakeryASP.Models
{
    public class Products
    {
        public int ProductKey { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
    }
}