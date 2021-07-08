using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            SayAuthor();

            string firstName = GetUserName("What is your first name: ");
            string lastName = GetUserName("What is your last name: ");

            WelcomUser(firstName, lastName);
            
            Console.ReadLine();
        }

        private static void WelcomUser(string firstName, string lastName)
        {
            Console.WriteLine($"Hello { firstName } { lastName }");
        }

        private static void SayAuthor()
        {
            Console.WriteLine("**********************");
            Console.WriteLine("Writen by: Steven Buglione");
            Console.WriteLine("for the Founddation in C# course.");
            Console.WriteLine("**********************");
        }

        private static string GetUserName(string message)
        {
            Console.WriteLine(message);
            string output = Console.ReadLine();

            return output;
        }

        
    }
}
