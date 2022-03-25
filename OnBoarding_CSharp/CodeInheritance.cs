using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBoarding_CSharp
{

    class Animal
    {
        public string name = "";

        public void display()
        {
            Console.WriteLine("It's Animal");
        }
    }

    class Dog : Animal
    {
        public void getName()
        {
            Console.WriteLine("My name is: "+name);
        }
    }
         
    class CodeInheritance
    {

        //public static void Main(string [] args)
        //{
        //    Dog D = new Dog();
        //    D.name = "Rott";
        //    D.display();
        //    D.getName();
        //}

    }
}
