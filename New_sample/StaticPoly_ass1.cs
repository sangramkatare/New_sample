using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_sample
{
    class calculator
    {
        public double Area(double Length, double Breadth)
        {
            return Length * Breadth;
        }
        public double Area(double Length, double Breadth, double Height)
        {
            return Length * Breadth * Height;
        }
        public int Area(int Side)
        {
            return Side * Side;
        }
        public double Area(double Radius)
        {
            return 3.14*(Radius*Radius);
        }

    }
    internal class StaticPoly_ass1
    {
        static void Main(string[] args)
        {
            calculator obj = new calculator();

            double area_rec = obj.Area(10.2, 9);
            double area_tri = obj.Area(5,4,3.3);
            double area_sqar = obj.Area(6);
            double area_cir = obj.Area(5.30);

            Console.WriteLine("The area of Rectangle is: " + area_rec);
            Console.WriteLine("The area of Triangle is: " + area_tri);
            Console.WriteLine("The area of Square is: " + area_sqar);
            Console.WriteLine("The area of circle is: " + area_cir);
        }
    }
}
