using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant
    {
        string name;
        public int ticket;
        public string Name { get { return name; } }
        public Contestant(string name, int ticketNumber)
        {
            this.name = name;
            ticket = ticketNumber;
        }
    }
}
