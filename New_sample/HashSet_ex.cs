using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_sample
{
    internal class HashSet_ex
    {
        static void Main(string[] args)
        {
            // create HashSet
            HashSet<int> numbers = new HashSet<int>();

            //add number
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);

            Console.WriteLine("HashSet Elements : ");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            bool containstwo = numbers.Contains(2);
            Console.WriteLine("Hashset Contains two: "+containstwo);

            //remove element

            numbers.Remove(3);

            Console.WriteLine("After Remove: ");

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            HashSet<int> numberstet = new HashSet<int>();

            //print Union Both of them print
            numbers.UnionWith(numberstet);

            Console.WriteLine("Hashset elements after union with{3,4,5}");
            foreach (int i in numbers) 
            {
                Console.WriteLine(i);
            }
        }
    }
}
