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
                if (count == startIndex - 1)
                {
                    newNodes.tailNode.nextNode = currentNode;                        //newnodes tail points to Overflow...
                    currentNode.nextNode = newNodes.headNode;                   //the next node should point to the newnodes headnode;
                    break;
                }
                count++;
            }
            Console.WriteLine();
        }
  
        public void Insert2(int start, string word)
        {
            Node currentNode = headNode;
            Node firstNode = null;
            CustomLinkedListString newWord = new CustomLinkedListString(word);
            for (int i = 0; i < Length(); i++)
            {
                if (i == start - 1)
                {
                    firstNode = currentNode;
                    break;
                }
                currentNode = currentNode.nextNode;
            }
            newWord.tailNode = firstNode.nextNode;
            firstNode.nextNode = newWord.headNode;
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            //someString = someString.Remove(startIndex, numCharsToRemove);
            //linkNodes(someString);
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
        public void changeNodes()
        {

        }
    }
}
