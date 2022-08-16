using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.RealWorld
{
    public class ShellSort : IStrategy
    {
        public void Sort(List<string> list)
        {
            Console.WriteLine("This is a Shell Sort");

        }
    }
}
