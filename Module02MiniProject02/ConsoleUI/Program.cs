using System;

namespace ConsoleUI
{
    class Program
    {

        /*
         * Build a Console Guest book. Ask the user for their name and how many are in their party. 
         * Keep track of how many people are at the party. At the end, print out the guest list and 
         * the total number of guest.
         * 
         * 
         * Date we are working with
         *  User:
         *      string - firstName
         *      int - partySize
         *      
         *  Venue:
         *      int - totalNumberOfGuest
         */
        static void Main(string[] args)
        {
            Venue venue = new Venue();
            bool isOpenForBuisness = true;

            while(isOpenForBuisness == true)
            {
                PromptGuestInput(venue);
                isOpenForBuisness = AreWeStillOpen();
            }

            PrintGuestList(venue);
            PrintTotalNumberOfGuests(venue);

   
            Console.ReadLine();
        }


        public static void PromptGuestInput(Venue venue)
        {
            Guest guest = new Guest();

            Console.WriteLine("Hello, what is your first name? ");

            guest.firstName = Console.ReadLine();

            Console.WriteLine($"Ok { guest.firstName }, how many people are in your party");

            string partySizeString = Console.ReadLine();

            bool isValidPartySize = int.TryParse(partySizeString, out int _partySize);

            if(isValidPartySize == false)
            {
                while(isValidPartySize == false)
                {
                    Console.WriteLine("Please enter a valid integer for the number of guests: ");
                    partySizeString = Console.ReadLine();

                    isValidPartySize = int.TryParse(partySizeString, out _partySize);
                }
            }

            guest.partySize = _partySize;
            venue.NewGuestAdded(guest);

        }

        public static bool AreWeStillOpen()
        {
            Console.WriteLine("Are there more guest coming? y/n");

            string userInput = Console.ReadLine();
            bool output = false;
            if(userInput.ToLower() == "y")
            {
                output = true;
            }

            return output;

        }

        public static void PrintGuestList(Venue venue)
        {
            foreach ( Guest guest in venue.guestList)
            {
                Console.WriteLine($"{guest.firstName}: {guest.partySize}");

            }
        }

        public static void PrintTotalNumberOfGuests(Venue venue)
        {
            Console.WriteLine($"This venue has { venue.totalNumberOfGuests} number of guests");
        }


        
    }
}
