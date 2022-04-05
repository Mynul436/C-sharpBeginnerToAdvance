using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_791A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[2];

            int i = 0,j;
            foreach (string s in Console.ReadLine().Split())
            {
                arr[i] = int.Parse(s);
                i++;
            }
            for ( j = 1; ; j++)
            {
                arr[0] *= 3;
                arr[1] *= 2;
                if (arr[0] > arr[1])
                    break;
            }
            Console.WriteLine(j);
        }
    }
}
