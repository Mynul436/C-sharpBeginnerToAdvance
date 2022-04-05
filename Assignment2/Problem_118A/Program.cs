using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_118A
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string lower = Console.ReadLine();

            int l = lower.Length;

            string str = lower.ToLower();

            int count = 0;

            for (int j = 0; j < l; j++)

            {
                if (str[j] != 'a' && str[j] != 'e' && str[j] != 'i' && str[j] != 'o' && str[j] != 'u' && str[j] != 'y')

                {

                    count++;

                }
            }

            Console.Write(".");

            int pount = 0;

            for (int i = 0; i < l; i++)

            {
                if (str[i] != 'a' && str[i] != 'e' && str[i] != 'i' && str[i] != 'o' && str[i] != 'u' && str[i] != 'y' && pount != count - 1)
                {
                    Console.Write(str[i] + ".");
                    pount++;
                }
                else if (str[i] != 'a' && str[i] != 'e' && str[i] != 'i' && str[i] != 'o' && str[i] != 'u' && str[i] != 'y' && pount == count - 1)
                {
                    Console.WriteLine(str[i]);
                }
            }
        }
    }
}
