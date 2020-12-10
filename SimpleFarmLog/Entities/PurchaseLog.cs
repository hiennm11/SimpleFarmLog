using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFarmLog.Entities
{
    public class PurchaseLog
    {
        public string PurchaseId { get; set; }
        public string Id { get; set; }
        public decimal Price { get; set; }
        public DateTime PurchaseDate { get; set; }
        public double Amount { get; set; }


        public Ingredient Ingredient { get; set; }
        public Medicine Medicine { get; set; }

    }
}
