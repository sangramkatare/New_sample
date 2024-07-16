using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_sample
{
    class math_operation
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public double Add(double a,double b)
        {
            return a + b;
        }
    }
    internal class StaticPolymorphism
    {
        static void Main(string[] args)
        {
            math_operation math = new math_operation();

            // call overloading method
            int sum1 = math.Add(1, 2);
            double sum2 = math.Add(5.2, 3);

            Console.WriteLine("Sum of integer:" + sum1);
            Console.WriteLine("Sum of doubles:" + sum2);
        }
    }
}
