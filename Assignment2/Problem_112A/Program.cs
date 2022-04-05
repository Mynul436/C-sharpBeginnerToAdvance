using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_112A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();

            string str2 = Console.ReadLine();

            string ct1 = str1.ToLower();

            string ct2 = str2.ToLower();

            int i;

            if (ct1 == ct2)
            {
                Console.WriteLine("0");
            }
            else
            {
                for (i = 0; i < ct1.Length; i++)
                {
                    if (ct1[i] < ct2[i])
                    {
                        Console.WriteLine("-1");
                        break;
                    }
                    if (ct1[i] > ct2[i])
                    {
                        Console.WriteLine("1");
                        break;
                    }
                }
            }
        }
    }
}
