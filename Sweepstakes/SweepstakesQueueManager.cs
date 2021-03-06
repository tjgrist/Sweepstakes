﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager : Queue<Sweepstakes>, ISweepstakesManager
    {
        public Sweepstakes GetNextSweepstakesWinner()
        {
            return Dequeue();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            Enqueue(sweepstakes);
        }
    }
}
