using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFarmLog.Entities
{
    public class InjectLog
    {
        public string HerdId { get; set; }
        public string MedicineId { get; set; }
        public DateTime InjectDate { get; set; }
        public int Amount { get; set; }

        public BoarHerd BoarHerd { get; set; }
        public Medicine Medicine { get; set; }

    }
}
