using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ct=0;
            
            int sum=0;
            int temp=0;
            int k=Convert.ToInt32(Console.ReadLine());
            string readLine = Console.ReadLine();
            string[] stringArray = readLine.Split(' ');
            int[] month = new int[12];
            for (int i=0; i<12; i++)
            {
                month[i]= int.Parse(stringArray[i]);
            }
            int[] arr = new int[12];
               
            if (k == 0)
            {
                Console.WriteLine(0);
                return;
            }
            Array.Sort(month);
            Array.Reverse(month);

            
           for (int i = 0; i < 12; i++)
            {
                
                sum += month[i];
                ct++;
              //  Console.WriteLine(month[i]);
               // Console.WriteLine("sum"+sum);
               // Console.WriteLine("ct"+ct);
                if (sum >= k) break;
            }
            
            if (sum < k)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(ct);
            }

        }
    }
}
