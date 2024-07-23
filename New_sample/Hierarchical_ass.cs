using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_sample
{
   public abstract class Shape1
    {
        protected string colour;
        protected double length;
        protected double breadth;
        protected double Radius;
        protected double Area;
       public  abstract void area();

        public void Displaydetail(string s)
        {
            this.colour = s;
            Console.WriteLine(" ");
            Console.WriteLine("The details of The :" + GetType().Name);
            Console.WriteLine("The color is: "+colour);

        }
    }
    public class Rectangle1 : Shape1
    {

        public override void area()
        {
            length = 10.2;
            breadth = 5;
            Area = length * breadth;
     
            Console.WriteLine("The Length is: " + length);
            Console.WriteLine("The Breadth is: " + breadth);
            Console.WriteLine("Area of the Rectangle: " + Area);
        }
    }
    public class Circle2 : Shape1
    {

        public override void area()
        {
            Radius = 5;
            Area = 3.14 * (Radius * Radius);
          
            Console.WriteLine("Radius of the Circle: " + Radius);
            Console.WriteLine("Area of the Circle: " + Area);
        }
    }
    internal class Hierarchical_ass
    {
        static void Main()
        {

            Rectangle1 R = new Rectangle1();
            R.Displaydetail("Blue");
            R.area();
            Circle2 C = new Circle2();
            C.Displaydetail("Red");
            C.area();
        }
    }
}
