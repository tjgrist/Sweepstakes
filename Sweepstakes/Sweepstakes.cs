using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        string name;
        public Sweepstakes(string name)
        {
            this.name = name;
        }
        public void RegisterContestant(Contestant contestant)
        {
        }
        public string PickWinner()
        {
            return "Winner is: ";
        }
        public void PrintContestantInfo(Contestant contestant)
        {
        }
    }
}
