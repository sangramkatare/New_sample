using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_sample
{
    internal class Dictionary_lec
    {
        static void Main()
        {
            //Initilize dictionary
            Dictionary<string, int> agedic = new Dictionary<string, int>();

            //add key value pair
            agedic.Add("Sangram", 22);
            agedic.Add("Rohit", 23);
            agedic.Add("Rohan", 24);

            //print all element

            Console.WriteLine("ALL elements in the Age Dictionary");
            foreach (KeyValuePair<string, int> kvp in agedic)
            {
                Console.WriteLine($"{kvp.Key} : {kvp.Value}");
            }

            //print specific items values
            Console.WriteLine("\nAge of 'Sangram':" + agedic["Sangram"]);
            Console.WriteLine("\nAge of 'Rohit':" + agedic["Rohit"]);

            // Modify the values

            agedic["Rohit"] = 29;
            agedic["Sangram"] = 27;

            Console.WriteLine("Modify List: ");

            foreach (KeyValuePair<string, int> kvp in agedic)
            {
                Console.WriteLine($"{kvp.Key} : {kvp.Value}");
            }

        }
    }
}
