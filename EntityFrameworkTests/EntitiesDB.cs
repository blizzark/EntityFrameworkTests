﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTests
{
    public class Users
    {
        public string FirstName { get; set; } = null!;
        public int Id { get; set; }
        public string SecondName { get; set; } = null!;

        public int Age { get; set; }
    }
}