using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_sample
{
    internal class Dictionary_ass
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("Sangram", 21);
            dict.Add("Rohan", 22);
            dict.Add("Omkar", 22);
            dict.Add("Vishal", 23);
            dict.Add("Pratik", 24);
            dict.Add("Sahil", 20);
            dict.Add("Ajinkya", 38);
            dict.Add("Raj", 23);
            dict.Add("sai", 22);
            dict.Add("Ajay", 25);

            Console.WriteLine("The Key and Value pair if the Age Dictionary: ");
            foreach(KeyValuePair<string, int> kvp in dict)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            // Modify the values
          
            dict["Rohan"] = 28;
            dict["Sangram"] = 22;

            Console.WriteLine("\nHere We Modify the age of Rohan and Sangram: ");

            //Console.WriteLine("Age of 'Sangram':" + dict["Sangram"]);
           // Console.WriteLine("Age of 'Rohan':" + dict["Rohan"]);

            Console.WriteLine("The after Modification the Dictionary is :\n");
            foreach (KeyValuePair<string, int> kvp in dict)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            Console.WriteLine("\nRemoving The Sahil from Dictionary and updated dictionary is: \n");

            dict.Remove("Sahil");
            foreach (KeyValuePair<string, int> kvp in dict)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            Console.WriteLine("Check The Vishal is present in dictionary: \n");

            if (dict.ContainsKey("Vishal"))
                Console.WriteLine("Key : Vishal  is present in the Dictionary. \n");

            else
                Console.WriteLine("Key : vishal  is absent in dictionary");

            Console.WriteLine("here we clear the Dictionary:");
            dict.Clear();
        }
    }
}
