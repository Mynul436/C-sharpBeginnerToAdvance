using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_133A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str =Console.ReadLine();
            str.Split();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'H' || str[i] == 'Q' || str[i] == '9' )
                {
                    Console.WriteLine("YES");
                    return ;
                }
             
            }
            Console.WriteLine("NO");
            return;
        }
    }
}
