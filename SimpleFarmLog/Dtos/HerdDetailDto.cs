using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFarmLog.Dtos
{
    public class HerdDetailDto
    {
        public string Id { get; set; }
        public int? Number { get; set; }
        public DateTime? InitDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
