using SimpleFarmLog.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFarmLog.Entities
{
    public class Animal
    {
        public string Id { get; set; }
        public DateTime StartDate { get; set; }
        public double? Weight { get; set; }
        public Gender Gender { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
