using System;
using System.Collections.Generic;
using System.Text;

namespace Service.User.Response
{
    public class LoginResponse
    {
        public Guid UserId { get; set; }
        public string Token { get; set; }
    }
}
