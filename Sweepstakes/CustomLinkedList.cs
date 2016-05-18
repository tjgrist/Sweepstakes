using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class CustomLinkedList
    {
        public Node headNode;

        public CustomLinkedList(string someString)
        {
            headNode = new Node(someString[0]);
            linkNodes(someString);
        }
        public void linkNodes(string someString)
        {
            Node currentNode = headNode;
            for(int i = 1; i < someString.Length; i++)
            {
                currentNode.nextNode = new Node(someString[i]);
                currentNode = currentNode.nextNode;
            }
        }
    }



    class Node
    {
        public char myCharacter;
        public Node nextNode;
        public Node(char character)
        {
            myCharacter = character;
        }
    }

}
