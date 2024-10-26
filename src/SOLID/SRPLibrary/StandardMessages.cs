using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPLibrary
{
    public class StandardMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my application!");
        }

        public static void EndApplication() 
        {
            Console.Write("Enter to close..");
            Console.ReadLine(); 
        }

        public static void DisplayError(string fieldName)
        {
            Console.WriteLine($"Your did not giving valid {fieldName}!");
        }
    }
}
