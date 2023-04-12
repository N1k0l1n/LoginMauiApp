using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.Models
{
   public class AnsweredHumanYearlyCallStat
    {
        public int month { get; set; }
        public int totalCalls { get; set; }
    }

    public class Result
    {
        public List<object> answredHumanWeeklyCallStats { get; set; }
        public List<object> answeredHumanMonthlyCallStats { get; set; }
        public List<object> unAnsweredWeeklyCallStats { get; set; }
        public List<object> unAnsweredMonthlyCallStats { get; set; }
        public List<AnsweredHumanYearlyCallStat> answeredHumanYearlyCallStats { get; set; }
        public List<UnAnsweredYearlyCallStat> unAnsweredYearlyCallStats { get; set; }
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

    public class APIResponse
    {
        public Result result { get; set; }
        public bool isSuccess { get; set; }
        public object errorMessage { get; set; }
    }

    public class UnAnsweredYearlyCallStat
    {
        public int month { get; set; }
        public int totalCalls { get; set; }
    }
}
