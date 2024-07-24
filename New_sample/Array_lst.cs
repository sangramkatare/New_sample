using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_sample
{
    internal class Array_lst
    {
        static void Main()
        {
            //create array list

            ArrayList lst = new ArrayList();

            // add item in list
            lst.Add(1);
            lst.Add("Hello");
            lst.Add(false);
            // access the element

            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }

            //remove the item

            lst.Remove(false);
            foreach (var item in lst)
            {
                Console.WriteLine("\n"+item);
            }
        }

    }
}
