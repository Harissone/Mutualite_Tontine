﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tontine.BO
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public User(string username, string password, string confirmPassword)
        {
            Username = username;
            Password = password;
            ConfirmPassword = confirmPassword;
        }
    }
}
