using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_sample
{
    internal class Hashtable_ass
    {
        static void Main(string[] args)
        {
            Hashtable myHash = new Hashtable()
            {
                {1, "Kolhapur"},
                {2, "Pune" },
                {3, "Mumbai" },
                {4, "Sangli" },
                {5, "Satara" } 
            };
            Console.WriteLine("Here The Hashtable of Key and value pair: \n");

            // foreach (DictionaryEntry item in myHash)
            //    Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);

            //Here we type cast the value

            string value1 = (string)myHash[1];
            string value2 = (string)myHash[2];
            string value3 = (string)myHash[3];
            string value4 = (string)myHash[4];
            string value5 = (string)myHash[5];

            /* //print key value
             Console.WriteLine($"[1]:{value1}");

             Console.WriteLine($"[2]:{value2}");

             Console.WriteLine($"[3]:{value3}");

             Console.WriteLine($"[4]:{value4}");

             Console.WriteLine($"[5]:{value5}");*/
            foreach (DictionaryEntry de in myHash)
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);


            Console.WriteLine("\n Here we Remove second value: \n");
            myHash.Remove(2);

            foreach (DictionaryEntry de in myHash)
                Console.WriteLine("\nKey: {0}, Value: {1}", de.Key, de.Value);

            Console.WriteLine("\n Here we Insert sixth and Seventh Key value pair: \n");

            myHash[6] = "Solapur"; // update value 
            myHash[7] = "Nagpur";

            foreach (DictionaryEntry de in myHash)
                Console.WriteLine("\nKey: {0}, Value: {1}", de.Key, de.Value);



        }
    }
}
