using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SystemArrayString : ICustomString
    {
        char[] charArray;

        public SystemArrayString(string someString)
        {
            charArray = someString.ToCharArray();
        }
        public override string ToString()
        {
            string convertedString = string.Join(",", charArray).Replace(",", "");
            return convertedString;
        }
        public void Insert(int startIndex, string stringToInsert)
        {
            StringBuilder stringBuilder = new StringBuilder(charArray.Length);
            string newString = stringBuilder.Insert(startIndex, stringToInsert).ToString();
            charArray = newString.ToCharArray();
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            string tempString = charArray.ToString();
            charArray = tempString.Remove(startIndex, numCharsToRemove).ToCharArray();
        }

        public int Length()
        {
            return charArray.Length;
        }
    }
}
