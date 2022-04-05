using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_263A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x=0,y=0,i,j;
            var numbers = new int[5, 5];

            for ( i = 0; i < 5; i++)
            {
                var numList = new string[5];
                numList = Console.ReadLine().Split();
                for ( j = 0; j < 5; j++)
                {
                    numbers[i, j] = Convert.ToInt32(numList[j]);
                    
                }
            }
            for ( i = 0; i < 5; i++)
            {
                for ( j = 0; j < 5; j++)
                {
                    if (numbers[i,j] == 1)
                    {
                        x = i + 1;
                        y = j + 1;
                    }
                }
            }
            Console.WriteLine(Math.Abs(x-3)+Math.Abs(y-3));


        }
    }
}
