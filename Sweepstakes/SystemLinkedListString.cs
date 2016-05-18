using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SystemLinkedListString : ICustomString
    {
        LinkedList<char> linkedCharList = new LinkedList<char>();

        public SystemLinkedListString(string inputString)
        {
            //linkedCharList = inputString.ToList()
            char[] inputCharArray = inputString.ToCharArray();
            foreach(char i in inputCharArray)
            {
                linkedCharList.AddLast(i);
            }
        }
        public override string ToString()
        {
            //array copy method
            char[] array1 = linkedCharList.ToArray();
            string convertedString = string.Join(",", array1).Replace(",", "");
            return convertedString;
        }
        public void Insert(int startIndex, string stringToInsert)
        {

        }

        public void Remove(int startIndex, int numCharsToRemove)
        {

        }

        public int Length()
        {
            return linkedCharList.Count;
        }
    }
}
