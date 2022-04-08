using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBoarding_CSharp
{
    public class Base
    {
        private int x = 10;
        protected int y = 20;
        internal int z = 30;

        public enum month
        {            
            jan,
            feb,
            mar,
            apr,
            may
        }

    }

    public class Derived : Base
    {
        public void print()
        {
            Console.WriteLine("Base Class Protected Variable Value "+base.y);
            //Internal variable can be accessed within namespace
            Console.WriteLine("Base Class Internal Variable Value " + base.z+"\n");
        }

        public void GetEnumValues()
        {
            Console.WriteLine("The value of jan in month " +(int)month.jan);
            Console.WriteLine("The value of feb in month " + (int)month.feb);
            Console.WriteLine("The value of mar in month "+ (int)month.mar);
            Console.WriteLine("The value of apr in month "+ (int)month.apr);
            Console.WriteLine("The value of may in month "+ (int)month.may);
        }

        public void OperatorHierarchy()
        {
            int result1;
            int a = 5, b = 6, c = 4;
            result1 = --a * b - ++c;
            Console.WriteLine(result1);
        }

    }

    internal class ImplementationOfAccessModifiersinInheritance
    {
        //public static void Main(string [] args)
        //{
        //    Derived derived = new Derived();
        //    derived.print();
        //    derived.GetEnumValues();
        //    derived.OperatorHierarchy();
        //}
        
    }
}
