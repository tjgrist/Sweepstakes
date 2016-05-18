using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class CustomLinkedListString : ICustomString
    {
        CustomLinkedList customLinkedList;

        public CustomLinkedListString(string someString)
        {
            customLinkedList = new CustomLinkedList(someString);
        }
        public override string ToString()
        {

            return customLinkedList.ToString();
        }
        public void Insert(int startIndex, string stringToInsert)
        {

        }

        public void Remove(int startIndex, int numCharsToRemove)
        {

        }

        public int Length()
        {
            return 100;
        }
    }
}
