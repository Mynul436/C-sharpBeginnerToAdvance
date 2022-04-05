using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_263A
{
    internal class Program
    {
        private static object readLine;

        static void Main(string[] args)
        {
            int n=Convert.ToInt32(Console.ReadLine());
            // int[,]arr =new int[1,n-1];
            // for(int i = 0; i < arr.Length; i++)
            // {
            //     for (int j = 0; j <2 ; j++)
            //     {
            //        arr[i, j]= int.Parse(Console.ReadLine());
            //     }
            // }
          //  var numbers = new int[1, n-1];

            int[,] matrix1 = new int[n, 2];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    matrix1[i, j] = Int32.Parse(Console.ReadLine());
                }
            }
        }
    }
}
