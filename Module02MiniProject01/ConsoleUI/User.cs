using System;
namespace ConsoleUI
{
    public class User
    {
        public string firstName { get; set; }
        public int age { get; private set; }
        public bool isProfessor { get; private set; }

        public void SetAge(int userBirthYear)
        {
            DateTime current = DateTime.Now;
            age = current.Year - userBirthYear;
        }

        public void SetIsProfessor()
        {
            if (firstName.ToLower() == "bob" || firstName.ToLower() == "sue")
            {
                isProfessor = true;
            }
            else
            {
                isProfessor = false;
            }
        }

        public string ReturnUserTitle()
        {
            if (isProfessor == true)
            {
                return "Professor";
            }
            else
            {
                return null;
            }
        }

        public bool isUserOldEnough()
        {
            if (age >= 21)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int ReturnUsersTimeToWait()
        {
            int ageToBeInCourse = 21;
            return ageToBeInCourse - age;
        }

        public string ReturnUserStatement()
        {
            SetIsProfessor();
            string userTitle = ReturnUserTitle();

            if(isUserOldEnough() == true && isProfessor == true)
            {
                return ($"Hello {userTitle} {firstName} wellcome to this course!");
            }
            else if(isUserOldEnough() == true && isProfessor == false)
            {
                return ($"Hello {firstName} wellcome to this course!");
            }
            else if (isUserOldEnough() == false && isProfessor == true)
            {
                int ageToWait = ReturnUsersTimeToWait();
                return ($"Hello {userTitle} {firstName} you need to wait {ageToWait} year until you can joint this course!");
            }
            else
            {
                int ageToWait = ReturnUsersTimeToWait();
                return ($"Hello {firstName} you need to wait {ageToWait} year until you can joint this course!");
            }
        }

        public void RunUserProgram()
        {
            Console.WriteLine("Please enter your first name: ");
            firstName = Console.ReadLine();

            Console.WriteLine("Please enter the year you were born: ");
            string ageString = Console.ReadLine();

            bool isValidAge = int.TryParse(ageString, out int _birthYear);

            if (isValidAge == true)
            {
                SetAge(_birthYear);
                Console.WriteLine($"{ReturnUserStatement()}");
            }
            else
            {
                Console.WriteLine("Please Enter a valid age");
            }
        }

        public User()
        {
        }

        public User(string _firstName, string _lastName, int _age)
        {
            firstName = _firstName;
            age = _age;
        }
    }
}
