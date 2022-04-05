using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_977A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[2];

            int i = 0;
            foreach (string s in Console.ReadLine().Split())
            {
                arr[i] = int.Parse(s);
                i++;
            }

            while (arr[1]-- >0)
            {
                if (arr[0] % 10 == 0)
                    arr[0] /= 10;
                else
                    arr[0]--;
                //arr[1]--;
            }
            Console.WriteLine(arr[0]);
        }
    }
}
