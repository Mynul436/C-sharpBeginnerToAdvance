using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_71A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int TeatCase=Convert.ToInt32(Console.ReadLine());
            while(TeatCase-- > 0)
            {
                string arr = Console.ReadLine();
                    int l=arr.Length;
               
                    if (arr.Length <= 10)
                    {
                        Console.WriteLine(arr);
                    }
                    else
                    {
                    //arr.Split();
                    //  Console.WriteLine($"{arr[0]}",arr.Length-2,$"{arr[arr.Length]}");
                     Console.WriteLine("{0}{1}{2}",arr[0],arr.Length-2,arr[l-1]);
                   // Console.Write(arr[0]);
                  //  Console.Write(arr.Length-2);
                  //  Console.Write(arr[l-1]);
                    }
                   
            }
        }
    }
}
