using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_sample
{
    public class Person1
    {
        public void Property1()
        {
            Console.WriteLine("I am Person.");
        }

    }
    class Teacher : Person1
    {
        public void Property2()
        {
            Console.WriteLine("I am Teacher.");
        }
    }
    class Principal1 : Teacher
    {
        public void Property3()
        {
            Console.WriteLine("I am Principal.");
        }
    }
    internal class Multilevel_ass
    {
        public static void Main()
        {
            Principal1 P = new Principal1();
            P.Property1();
            P.Property2();
            P.Property3();
        }
    }
}
