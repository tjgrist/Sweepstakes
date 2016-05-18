using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Sweepstakes
{
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
