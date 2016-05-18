using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<ICustomString, int> sortedStringList = new SortedList<ICustomString, int>();
            SortedSet<ICustomString> sortedSet = new SortedSet<ICustomString>();
            SortedList<int, ICustomString> sortList = new SortedList<int, ICustomString>();
            ICustomString string1 = new SystemString("Hello World");
            ICustomString string2 = new SystemString("I'll compile that.");
            ICustomString charArray1 = new SystemArrayString("Binary for life");
            ICustomString charArray2 = new SystemArrayString("Strings are cool.");
            ICustomString linkedList1 = new SystemLinkedListString("Developers!!");
            ICustomString linkedList2 = new SystemLinkedListString("C-Sharp rocks!");
            ICustomString linkedList3 = new SystemLinkedListString("Override!");
            ICustomString linkedList4 = new SystemLinkedListString("C-Sharp rocks!");
            sortList.Add(string1.Length(), string1);
            sortList.Add(string2.Length(), string2);
            sortList.Add(charArray1.Length(), charArray1);
            sortList.Add(charArray2.Length(), charArray2);
            sortList.Add(linkedList1.Length(), linkedList1);
            sortList.Add(linkedList2.Length(), linkedList2);
            sortList.Add(linkedList3.Length(), linkedList3);
            sortList.Add(linkedList4.Length(), linkedList4);
            //sortedStringList.Add(string1, string1.Length());
            //sortedStringList.Add(string2, string2.Length());
            //sortedStringList.Add(charArray1, charArray1.Length());
            //sortedStringList.Add(charArray2, charArray2.Length());
            //sortedStringList.Add(linkedList1, linkedList1.Length());
            //sortedStringList.Add(linkedList2, linkedList2.Length());
            //sortedStringList.Add(linkedList3, linkedList3.Length());
            foreach (var item in sortList)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
