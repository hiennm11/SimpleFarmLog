using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFarmLog.Entities
{
    public class MixLog
    {
        public string IngredientId { get; set; }
        public string FodderId { get; set; }
        public double IngredientAmount { get; set; }
        public DateTime MixDate { get; set; } = DateTime.Now;


        public Ingredient Ingredient { get; set; }
        public Fodder Fodder { get; set; }

    }
}
