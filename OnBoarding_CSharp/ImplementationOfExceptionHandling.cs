using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBoarding_CSharp
{
    class MyException : Exception
    {
        public MyException(string str)
        {
            Console.WriteLine("User defined exception");
        }
    }

    public class ExampleExceptionHandling
    {
        //Method to verify trycatchfinally
        public void verifytryCatchFinally()
        {
            int num = 0;
            int div = 0;
            try
            {
                Console.WriteLine("Executed example of trycatchfinally");
                div = 100 / num;
                Console.WriteLine("Not executed line");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("DivideByZeroException");
            }
            catch (Exception)
            {
                Console.WriteLine("Exception");
            }
            finally
            {
                Console.WriteLine("Finally Block");
            }
            Console.WriteLine($"Result is {div}"+"\n\n");
        }
        //Method to verify throw keyword
        public void VerifyThrowKeyword()
        {
            try
            {
                Console.WriteLine("Executed example of throw keyword");
                throw new DivideByZeroException("Invalid Division");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exception"+"\n\n");
            }
        }

        public void VerifyCustomException()
        {
            try
            {
                Console.WriteLine("Execute example of custom exception");
                throw new MyException("Niranjan");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught here" + e.ToString());
            }
        }
    }

    internal class ImplementationOfExceptionHandling
    {
        //public static void Main(string [] args)
        //{
        //    ExampleExceptionHandling exampleExceptionHandling = new ExampleExceptionHandling();
        //    exampleExceptionHandling.verifytryCatchFinally();
        //    exampleExceptionHandling.VerifyThrowKeyword();
        //    exampleExceptionHandling.VerifyCustomException();
        //}
    }
}
