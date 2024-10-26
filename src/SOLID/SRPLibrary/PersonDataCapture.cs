using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPLibrary
{
    public class PersonDataCapture
    {
        public static Person Capture()
        {
            Person user = new Person();
            Console.Write("Enter Your First Name:");
            user.FirstName = Console.ReadLine();

            Console.Write("Enter Your Last Name:");
            user.LastName = Console.ReadLine();

            return user;
        }
    }
}
