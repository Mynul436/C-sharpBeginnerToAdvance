using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_546A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  sum = 0;

          
            int[]arr=new int[3];
            
            int i=0;
            foreach (string s in Console.ReadLine().Split())
            {
                arr[i] = int.Parse(s);
                i++;
            }

            for ( i = 1; i <= arr[2]; i++)
            {
                sum += i * arr[0];
            }
            if (sum > arr[1])
                Console.WriteLine(sum - arr[1]);

            else
                Console.WriteLine(0);
        }
    }
}
