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
            var regex = new Regex(@"^[A-Z]{1}[a-z]{2,}$");
            bool match = regex.IsMatch(firstName);
            if (match == true)
            {
                Console.WriteLine($"{firstName} is valid");
            }
            else
            {
                Console.WriteLine($"{firstName} is invalid. Please enter a valid First Name. First word must be capital and Name must contain minimum 3 letter.");
                FirstName();
            }
        }

        public void LastName()
        {
            Console.Write("\nEnter Last Name: ");
            string lastName = Console.ReadLine();
            var regex = new Regex(@"^[A-Z]{1}[a-z]{2,}$");
            bool matchRes = regex.IsMatch(lastName);
            if (matchRes == true)
            {
                Console.Write($"{lastName} is valid");
            }
            else
            {
                Console.WriteLine($"{lastName} is invalid. Please enter a valid Last Name. First word must be capital and Name must contain minimum 3 letters.");
                LastName();
            }
        }

        public void Email()
        {
            Console.Write("\nEnter Email (Example: abc.xyz@bl.co.in): ");
            string email = Console.ReadLine();
            var regex = new Regex(@"^([a][b][c])([_\.\+\-])([a-zA-Z0-9]+)\@([b][l])\.([c][o])\.([a-z]{2})*$");
            bool matchRes = regex.IsMatch(email);
            if (matchRes == true)
            {
                Console.WriteLine($"{email} is valid");
            }
            else
            {
                Console.WriteLine($"{email} is invalid. Please enter a valid email as abc.xyz@bl.co.in where xyz and in are optional");
                Email();
            }
        }

        public void PhoneNumber()
        {
            Console.Write("\nEnter Mobile Number (Example: +(country code) (10 digit number)): ");
            string phoneNumber = Console.ReadLine();
            var regex = new Regex(@"^\+[1-9]{1}[0-9]{0,2}\s[1-9]{1}[0-9]{9}");
            bool matchRes = regex.IsMatch(phoneNumber);
            if (matchRes == true)
            {
                Console.WriteLine($"{phoneNumber} is valid");
            }
            else
            {
                Console.WriteLine($"{phoneNumber} is invalid. Please enter a valid mobile number");
                PhoneNumber();
            }
        }

        public void Password()
        {
            Console.Write("\nEnter a Password: ");
            string password = Console.ReadLine();
            var regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z]).{8,15}$");
            bool matchRes = regex.IsMatch(password);
            if (matchRes == true)
            {
                Console.WriteLine($"{password} is valid");
            }
            else
            {
                Console.WriteLine($"{password} is invalid. Please enter a valid password. Must contain atleast 8 characters.  \nShould have atleat one uppercase.");
                Password();
            }
        }
    }
}
