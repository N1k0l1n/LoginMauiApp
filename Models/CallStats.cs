using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.Models
{
     public class CallStats
    {
        public int totalAnweredCallsThisMonth { get; set; }
        public int totalAnweredCallsThisWeek { get; set; }
        public int totalAnweredCallsThisYear { get; set; }
        public int totalUnAnweredCallsThisMonth { get; set; }
        public int totalUnAnweredCallsThisWeek { get; set; }
        public int totalUnAnweredCallsThisYear { get; set; }
        public int totalCalls { get; set; }
        public int totalAnswredCalls { get; set; }
        public int totalUnAnswredCalls { get; set; }
    }
}
