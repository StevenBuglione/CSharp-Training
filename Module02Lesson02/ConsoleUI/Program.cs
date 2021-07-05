using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "";
            string lastName = "";
            string fullName = "";

            firstName = "Tim";
            lastName = "Corey";

            // $ is for string interpolation
            fullName = $"{ firstName } { lastName }";

            string fileName = "";

            // @ is for string literals
            fileName = @"C:\Temp\Test.txt";

            // int is for whole numbers
            int age = 0;
            age = 10;
            age = 20;
            age = 30;

            int numberOfApplesTotal = 450;
            int numberOfApplesIAte = 50;

            Console.WriteLine(numberOfApplesTotal - numberOfApplesIAte);

            string zipCode = "00411";

            // Use double for all numbers that include fractions execpt for money
            double averageWordsPerMinute = 34.24;

            // Use decimal for money
            decimal costPerContainer = 43.85M;

            // Stores only true or false
            bool isAlive = false;

            Console.WriteLine(fullName);

            Console.ReadLine();


            //Pro Tip : Plan out the type of data you need before creating a variable
            //Homework : Create a Conasole Applicaiton that has variables to hold a person's name,
            //Age, if they are alive, and there phone number
        }
    }
}
