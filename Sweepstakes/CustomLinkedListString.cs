using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class CustomLinkedListString : ICustomString
    {
        string someString;
        public Node headNode;
        StringBuilder stringBuilder;
        public CustomLinkedListString(string someString)
        {
            this.someString = someString;
            headNode = new Node(someString[0]);
            linkNodes(someString);
        }
        public override string ToString()
        {
            stringBuilder = getStringBuilder();
            return stringBuilder.ToString();
        }
        public void Insert(int startIndex, string stringToInsert)
        {
            
            someString = someString.Insert(startIndex, stringToInsert);
            linkNodes(someString);
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            someString = someString.Remove(startIndex, numCharsToRemove);
            linkNodes(someString);
        }

        public int Length()
        {
            return someString.Length;
        }

        public void linkNodes(string someString)
        {
            Node currentNode = headNode;
            for (int i = 1; i < someString.Length; i++)
            {
                currentNode.nextNode = new Node(someString[i]);
                currentNode = currentNode.nextNode;
            }
        }
        public StringBuilder getStringBuilder()
        {
            
            StringBuilder stringBuilder = new StringBuilder();
            Node currentNode = headNode;
            while (currentNode != null)
            {
                stringBuilder.Append(currentNode.myCharacter);
                currentNode = currentNode.nextNode;
            }
            return stringBuilder;
        }
        public void changeNodes()
        {

        }
    }
}
