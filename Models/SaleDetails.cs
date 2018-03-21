using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BakeryASP.Models;

namespace BakeryASP.Models
{
    public class SaleDetails
    {
        public int SaleDetailKey { get; set; }
        public int SaleKey { get; set; }
        public int ProductKey { get; set; }
        public decimal SaleDetailPriceCharged { get; set; }
        public int SaleDetailQuantity { get; set; }
        public decimal SaleDetailDiscount { get; set; }
        public decimal SaleDetailSaleTaxPercent { get; set; }
        public decimal SaleDetailEatInTax { get; set; }
    }
}