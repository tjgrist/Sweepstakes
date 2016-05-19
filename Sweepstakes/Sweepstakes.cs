using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        string sweepstakesName;
        public Sweepstakes(string name)
        {
            sweepstakesName = name;
        }
        public void RegisterContestant(Contestant contestant)
        {
            dictionary.Add(contestant.Name, contestant.ticket);
        }
        public string PickWinner()
        {
            Random rand = new Random();
            int randomPick = rand.Next(0, dictionary.Count);
            var element = dictionary.ElementAt(randomPick);
            return "Winner is: " + element.Key + ", Ticket Number: " + element.Value;
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("Contestant: " + contestant.Name + contestant.ticket);
        }
        public void PrintAllContestantsInSweepstakes()
        {
            Console.WriteLine("*" + sweepstakesName + "*");
            foreach (var c in dictionary)
            {
                Console.WriteLine("Contestant: " + c.Key);
                Console.WriteLine("Ticket Number: " + c.Value);
            }
        }
    }
}
