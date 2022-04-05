using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_59A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char[] n = str.ToCharArray();
            int i, j, len, lower = 0, upper = 0;
            len= n.Length;
            for (i = 0; i < len; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z')
                    lower++;
                else if (str[i] >= 'A' && str[i] <= 'Z')
                    upper++;
            }
            if (lower > upper)
            {
                
                Console.WriteLine(str.ToLower());
            }
            else if (lower < upper)
            {
                
                Console.WriteLine(str.ToUpper());
            }
            else if (lower == upper)
            {
                
                Console.WriteLine(str.ToLower());
            }
           

        }
    }
}
