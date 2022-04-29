using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBoarding_CSharp
{
    public delegate void MyDelegate(string msg);

    public class Delegates
    {
        
        

        static void Main(string[] args)
        {
            //Implementation of defined delegate
            MyDelegate del = ClassA.MethodA;
            del("Called MethodA of ClassA using Delegate");

            // Implementation of normal function delegate
            Func<int, int, int> add = ClassA.Sum;

            int result = add(10, 20);
            Console.WriteLine("Functional Delegate Returned Value"+result);
        }
    }

    public class ClassA
    {
        public static void MethodA(string message)
        {
            Console.WriteLine(message);            
        }

        public static int Sum(int x, int y)
        {
            return x + y;
        }
    }
}
