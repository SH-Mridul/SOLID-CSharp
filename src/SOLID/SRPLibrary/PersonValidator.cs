using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPLibrary
{
    public class PersonValidator
    {
        public static bool Validate(Person user)
        {
            if (string.IsNullOrEmpty(user.FirstName) || string.IsNullOrEmpty(user.FirstName))
            {
                StandardMessages.DisplayError("first name");
                return false;
            }

            if (string.IsNullOrEmpty(user.LastName) || string.IsNullOrEmpty(user.LastName))
            {
                StandardMessages.DisplayError("last name");
                return false;
            }

            return true;
        }
    }
}
