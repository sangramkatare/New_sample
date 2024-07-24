using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace New_sample
{
    internal class Arraylist_ass
    {
        static void Main()
        {
            ArrayList arrayList = new ArrayList()
            {
                1,
                "Sangram",
                4.2,
                false,
                "Hello",
                true,
                100,
                22,
                0.3
            };
            Console.WriteLine("The Array List is here: ");
            foreach(var item in arrayList)
            {
                Console.WriteLine("\t"+item);
            }

            Console.WriteLine("Here we Remove the First Three element of Array list\n");

            arrayList.RemoveRange(0,3);

            Console.WriteLine("After Removing these items the List is : \n");
            foreach (var item in arrayList)
            {
                Console.WriteLine("\t" + item);
            }

            Console.WriteLine(" Here We update the list,So We insert the 1000 in the first location\n ");
            arrayList.Insert(0, 1000);

            foreach (var item in arrayList)
            {
                Console.WriteLine("\t" + item);
            }
            
        }
    }
}
