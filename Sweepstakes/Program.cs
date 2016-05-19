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
            Sweepstakes sweepstakes = new Sweepstakes("Rollerbird");

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
            sweepstakes.PrintAllContestantsInSweepstakes();
            sweepstakes.PrintContestantInfo(contestant1);
            Console.WriteLine(sweepstakes.PickWinner()); 

            Console.ReadKey();
        }
    }
}
