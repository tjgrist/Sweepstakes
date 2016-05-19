using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            SweepstakesStackManager stackManager = new SweepstakesStackManager();
            SweepstakesQueueManager queueManager = new SweepstakesQueueManager();

            Sweepstakes sweepstakes = new Sweepstakes("Rollerbird");
            Sweepstakes sweepstakes1 = new Sweepstakes("PwerBall");
            Sweepstakes sweepstakes2 = new Sweepstakes("WinMe Sweep");
            Sweepstakes sweepstakes3 = new Sweepstakes("Get Paid Stakes");

            stackManager.InsertSweepstakes(sweepstakes);
            stackManager.InsertSweepstakes(sweepstakes1);
            stackManager.InsertSweepstakes(sweepstakes2);
            stackManager.InsertSweepstakes(sweepstakes3);

            queueManager.InsertSweepstakes(sweepstakes);
            queueManager.InsertSweepstakes(sweepstakes1);
            queueManager.InsertSweepstakes(sweepstakes2);
            queueManager.InsertSweepstakes(sweepstakes3);

            registerAll(sweepstakes, sweepstakes1, sweepstakes2, sweepstakes3);

            while (stackManager.Count != 0)
            {
                Sweepstakes nextSweepstakes = stackManager.GetNextSweepstakesWinner();
                Console.WriteLine("Stack: " + nextSweepstakes.PickWinner());
            }
            Console.WriteLine();
            while (queueManager.Count != 0)
            {
                Sweepstakes queuedSweepstakes = queueManager.GetNextSweepstakesWinner();
                Console.WriteLine("Queue: " + queuedSweepstakes.PickWinner());
            }
            Console.ReadKey();
        }
        static void registerAll(Sweepstakes sweepstakes, Sweepstakes sweepstakes1, Sweepstakes sweepstakes2, Sweepstakes sweepstakes3)
        {

            Contestant contestant1 = new Contestant("Fred", 1);
            Contestant contestant2 = new Contestant("Alice", 2);
            Contestant contestant3 = new Contestant("Veronica", 3);
            Contestant contestant4 = new Contestant("Newman", 4);
            Contestant contestant5 = new Contestant("Antonio", 5);
            Contestant contestant6 = new Contestant("Allesandra", 6);          
            sweepstakes.RegisterContestant(contestant1);
            sweepstakes.RegisterContestant(contestant2);
            sweepstakes.RegisterContestant(contestant3);
            sweepstakes.RegisterContestant(contestant4);
            sweepstakes.RegisterContestant(contestant5);
            sweepstakes.RegisterContestant(contestant6);

            Contestant contestant7 = new Contestant("Adam", 1);
            Contestant contestant8 = new Contestant("Louis", 2);
            Contestant contestant9 = new Contestant("Ryan", 3);
            Contestant contestant10 = new Contestant("TJ", 4);
            Contestant contestant11 = new Contestant("Joe", 5);
            Contestant contestant12 = new Contestant("Joey", 6);
            sweepstakes1.RegisterContestant(contestant7);
            sweepstakes1.RegisterContestant(contestant8);
            sweepstakes1.RegisterContestant(contestant9);
            sweepstakes1.RegisterContestant(contestant10);
            sweepstakes1.RegisterContestant(contestant11);
            sweepstakes1.RegisterContestant(contestant12);

            Contestant contestant13 = new Contestant("Andrew", 1);
            Contestant contestant14 = new Contestant("Adam", 2);
            Contestant contestant15 = new Contestant("Mike", 3);
            Contestant contestant16 = new Contestant("Nick", 4);
            Contestant contestant17 = new Contestant("Ben", 5);
            Contestant contestant18 = new Contestant("JJ cool", 6);
            sweepstakes2.RegisterContestant(contestant13);
            sweepstakes2.RegisterContestant(contestant14);
            sweepstakes2.RegisterContestant(contestant15);
            sweepstakes2.RegisterContestant(contestant16);
            sweepstakes2.RegisterContestant(contestant17);
            sweepstakes2.RegisterContestant(contestant18);

            Contestant contestant19 = new Contestant("Liam", 1);
            Contestant contestant20 = new Contestant("Colin", 2);
            Contestant contestant21 = new Contestant("Ryan", 3);
            Contestant contestant22 = new Contestant("TJ", 4);
            Contestant contestant23 = new Contestant("Tierney", 5);
            Contestant contestant24 = new Contestant("Puppydog", 6);
            sweepstakes3.RegisterContestant(contestant19);
            sweepstakes3.RegisterContestant(contestant20);
            sweepstakes3.RegisterContestant(contestant21);
            sweepstakes3.RegisterContestant(contestant22);
            sweepstakes3.RegisterContestant(contestant23);
            sweepstakes3.RegisterContestant(contestant24);
        }
    }
}
