using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFarmLog.Entities
{
    public class BoarHerd
    {
        public string Id { get; set; }
        public int? Number { get; set; }
        public DateTime? InitDate { get; set; }
        public DateTime? EndDate { get; set; }

        public List<Boar> Boars { get; set; }
        public List<InjectLog> InjectLogs { get; set; }
        public List<SeedLog> SeedLogs { get; set; }       

    }
}
