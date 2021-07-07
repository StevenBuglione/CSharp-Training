using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //string continueResult = "";
            //do
            //{
            //    Console.WriteLine("What is your first name: ");
            //    string firstName = Console.ReadLine();

            //    Console.WriteLine($"Hello { firstName }");

            //    Console.Write("Do you want to continue (yes/no): ");
            //    continueResult = Console.ReadLine();
            //} while (continueResult.ToLower() == "yes");


            Console.WriteLine("What is your age: ");
            string ageText = Console.ReadLine();

            bool isValidAge = int.TryParse(ageText, out int age);
            while(isValidAge == false)
            {
                Console.WriteLine("That was an invalid age. Please try again.");

                Console.WriteLine("What is your age: ");
                ageText = Console.ReadLine();

                isValidAge = int.TryParse(ageText, out age);
            }

            Console.WriteLine($"Your age in 10 years will be { age + 10 }");

            Console.ReadLine();
        }
    }
}
