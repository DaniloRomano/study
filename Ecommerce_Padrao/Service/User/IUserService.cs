﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Service.User
{
    public interface IUserService
    {
        Models.User.User Authenticate(string username, string password);        
    }
}
