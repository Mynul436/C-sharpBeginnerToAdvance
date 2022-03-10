using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Program
    {
        static void Main(string[] args)
        {
            int TestCase;
            TestCase = Convert.ToInt32(Console.ReadLine());
            while (TestCase!=0)
            {
               int num = Convert.ToInt32(Console.ReadLine());
                int max;
                int min;
         /*   int[] arr = new int[num];
             for (int i = 0; i < num; i++)
             {
                 arr[i] =Convert.ToInt32(Console.ReadLine());
             }
         */
            string[] x = Console.ReadLine().Split(' ');
            int[]arr = new int[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                arr[i] = Convert.ToInt32(x[i]);
            }
           
             max= arr.Max();
             min= arr.Min();
         /*   max = arr[0];
            min = arr[0];

            for (int i = 1; i <x.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }


                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }*/
          
            Console.WriteLine(max - min);

                TestCase--;
            }
        }
    }

