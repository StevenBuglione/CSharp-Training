using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> importantYears = new Dictionary<int, string>();

            importantYears[1492] = "Columbus discovered the new world.";
            importantYears[1969] = "Man walks on the moon.";
            importantYears[1999] = "Steve was born";

            Console.WriteLine($"In the year 1999, this happened: { importantYears[1999]}");


            Console.ReadLine();
        }
    }
}
