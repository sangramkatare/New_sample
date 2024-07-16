using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// method same parameter same and different class
// we used for acieving the Run time polymphism using vitual and override keyword
namespace New_sample
{

    //base class
    class Shape
    {
        //virtual method 
        public virtual void Draw()
        {
            Console.WriteLine("drawing shape");
        }
    }
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("drawing rectangle");
        }

    }
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("drawing circle");
        }

    }
    internal class DynamicPolymorphism
    {
        static void Main()
        {
            // Create obj
            Shape shape1 = new Shape();
            Shape shape2 = new Circle();
            Shape shape3 = new Rectangle();

            //call method
            shape1.Draw();
            shape2.Draw();
            shape3.Draw();
        }
    }
}
