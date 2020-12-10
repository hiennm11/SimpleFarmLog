using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFarmLog.Entities
{
    public class SeedLog
    {
        public string HerdId { get; set; }
        public string FodderId { get; set; }
        public DateTime SeedDate { get; set; }
        public double Amount { get; set; }


        public Fodder Fodder { get; set; }
        public BoarHerd BoarHerd { get; set; }

    }
}
