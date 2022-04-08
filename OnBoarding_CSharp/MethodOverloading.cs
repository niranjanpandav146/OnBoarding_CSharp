using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBoarding_CSharp
{
    internal class MethodOverloading
    {
        //addition of three integer type value
        public int Add(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }
        // adding three double tpye values.
        public double Add(double a,
                          double b, double c)
        {
            double sum = a + b + c;
            return sum;
        }

        //public static void Main(string [] args)
        //{
        //   MethodOverloading methodOverloading = new MethodOverloading();
        //   int sum_int = methodOverloading.Add(1, 2, 3);
        //   Console.WriteLine("Sum of three Integers values  " + sum_int);
        //   double sum_double = methodOverloading.Add(1.0, 2.0, 3.0);
        //   Console.WriteLine("Sum of three double values " + sum_double);
        //}

    }
}
