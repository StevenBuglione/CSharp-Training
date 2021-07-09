using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Venue
    {
        public int totalNumberOfGuests { get; set; }
        public List<Guest> guestList { get; set; }


        public void NewGuestAdded(Guest guest)
        {
            guestList.Add(guest);
            totalNumberOfGuests += guest.partySize;

        }

        public Venue(int _startingNumberOfGuests)
        {
            totalNumberOfGuests = _startingNumberOfGuests;
        }

        public Venue()
        {
            totalNumberOfGuests = 0;
            guestList = new List<Guest>();
        }
    }
}
