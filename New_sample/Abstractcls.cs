using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_sample
{
    // Abstract Class define using the abstract keyword
    public abstract class Animal
    {
        // Abstract Method define using the abstract keyword
        // we can not create defination of abstract class
        public abstract void Makesound();
        public void Eat()
        {
            Console.WriteLine("Animal");
        }

    }

    public class Dog : Animal
    {
        public override void Makesound()
        {
            Console.WriteLine("Dog");
        }
    }
    public class Cat : Animal
    {
        public override void Makesound()
        {
            Console.WriteLine("cat");
        }
    }
    internal class Abstractcls
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Makesound();
            dog.Eat();
            cat.Makesound();
            cat.Eat();
        }
    }
}

