using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Example
    {
        //public static void showArray<T>(T[] arr)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.WriteLine(arr[i]);
        //    }
        //}
        public static bool check<S,T>(S A,T B)
        {
            return A.Equals(B);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[3];
            //numbers[0] = 11;
            //numbers[1] = 22;      
            //numbers[2] = 33;
            //string[] names = { "Mynul", "Soad", "Kanon" };
            //Example.showArray(names);
            //Example.showArray(numbers);
            Console.WriteLine(Example.check(100, 10));
            Console.WriteLine(Example.check(100,"c"));
            Console.ReadLine();
        }
    }
}
