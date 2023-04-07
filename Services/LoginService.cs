using LoginApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.Services
{
    public class LoginService : ILoginRepository
    {
        public async Task<LoginResponse> Login(LoginRequest loginRequest)
        {
            try
            {
                if(Connectivity.Current.NetworkAccess == NetworkAccess.Internet)
                {
                    var userInfo = new UserInfo();
                    var client = new HttpClient();
                    string loginRequestStr = JsonConvert.SerializeObject(loginRequest);

                    var response = await client.PostAsync("https://wucmanager-dev.ikanbi.com/api/User/Authenticate",
                     new StringContent(loginRequestStr, Encoding.UTF8,
                     "application/json"));

                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<LoginResponse>(json);
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }

            }catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }
    }
}
