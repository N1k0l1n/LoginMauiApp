using LoginApp.Models;
using LoginApp.Services;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.ViewModels
{
    public class CallStatsViewModel
    {

        public ObservableCollection<CallStats> CallStatsList { get; set; } = new ObservableCollection<CallStats>();

        private readonly CallStatsDataService _callStatsDataService;
        public CallStatsViewModel()
        {
            try
            {
                var callStats = CallStatsDataService.Instance.GetAllCallStatsAsync();
                if (callStats != null)
                {                  
                    CallStatsList.Add(callStats);                   
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Generic Exception Handler: {ex}");
            }


        }

        private void GetAllCallStats()
        {
            //await api call
            var callStatsList = _callStatsDataService.GetAllCallStatsAsync();

        }
    }
}
