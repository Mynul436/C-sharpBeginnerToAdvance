using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_236A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str=Console.ReadLine();
            char[] arr = str.ToCharArray();
            Array.Sort(arr);
            int ct = 0;
            
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    continue;
                }
                ct++;
            }
           // Console.WriteLine(ct);
            if (ct %2==0)
            {
                Console.WriteLine("IGNORE HIM!");
            }
            else
            {
                Console.WriteLine("CHAT WITH HER!");
            }
        }
    }
}
