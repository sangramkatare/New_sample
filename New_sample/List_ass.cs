using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_sample
{
    internal class List_ass
    {
        static void Main()
        {
            List<int> myList = new List<int>();

            myList.Add(10);
            myList.Add(20);
            myList.Add(30);
            myList.Add(40);
            myList.Add(50);

            //Print List
            Console.WriteLine("The Element of Mylist is: ");
            foreach(int i in myList)
            {
                Console.WriteLine(i); 
            }

            //here we remove 30 and 50 from list
            myList.Remove(30);//remove from value
            myList.RemoveAt(3);//remove from index

            Console.WriteLine("\nAfter Removing Element 30 & 50 from Mylist: ");
            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }
            //here we Insert 70  at second position
            myList.Insert(1,70);//insert  70 to 2nd postion

            Console.WriteLine("\nAfter Inserting 70 at 2nd Position in Mylist: ");
            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }
            //here we clear the list
            Console.WriteLine("\nHere we Clear the all List:");
            myList.Clear();
            Console.WriteLine("\nCounts Of element in myList is : " + myList.Count);

        }
    }
}