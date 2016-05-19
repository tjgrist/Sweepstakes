using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager : Stack<Sweepstakes>, ISweepstakesManager
    {
        
        public Sweepstakes GetNextSweepstakesWinner()
        {
            return Pop();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            Push(sweepstakes);
        }
    }
}
