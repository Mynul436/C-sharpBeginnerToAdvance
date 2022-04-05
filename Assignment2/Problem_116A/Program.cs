using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_116A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,b,sum1=0,sum2=0;
            int TestCase=Convert.ToInt32(Console.ReadLine());
            while (TestCase-- > 0)
            {
                string s = Console.ReadLine();
                string[] values = s.Split(' ');
                 a = int.Parse(values[0]);
                 b = int.Parse(values[1]);
                sum1 = (a + sum2) - b;
                if (sum1 < 0)
                    sum2 = 0;
                else
                    sum2 = sum1;

            }

            Console.WriteLine(sum1);
        }
    }
}
 