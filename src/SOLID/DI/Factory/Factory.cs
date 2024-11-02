﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    public static class Factory
    {
        public static IPerson CreatePerson()
        {
            return new Person();
        }

        public static IChore CreateChore()
        {
            return new Chore(CreateLogger(), CreateMessageSender());
        }

        public static IMessageSender CreateMessageSender()
        {
            //return new Emailer(); // just change without do anything
            return new Texting();
        }

        public static ILogger CreateLogger()
        {
            return new Logger();
        }
    }
}