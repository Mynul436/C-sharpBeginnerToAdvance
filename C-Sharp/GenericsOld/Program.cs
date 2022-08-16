using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsOld
{
    public class Abc {
    public static void showArray<T> (T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    
    }

    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(23);
            arrayList.Add("Hello");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            int[] arr = new int[3];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            Abc.showArray(arr);

            List<string> list = new List<string>();
            list.Add("sadf");
            Month m = new Month();
            var abc = (int)Month.September;
            Console.WriteLine(abc);
            int a = 10;
            int b = 4;
            bool c=a.Equals(b);
            Console.WriteLine(c);
        }
            enum Month

        {
            January,
            February,
            March,
            April,
            May,
            June,
            July=10,
            August,

            September
        }

        
    }
}
