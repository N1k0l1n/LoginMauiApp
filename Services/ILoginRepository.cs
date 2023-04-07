using LoginApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.Services
{
     public interface ILoginRepository
    {
        Task<LoginResponse> Login(LoginRequest loginRequest);
        //Task<UserInfo> Login(string username, string password);
    }
}
