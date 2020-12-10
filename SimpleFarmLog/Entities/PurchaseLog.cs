using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFarmLog.Entities
{
    public class PurchaseLog
    {
        public string Id { get; set; }
        public double Price { get; set; }
        public DateTime PurchaseDate { get; set; }
        public double Quantity { get; set; }


        public Ingredient Ingredient { get; set; }
        public Medicine Medicine { get; set; }

    }
}
