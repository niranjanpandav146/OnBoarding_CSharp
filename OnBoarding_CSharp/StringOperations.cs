using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBoarding_CSharp
{
    internal class StringOperations
    {

        public static void Main(string [] args)
        {
            string _fname = "Niranjan";
            string _lname = "Pandav";

            Console.WriteLine(string.Concat(_fname, _lname));

            if (_fname.Equals("Niranjan"))
            {
                Console.WriteLine("Matched _fname : " + _fname);
            }
            else
                Console.WriteLine("Not Matched _fname");
            
            
            if(_lname.Contains("Pan"))
            {
                Console.WriteLine("Verified Contains Method");
            }
            else
            {
                Console.WriteLine("Not Verified Contains Method");
            }

        }
        


    }
}
