using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_sample
{
    public class A
    {
        public void Eat()
        {
            Console.WriteLine("Eating");
        }
    }
    public class B : A
    {
        public void Drink()
        {
            Console.WriteLine("Drinking");
        }
    }
        public class C:B
        {
            public void Bark()
            {
                Console.WriteLine("Barking");
            }
        }

    internal class Multilevelinheritance
    {
        static void Main()
        {
            C a=new C();
            a.Eat();
            a.Drink();
            a.Bark();
        }

    }
}
