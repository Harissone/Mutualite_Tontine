﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tontine.BO
{
    public class Login
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Login(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}