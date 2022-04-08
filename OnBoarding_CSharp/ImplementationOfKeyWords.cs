using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBoarding_CSharp
{
    class BasicDetails
    {
        private string Name="";

        public string GetName()
        {
            return Name;
        }
        public void SetName(string Name)
        {
            // referring to current instance
            //"this.Name" refers to class member
            this.Name = Name;
        }
    }

    class Animals
    {
        // Creating static variable
        // Using static keyword
        public static string Animal_color = "Black";
        const string str = "Test";

        public void VerifyBreakandContinue()
        {
            int i;
            for (i = 0; i <= 10; i++)
            {
                if (i == 5)
                    continue;
                if (i == 8)
                    break;
                Console.WriteLine("value is " + i);
            }
        }


    }
        internal class ImplementationOfKeyWords
        {
        //public static void Main(string[] args)
        //{
        //    Animals animal = new Animals();
        //    BasicDetails basic = new BasicDetails();
        //    Console.WriteLine("Color of Animal " + Animals.Animal_color + "\n");
        //    animal.VerifyBreakandContinue();

        //    basic.SetName("Niranjan");
        //    Console.WriteLine("\n" + basic.GetName());
        //}
    }
}