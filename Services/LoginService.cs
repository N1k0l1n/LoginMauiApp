using LoginApp.Models;
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
        public async Task<UserInfo> Login(string username, string password)
        {
            try
            {
                if(Connectivity.Current.NetworkAccess == NetworkAccess.Internet)
                {
                    var userInfo = new UserInfo();
                    var client = new HttpClient();
                    string url = "https://wucmanager-dev.ikanbi.com/api/User/Authenticate/" + username + "/" + password;
                    HttpResponseMessage responseMessage = await client.GetAsync("");
                    if(responseMessage.IsSuccessStatusCode)
                    {
                        // string content = response.Content.ReadAsStringAsync().Results;
                        //userIfo = JsonConvert.DeserializeObject<List<UserInfo>>(content);
                        userInfo = await responseMessage.Content.ReadFromJsonAsync<UserInfo>();
                        return await Task.FromResult(userInfo);
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
