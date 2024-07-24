using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_sample
{
    internal class Exception_handel
    {
        static void Main()
        {
            int[] Number = { 1, 2, 3 };
            int index = 4;

            try // this block is used for write logic
            {
                int value = Number[index];//Error is occuered then control goes to catch block
                Console.WriteLine($"Value at index {index} is : {value}");
            }
            catch (IndexOutOfRangeException ex)// in this block we handle the exception
            {
                Console.WriteLine($"an error occured : {ex.Message}");
            }
            finally // this block execute every time
            {
                Console.WriteLine("The code excute everytime:");
            }
            int a =10; int b =0; 
            double result = 0;
            try
            {
                result = a / b;
                Console.WriteLine($"The result of division is:{result}");
            }
            catch (DivideByZeroException ex)
           {
               // Console.WriteLine($"the error is occured : {ex.Message}");
           }

        }
    }
}
