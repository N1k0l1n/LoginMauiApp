using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.Models
{
    public class LoginResponse
    {
        public string Token { get; set; }
        public UserInfo UserDetail { get; set; }
    }
}
