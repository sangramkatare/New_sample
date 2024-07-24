using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_sample
{
    internal class Hashtble
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();
            
            //add key and value
            ht.Add(101, "Java");
            ht.Add(102, "Dotnet");
            ht.Add(103, 9098);
            ht.Add(104, true);

            // typecast
            string value1 = (string) ht [101];
            string value2 = (string) ht [102];
            string value3 = Convert.ToString((int)ht[103]);
            bool value4 =(bool)ht[104];

            //print key value
            Console.WriteLine($"[101]:{value1}");

            Console.WriteLine($"[102]:{value2}");

            Console.WriteLine($"[103]:{value3}");
            Console.WriteLine($"[104]:{value4}");

        }
       
    }
}
