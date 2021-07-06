using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Homework: Plan and build a Console application that ask a user for their name and their age.
            //If their name is Bob or Sue, address them as professor. If the person is under 21,
            //recommend they wait X years to start this class.
            User user = new User();
            user.RunUserProgram();
            Console.ReadLine();
        }
    }
}
