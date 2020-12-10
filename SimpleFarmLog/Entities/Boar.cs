using SimpleFarmLog.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFarmLog.Entities
{
    public class Boar : Animal
    {
        public int Number { get; set; }
        public Color Color { get; set; }

        public string HerdId { get; set; }
        public BoarHerd Herd { get; set; }

    }
}
