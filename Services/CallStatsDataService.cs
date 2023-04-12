using LoginApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LoginApp.Services
{
    public class CallStatsDataService
    {
        public string token { get; set; }
        private readonly HttpClient _httpCLient;
        private readonly string _url;
        private readonly JsonSerializerOptions _jsonSerializerOptions;


        public static CallStatsDataService Instance { get; set; }
        static CallStatsDataService()
        {
            Instance = new CallStatsDataService();
        }



        public CallStatsDataService()
        {
            _httpCLient = new HttpClient();
            //Dev Only
            _url = "https://wucmanager-dev.ikanbi.com/api";
        }

        //GET ALL CALLS STATS
        public CallStats GetAllCallStatsAsync()
        {

            CallStats callStats = null;

            try
            {
                _httpCLient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                HttpResponseMessage response = _httpCLient.GetAsync($"{_url}/Dashboard/getCallsStats").Result;

                if (response.IsSuccessStatusCode)
                {
                    string content = response.Content.ReadAsStringAsync().Result;

                    APIResponse apiResponse = System.Text.Json.JsonSerializer.Deserialize<APIResponse>(content, _jsonSerializerOptions);

                    callStats = new CallStats
                    {
                        totalAnweredCallsThisMonth = apiResponse.result.totalAnweredCallsThisMonth,
                        totalUnAnweredCallsThisMonth = apiResponse.result.totalUnAnweredCallsThisMonth,
                        totalAnswredCalls = apiResponse.result.totalAnswredCalls,
                        totalAnweredCallsThisWeek = apiResponse.result.totalAnweredCallsThisWeek,
                        totalAnweredCallsThisYear = apiResponse.result.totalAnweredCallsThisYear,
                        totalCalls = apiResponse.result.totalCalls,
                        totalUnAnswredCalls = apiResponse.result.totalUnAnswredCalls,
                        totalUnAnweredCallsThisWeek = apiResponse.result.totalUnAnweredCallsThisWeek,
                        totalUnAnweredCallsThisYear = apiResponse.result.totalUnAnweredCallsThisYear
                    };
                }
                else
                {
                    Debug.WriteLine("---> Non Http 2xx response");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Whoops exception: {ex.Message}");
            }

            return callStats;
        }
    }
}

