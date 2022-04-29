using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBoarding_CSharp
{
    public class LINQ
    {
        //public static void Main(string [] args)
        //{
        //    // Student collection
        //    IList<Student> studentList = new List<Student>() {
        //    new Student() { StudentID = 1, StudentName = "Anand", Age = 18, StandardID = 1 } ,
        //        new Student() { StudentID = 2, StudentName = "Kishan",  Age = 21, StandardID = 1 } ,
        //        new Student() { StudentID = 3, StudentName = "Krishna",  Age = 18, StandardID = 2 } ,
        //        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID = 2 } ,
        //        new Student() { StudentID = 5, StudentName = "Prashant" , Age = 21 }
        //};

        //    var studentNames = studentList.Where(s => s.Age > 18)
        //                          .Select(s => s)
        //                          .Where(st => st.StandardID > 0)
        //                          .Select(s => s.StudentName);


        //    foreach (var name in studentNames)
        //    {
        //        Console.WriteLine(name);
        //    }

        //}

    }
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public int StandardID { get; set; }
    }
}
