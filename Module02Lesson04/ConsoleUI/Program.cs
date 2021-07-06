using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your age: ");
            string ageText = Console.ReadLine();

            //ageText = ageText + 10;
            //ageText += 10;

            //Console.WriteLine($"You are going to be { ageText } years old in 10 years.");

            //int age = int.Parse(ageText);

            bool isValidAge = int.TryParse(ageText, out int age);

            if (isValidAge == true)
            {

                age += 10;

                Console.WriteLine($"You are going to be { age } years old in 10 years.");
            }
            else
            {
                Console.WriteLine("Please enter a numerical value");
            }

            Console.ReadLine();
        }
    }
}
