using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_sample
{
    public class Person
    {
        protected int Age;
        protected string Name;
        
    }
    class Student : Person
    {
        public void data()
        {
            Age = 21;
            Name = "Sangram";
            Console.WriteLine("student Name: " + Name);
            Console.WriteLine("student Age: " + Age);
        }
    }

    internal class Singleinheritance_ass
    {
        public static void Main()
        {
            Student S = new Student();
            S.data();
        }
    }
}
