using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_sample
{
    internal class Hashset_ass
    {
        static void Main()
        {
            HashSet<string> city = new HashSet<string>();

            city.Add("Kolhapur");
            city.Add("Pune"); 
            city.Add("Sangli");
            city.Add("Mumbai");
            city.Add("Satara");

            //print all city names
            Console.WriteLine("\nNames Hashset 1 of City:");
            foreach (string s in city)
            {
                Console.Write($" {s} ");
            }
            city.Add("Thane");
            city.Add("PCMC");

            Console.WriteLine("\n\nUpdated Hashset 1 of City:");
            foreach (string s in city)
            {
                Console.Write($" {s} ");
            }

            // remove Mumbai and satara
            city.Remove("Mumbai");
            city.Remove("Satara");
            Console.WriteLine("\n\nHere we Remove Mumbai & Satara :");

            foreach (string s in city)
            {
                Console.Write($" {s} ");
            }

            HashSet<string> city1 = new HashSet<string>();
            city1.Add("Solapur");
            city1.Add("Pune");
            city1.Add("Nashik");
            city1.Add("Kolhapur");
            city1.Add("Karad");

            //prinnt the second hashset
            Console.WriteLine("\n\nNames Hashset2 of City:");
            foreach (string s in city)
            {
                Console.Write($" {s} ");
            }

            //city union with city1
            Console.WriteLine("\n\nAfter Hashset 1 UnionWith Hashset 2 Result is :");
            city.UnionWith(city1);

            foreach (string s in city)
            {
                Console.Write($" {s} ");
            }

            //city intersect with city1
            Console.WriteLine("\n\nAfter Hashset 1 IntersectWith Hashset 2 Result is :");
            city.IntersectWith(city1);

            foreach (string s in city)
            {
                Console.Write($" {s} ");
            }
            Console.WriteLine("\n\n");
        }
    }
}
