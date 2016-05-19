using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class CustomLinkedListString : ICustomString
    {
        public Node headNode;
        public Node tailNode;
        public int numOfNodes;
        StringBuilder stringBuilder;

        public CustomLinkedListString(string someString)
        {
            numOfNodes = someString.Length;
            headNode = new Node(someString[0]);
            tailNode = new Node(someString[someString.Length - 1]);
            linkNodes(someString);
        }
        public override string ToString()
        {
            stringBuilder = stringbuilderShowNodes();
            return stringBuilder.ToString();
        }
        public void Insert(int startIndex, string stringToInsert)
        {
            Node currentNode = headNode;
            CustomLinkedListString newNodes = new CustomLinkedListString(stringToInsert);            
            int count = 0;
            while (count < startIndex)
            {
                currentNode = currentNode.nextNode;   
                count++;
            }
            newNodes.tailNode.nextNode = currentNode.nextNode;               
            currentNode.nextNode = newNodes.headNode;                       
            Console.WriteLine();
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            Node firstNode = headNode;
            int count = 0;
            int count2 = 0;
            while (count < startIndex)
            {
                firstNode = firstNode.nextNode;
                count++;
            }
            //have the current firstNode point to the node at numChars away
            Node pointerNode = firstNode;
            while (count2 < numCharsToRemove)
            {
                pointerNode = pointerNode.nextNode;
                count2++;
            }
            firstNode.nextNode = pointerNode;
        }

        public int Length()
        {
            return numOfNodes;
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
        public StringBuilder stringbuilderShowNodes()
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
    }
}
