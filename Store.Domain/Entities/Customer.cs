﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.Entities
{
    public class Customer
    {

        public Customer(string name, string email)
        {
            Name = name;
            Email = email;
        }

        
        public string Name { get; private set; }
        public string Email { get; private set; }
    }
}

