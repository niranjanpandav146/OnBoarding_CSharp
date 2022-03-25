using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBoarding_CSharp
{

    abstract class Shape
    {
        protected float len, rad, bred;

        public abstract float area();
    }

    class Rectangle : Shape
    {
        public void GetLen()
        {
            Console.Write("Enter Length ");
            len = float.Parse(Console.ReadLine());
            Console.Write("Enter Breadth ");
            bred = float.Parse(Console.ReadLine());
        }

        public override float area()
        {
            return len * bred;
        }

    }

    class Circle : Shape
    {
        public void GetRad()
        {
            Console.Write("Enter Radius ");
            rad = float.Parse(Console.ReadLine());
            
        }

        public override float area()
        {
            return 3.14F*rad*rad;
        }

    }

    class CodeAbstract
    {

        public static void Calculate(Shape S)
        {
            Console.WriteLine("Area :"+ S.area());
         
        }
        //public static void Main(string [] args)
        //{
        //    Rectangle R = new Rectangle();
        //    R.GetLen();
        //    Calculate(R);

        //    Console.WriteLine();
        //    Circle C = new Circle();
        //    C.GetRad();
        //    Calculate(R);


        //}

    }
}
