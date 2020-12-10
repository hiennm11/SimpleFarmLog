using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFarmLog.Entities
{
    public class Ingredient
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }

        public List<PurchaseLog> PurchaseLogs { get; set; }      
        public List<MixLog> MixLogs { get; set; }

    }
}
