using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_sample
{
    internal class stack_ass
    {
        static void Main(string[] args)
        {
            Stack Names = new Stack();

            Names.Push("1");
            Names.Push("2");
            Names.Push("3");
            Names.Push("4");
            Names.Push("5");

            Console.WriteLine("The Elements of the Stack is:\n ");

            foreach (var item in Names)
                Console.WriteLine(item);

           /* int element1 = (int) Names.Pop();
            int element2 = (int)Names.Pop();
            int element3 = (int)Names.Pop();
            int element4 = (int)Names.Pop();
            int element5 = (int)Names.Pop();*/

            Console.WriteLine($"\nHere we Remove the topmost element in Stack is: {Names.Pop()}");
            Console.WriteLine("\nAfter Removing the Element the Stack is:\n ");

            foreach (var item in Names)
                Console.WriteLine(item);

        }
    }
}
