using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    public class Emailer : IMessageSender
    {
        public void SendMessage(IPerson person, string name)
        {
            Console.WriteLine($"Simulating sending an email to {person.EmailAddress}.");
        }
    }
}
