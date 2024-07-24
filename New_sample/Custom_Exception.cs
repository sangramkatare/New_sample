using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_sample
{
    class Exceptions
    {
        protected int number;
        public void method()
        {
            Console.WriteLine("Enter The Number: ");
            number = Convert.ToInt32(Console.Read());
        }
    } 
    class Negative_Exceptions : Exceptions
    {
        public void method1()
        {
            try
            {
                if (number > 0)
                {
                    Console.WriteLine($"The Number {number} is positive.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"The Negative Exception caught!! :{ex. Message} ");
            }

        }
    }

    internal class Custom_Exception
    {   
        static void Main(string[] args)
        {
            Negative_Exceptions N = new Negative_Exceptions();

            N.method();
            N.method1();
           
        }
    }
}
