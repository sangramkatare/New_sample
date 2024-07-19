using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_sample
{
    public class Animal1
    {
        public void Eat1()
        {
            Console.WriteLine("eating");
        }
    }
    public class Dog1: Animal1
    {
        public void Barking1()
        {
            Console.WriteLine("Barking");
        }
    }
    public class Cat1 : Animal1
    {
        public void Meow()
        {
            Console.WriteLine("Meow meow");
        }
    }

    internal class Hirarchical_inheritance
    {
        static void Main()
        {
            
            Dog1 a = new Dog1();
            a.Eat1();
            a.Barking1();

            Cat1 c = new Cat1();
            c.Eat1();
            c.Meow();
        }
    }
}
