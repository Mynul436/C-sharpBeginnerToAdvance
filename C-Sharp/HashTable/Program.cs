using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable h1 = new Hashtable() {
                {"salary",4000 }
            
            };
            h1.Add("id", 1234);
            h1.Add("name", "Mynul");

            Console.WriteLine(h1.Contains("name"));
            Console.WriteLine(1234.GetHashCode());
            foreach (var item in h1.Keys)
            {
                Console.WriteLine(item);
                Console.WriteLine(h1[item]);
            }
            Console.WriteLine("1234".GetHashCode());
            //  Console.WriteLine(h1["name"]);

        }
    }
}
