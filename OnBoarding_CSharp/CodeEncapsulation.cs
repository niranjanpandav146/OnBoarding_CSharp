using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBoarding_CSharp
{
    public class EmployeeDetails
    {
        private string empName;

        public string accessEmpName
        {
            get { return empName; }
            set { empName = value; }
        }
    }
    class CodeEncapsulation
    {
        //public static void Main(string[] args)
        //{
        //    EmployeeDetails emp = new EmployeeDetails();
        //    emp.accessEmpName = "Niranjan Pandav";
        //    Console.WriteLine("Employee Name is " + emp.accessEmpName);
        //}

    }
}
