using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPattern
{
    public class UserRegistration
    {
        public void FirstName()
        {
            Console.Write("\nEnter First Name: ");
            string firstName = Console.ReadLine();
            var regex = new Regex(@"^[A-Z]{1}[a-z]{2}$");
            bool match = regex.IsMatch(firstName);
            if (match == true)
            {
                Console.WriteLine($"{firstName} is valid");
            }
            else
            {
                Console.WriteLine($"{firstName} is invalid");
                FirstName();
            }
        }
    }
}
