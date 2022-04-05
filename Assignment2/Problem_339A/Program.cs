using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_339A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            int length = (str.Length) / 2;

            length  += 1;

            string[] v= str.Split('+');

            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {

                int a = int.Parse(v[i]);

                arr[i] = a;

            }

            for (int j = 0; j < length; j++)
            {
                for (int h = 0; h < length; h++)
                {
                    if (arr[h] < arr[j])
                    {
                        int temp = arr[j];
                        arr[j] = arr[h];
                        arr[h] = temp;
                    }
                }
            }

            for (int k = length - 1; k >= 0; k--)

            {
                if (k != 0)
                {
                    Console.Write(arr[k]);
                }
                if (k != 0)
                {
                    Console.Write("+");
                }
                if (k == 0)
                {
                    Console.WriteLine(arr[k]);
                }
            }
        }
    }
}
