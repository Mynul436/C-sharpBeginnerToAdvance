using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p1=new Program();   
            Console.WriteLine($"Garbage generation in the system: {GC.MaxGeneration} has p1 in {GC.GetGeneration(p1)}");
           GC.Collect();
            Console.WriteLine(GC.CollectionCount(0));
        }
    }
}
