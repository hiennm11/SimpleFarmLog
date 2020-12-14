using SimpleFarmLog.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFarmLog.Dtos
{
    public class BoarDetailDto
    {
        public string Id { get; set; }
        public DateTime? StartDate { get; set; }
        public double? Weight { get; set; }
        public Gender Gender { get; set; }
        public int? Number { get; set; }
        public Color Color { get; set; }
        public int? HerdNumber { get; set; }
        public DateTime? HerdInitDate { get; set; }
    }
}
