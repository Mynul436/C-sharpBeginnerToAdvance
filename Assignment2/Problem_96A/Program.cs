﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_96A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, o, p = 0;
            string str = Console.ReadLine();
            char[] n = str.ToCharArray();
            o = n.Length;
            for (i = 0; i < o - 6; i++)
            {
                if (n[i] == '0' && n[i + 1] == '0' && n[i + 2] == '0' && n[i + 3] == '0' && n[i + 4] == '0' && n[i + 5] == '0' && n[i + 6] == '0')
                {
                    p = 7;
                    break;
                }
                if (n[i] == '1' && n[i + 1] == '1' && n[i + 2] == '1' && n[i + 3] == '1' && n[i + 4] == '1' && n[i + 5] == '1' && n[i + 6] == '1')
                {

                    p = 7;
                    break;
                }
            }
            if (p == 7)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
