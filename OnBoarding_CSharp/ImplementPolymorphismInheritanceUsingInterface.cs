using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBoarding_CSharp
{
    public interface IPrint
        {
            void print();
        }
    internal class ImplementPolymorphismInheritanceUsingInterface : IPrint
    {
        public void print()
        {
            Console.WriteLine("Print method from IPrint interface");
        }

        //public static void Main(string [] args)
        //{
        //    ImplementPolymorphismInheritanceUsingInterface ip = new ImplementPolymorphismInheritanceUsingInterface();
        //    ip.print();
        //}
    }
}
