using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFarmLog.Entities
{
    public class Fodder
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }        
        public DateTime CreateDate { get; set; }


        public ICollection<Ingredient> Ingredients { get; set; }
        public ICollection<BoarHerd> BoarHerds { get; set; }
        public List<SeedLog> SeedLogs { get; set; }
        public List<MixLog> MixLogs { get; set; }


    }
}
