﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPLibrary
{
    public class AccountGenerator
    {
        public static void CreateAccount(Person user)
        {
            Console.WriteLine($"Username is :{user.FirstName.Substring(0, 1)}{user.LastName}");
        }
    }
}
