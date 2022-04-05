using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_58A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            int pas=0;
            
            string str=Console.ReadLine();
            str.Split();
            string str1 = "hello";
            for (int i = 0; i < str.Length; i++)
            {
               if(str[i] ==str1[j])
                {
                    j++;
                    pas++;
                    if (pas == 5)
                    {
                        break;
                    }
                }
            }
            if (pas == 5)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
