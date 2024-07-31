using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_sample
{
    internal class Genericdelegate
    {
        public delegate double delegate1(int a, float b, double c );
        public delegate void delegate2(int x, float y, double z);
        public delegate bool delegate3(string str);

        public static double Addnumbers1(int a,float b,double c)
        {
            return a + b + c;

        }
        public static void AddNumbers2(int x, float y, double z)
        {
           Console.WriteLine( x + y + z);

        }
        public static bool CheckLength(string str)
        {
            if (str.Length>5)
                return true; 
            return false;
        }
        static void Main()
        {
            //func 
            Func<int, float, double, double> obj1 = Addnumbers1;
            double result = obj1.Invoke(100, 125f, 256.23);
            Console.WriteLine(result);

            //Action

            Action<int, float, double> obj2 = AddNumbers2;
            obj2.Invoke(200, 125f, 265.13);

            //predicate
            Predicate<string> obj3 = CheckLength;
            bool status = obj3.Invoke("hiii");
            Console.WriteLine(status);
        }

    }
}
