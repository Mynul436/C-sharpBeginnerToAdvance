using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i, j, c = 0;
           
            n=Convert.ToInt32(Console.ReadLine());
            string readLine = Console.ReadLine();
            string[] stringArray = readLine.Split(' ');
            char[,] m = new char[100, 100];

            for (i=0; i<n; i++)
            {
                for ( j = 0; j < n; j++)
                {
                    m[i, j] = char.Parse(stringArray[]);
                }
            }
        }
    }
}
