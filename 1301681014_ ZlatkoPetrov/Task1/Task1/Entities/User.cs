﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task1.Entities
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}