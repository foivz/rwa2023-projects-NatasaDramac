﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongManGym.Models
{
    public class Zaposleni : Person
    {
        public int IdZaposleni { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool CheckPassword(string password)
        {
            return Password == password;
        }
    }
}
