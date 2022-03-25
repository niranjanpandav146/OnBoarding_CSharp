using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBoarding_CSharp
{
    class RunTimePolymorphism_MethodOveriding
    {
        class Animal
        {
            public virtual void eat()
            {
                Console.WriteLine("Base class eat method called");
            }
        }
        
        class Dog : Animal
        {         
            public override void eat()
            {
                //if we need to call base class method
                base.eat();

                Console.WriteLine("Derived class eat method called");
            }
        }
        //public static void Main(string [] args)
        //{
        //    //Calling derived class method
        //    Dog d =new Dog();
        //    d.eat();

            
        //}

    }
}
