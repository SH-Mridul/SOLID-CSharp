﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    public class Texting : IMessageSender
    {
        public void SendMessage(IPerson person, string message)
        {
            Console.WriteLine($"I'm texting {person.FirstName} to say {message}");
        }
    }
}
