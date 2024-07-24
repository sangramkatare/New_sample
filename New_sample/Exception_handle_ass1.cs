using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_sample
{
    internal class Exception_handle_ass1
    {
        static void Main()
        {
            int num1;
            int num2;
            int output;
            try
            {
               
                Console.Write("Enter the First number: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the Second number: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                
                output = num1 + num2;
                Console.WriteLine($"\n Addition of {num1} and {num2} is : {output}");

                output = num1 - num2;
                Console.WriteLine($"\n Substraction of {num1} and {num2} is : {output}");

                output = num1 * num2;
                Console.WriteLine($"\n Multiplication of {num1} and {num2} is : {output}");

                output = num1 / num2;
                Console.WriteLine($"\n Division of {num1} and {num2} is : {output}");

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"\n Here The DivideByZero Exception Caught!! : {ex.Message}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"\n Here The Overflow  Exception Caught!! : {ex.Message}");
            }
         
            catch (ArithmeticException ex)
            {
                Console.WriteLine($"\n Here The Format Arithmetic Exception Caught!! : {ex.Message}");
            }
            
            catch (FormatException ex)
            {
                Console.WriteLine($"\n Here The Format Exception Caught!! : {ex.Message}");
            }
            finally
            {
                Console.WriteLine("\n So, Here finally Code execute");
            }

        }
    }
}