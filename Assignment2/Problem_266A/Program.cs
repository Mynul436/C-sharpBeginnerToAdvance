using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_266A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=Convert.ToInt32(Console.ReadLine());
            int ct=0;
          
           string str = Console.ReadLine();
          
            for (int i =0; i <str.Length; i++)
            {  
                if  (i == str.Length - 1)
                    break;
                if(str[i] == str[i + 1])
                {
                    ct++;
                 
                }

            }
           Console.WriteLine(ct);
        
        }
    }
}
