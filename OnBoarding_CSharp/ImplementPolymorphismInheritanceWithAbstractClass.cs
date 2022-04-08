using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBoarding_CSharp
{
    public abstract class Worker
    {
        private string FSname;
        private string LSname;

        
        public Worker(string FSnameval, string LSnameval)
        {
            FSname = FSnameval;
            LSname = LSnameval;
        }
        
        public string Fsname
        {
            get
            {
                return Fsname;
            }
            set
            {
                Fsname = value;
            }
        }        
        public string Lsname
        {
            get
            {
                return Lsname;
            }
            set
            {
                Lsname = value;
            }
        }
        // return a string of the Worker information
        public override string ToString()
        {
            return FSname + " " + LSname;
        }        
        public abstract decimal Income();
    }


    public class Chief : Worker
    {
        private decimal salary;

        // constructor of Chief class
        public Chief(string FSname, string LSname, decimal salary) : base(FSname, LSname)
        {
            Weeklyincome = salary;
        }
        // Get & Set for the Weeklyincome
        public decimal Weeklyincome
        {
            get
            {
                return salary;
            }
            set
            {
                // only positive salary value
                if (value > 0)
                    salary = value;
            }
        }

        // override worker method to calculate the Income
        public override decimal Income()
        {
            return Weeklyincome;
        }

        // return a string of the Chief information
        public override string ToString()
        {
            return "Chief: " + base.ToString();
        }
    }

    internal class ImplementPolymorphismInheritanceWithAbstractClass
    {
        //public static void Main(string [] args)
        //{
        //    Chief chief = new Chief("Niranjan", "Pandav", 800);
        //    Worker Worker = chief;
        //    string output = GetString(Worker);
        //    Console.WriteLine(output);
        //}
        public static string GetString(Worker worker)
        {
            return worker.ToString() + " earned " + worker.Income().ToString("C") + "\n";
        }
    }
}
