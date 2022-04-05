using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_617A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t, a;
            t = Convert.ToInt32(Console.ReadLine());
            if (t == 5)
            {
                Console.WriteLine(1);

            }
            else if (t % 5 == 0)
            {
                Console.WriteLine(t/5);

            }
            else
                Console.WriteLine((t / 5) + 1);

        }
    }
} 