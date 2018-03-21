using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BakeryASP.Models;

namespace BakeryASP.Models
{
    public class Sales
    {
        public int SaleKey { get; set; }
        public DateTime SaleDate { get; set; }
        public int CustomerKey { get; set; }
        public int EmployeeKey { get; set; }
    }
}