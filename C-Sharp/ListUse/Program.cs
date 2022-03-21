using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListUse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> food = new List<string>();
            food.Add("Tormuj");
            food.Add("Banana");
            foreach (var item in food)
            {
                Console.WriteLine(item);
            }
        }
    }
}
