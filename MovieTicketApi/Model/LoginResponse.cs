using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketApi.Model
{
    public class LoginResponse
    {
        public string UserName { get; set; }
        public string Token { get; set; }
    }
}
