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
            char[] inputCharArray = inputString.ToCharArray();
            foreach(char i in inputCharArray)
            {
                linkedCharList.AddLast(i);
            }
        }
        public override string ToString()
        {
            char[] array1 = linkedCharList.ToArray();
            string convertedString = string.Join(",", array1).Replace(",", "");
            return convertedString;
        }
        public void Insert(int startIndex, string stringToInsert)
        {
            char charElement = linkedCharList.ElementAt(startIndex);
            LinkedListNode<char> element = linkedCharList.Find(charElement);
            for(int i = 0; i < stringToInsert.Count(); i++)
            {
                LinkedListNode<char> newChar = new LinkedListNode<char>(stringToInsert[i]);
                linkedCharList.AddAfter(element, newChar);
                element = newChar;
            }
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            for(int i = 0; i < numCharsToRemove; i++)
            {
                char charElement = linkedCharList.ElementAt(startIndex);
                linkedCharList.Remove(charElement);          
            }
        }

        public int Length()
        {
            return linkedCharList.Count;
        }
    }
}
