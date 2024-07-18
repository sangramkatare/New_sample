using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_sample
{
    public abstract class Shapes
    {
        public abstract double CalculateArea();

        public void Display()
        {
            Console.WriteLine("This is a Details of " + GetType().Name);
        }
    }
    public class Rectangles : Shapes
    {
        public override double CalculateArea()
        {
            double length = 11.2;
            double breadth = 3.4;
            return (length * breadth);
        } 
    }
    public class Circles : Shapes
    {
        public override double CalculateArea()
        {
            double radius = 2.2;
            return (3.14 *( radius * radius));
        }
    }

    internal class AbstractClass_ass
    {
        static void Main (string[] args)
        {
            // define objects
            Rectangles rec = new Rectangles();
            Circles cir = new Circles();
            
            // rectangle Area
            rec.Display();
            double R = rec.CalculateArea();
            Console.WriteLine("Area of Rectangle: "+ R);

            Console.WriteLine(); // Blank line for separation

            // circle area
            cir.Display();
            double C = cir.CalculateArea();
            Console.WriteLine("Area of Circle: " + C);
        }
    }
}
