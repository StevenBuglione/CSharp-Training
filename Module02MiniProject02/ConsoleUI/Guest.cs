using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Guest
    {

        public string firstName { get; set; }
        public int partySize { get; set; }

        public Guest(string _firstName, int _partySize)
        {
            firstName = _firstName;
            partySize = _partySize;
        }

        public Guest()
        {

        }
    }
}
