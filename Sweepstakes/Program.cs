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
            SortedSet<ICustomString> sortedSet = new SortedSet<ICustomString>();
            SortedList<int, ICustomString> sortList = new SortedList<int, ICustomString>();
            ICustomString string1 = new SystemString("Hello World");
            ICustomString string2 = new SystemString("I'll compile that.");
            ICustomString charArray1 = new SystemArrayString("Binary for life");
            ICustomString charArray2 = new SystemArrayString("Strings are cool.");
            ICustomString linkedList1 = new SystemLinkedListString("Developers!!");
            ICustomString linkedList2 = new SystemLinkedListString("C-Sharp rocks!");
            ICustomString linkedList3 = new SystemLinkedListString("Override!");
            ICustomString linkedList4 = new SystemLinkedListString("Visual studio cleans up!");
            CustomLinkedListString customlinkedList1 = new CustomLinkedListString("Stack Overflows who knows");
            CustomLinkedListString customlinkedList2 = new CustomLinkedListString("Big O");
            ICustomString customlinkedList3 = new CustomLinkedListString("Argument Exceptions");
            ICustomString customlinkedList4 = new CustomLinkedListString("StringBuilder rules all. =)");
            sortList.Add(string1.Length(), string1);
            sortList.Add(string2.Length(), string2);
            sortList.Add(charArray1.Length(), charArray1);
            sortList.Add(charArray2.Length(), charArray2);
            sortList.Add(linkedList1.Length(), linkedList1);
            sortList.Add(linkedList2.Length(), linkedList2);
            sortList.Add(linkedList3.Length(), linkedList3);
            sortList.Add(linkedList4.Length(), linkedList4);
            sortList.Add(customlinkedList1.Length(), customlinkedList1);
            sortList.Add(customlinkedList2.Length(), customlinkedList2);
            sortList.Add(customlinkedList3.Length(), customlinkedList3);
            sortList.Add(customlinkedList4.Length(), customlinkedList4);

            foreach (var item in sortList)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();

            //Testing
            linkedList1.Insert(3, "HA!");
            Console.WriteLine("Insertion: " + linkedList1);
            linkedList1.Remove(2, 3);
            Console.WriteLine("Removal: " + linkedList1);

            customlinkedList1.Insert(5, "FIVES");
            Console.WriteLine("Insertion: " + customlinkedList1);
            customlinkedList1.Remove(5, 5);
            Console.WriteLine("Removal: " + customlinkedList1);

            customlinkedList2.Insert(2, "FIVES");
            Console.WriteLine("Insertion: " + customlinkedList2);
            customlinkedList2.Remove(2, 4);
            Console.WriteLine("Removal: " + customlinkedList2);



            SortedList<ICustomString, int> sortedStringList = new SortedList<ICustomString, int>();
            //sortedStringList.Add(string1, string1.Length());
            //sortedStringList.Add(string2, string2.Length());
            //sortedStringList.Add(charArray1, charArray1.Length());
            //sortedStringList.Add(charArray2, charArray2.Length());
            //sortedStringList.Add(linkedList1, linkedList1.Length());
            //sortedStringList.Add(linkedList2, linkedList2.Length());
            //sortedStringList.Add(linkedList3, linkedList3.Length());
            Console.ReadKey();
        }
    }
}
