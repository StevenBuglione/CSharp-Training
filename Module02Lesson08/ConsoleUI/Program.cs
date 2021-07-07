using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> firstName = new List<string>();

            firstName.Add("Tim");
            firstName.Add("Sue");
            firstName.Add("Bob");

            Console.WriteLine($"The second element is { firstName[1]}");

            firstName.Remove("Sue");

            Console.WriteLine($"The second element is { firstName[1]}");

            firstName[1] = firstName[1].ToUpper();

            Console.WriteLine($"The second element is { firstName[1]}");

            Console.ReadLine();
        }
    }
}
