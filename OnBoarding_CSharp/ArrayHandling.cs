using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBoarding_CSharp
{
    public static class Extensions
    {
        public static bool find<T>(this T[] array, T target)
        {
            return Array.Exists(array, x => x.Equals(target));
        }
        
    }
    internal class ArrayHandling
    {
        //public static void Main(string[] args)
        //{
        //    int[] array = { 7, 2, 33, 4, 9 };
        //    int target = 4;

        //    //Array Element Search
        //    bool isExist = array.find(target);
        //    if (isExist)
        //    {
        //        Console.WriteLine("Element found in the array" + "\n");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Element not found in the given array"+"\n");
        //    }

        //    //Array Sort
        //    Array.Sort(array);
        //    Console.WriteLine("Sorted Array in ASC");
        //    foreach (int i in array)
        //    {
        //        Console.Write(i + " ");
        //    }
        //    Console.WriteLine("\n");
        //    Array.Reverse(array);
        //    Console.WriteLine("Sorted Array in DESC");
        //    foreach (int i in array)
        //    {
        //        Console.Write(i + " ");
        //    }

        //}
    }
}
