namespace RegexPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular Expressions");
            Console.WriteLine("\n=========User Registration Form==========");

            UserRegistration obj = new UserRegistration();
            obj.FirstName();
            obj.LastName();
            obj.Email();
            obj.PhoneNumber();
            obj.Password();
        }
    }
}