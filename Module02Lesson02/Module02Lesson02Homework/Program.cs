using System;

namespace Module02Lesson02Homework
{
    class Program
    {
        //Homework : Create a Conasole Applicaiton that has variables to hold a person's name,
        //Age, if they are alive, and there phone number
        static void Main(string[] args)
        {
            //Creating person variable without creating a person object
            string firstName = "";
            string lastName = "";
            int age = 0;
            bool isAlive = false;
            string phoneNumber = "";


            Console.WriteLine("Enter Your fristname: ");
            firstName = Console.ReadLine();

            Console.WriteLine("Enter Your lastname: ");
            lastName = Console.ReadLine();

            Console.WriteLine("Enter Your age: ");
            age = Int16.Parse(Console.ReadLine());

            Console.WriteLine("Are they Alive (true/false)");
            isAlive = bool.Parse(Console.ReadLine());

            Console.WriteLine("Enter Phone Number: ");
            phoneNumber = Console.ReadLine();


            Console.WriteLine($"Person : \n First Name : { firstName } \n Last Name : { lastName }" +
                $"\n Age : { age }  \n isAlive : { isAlive } \n Phone Number : { phoneNumber } ");

            Console.ReadLine();
        }
    }
}
