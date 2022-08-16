using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.RealWorld
{
    public class QuickSort : IStrategy
    {
        public void Sort(List<string> list)
        {
            list.Sort();
            Console.WriteLine("This is a QuickSort");
            //throw new NotImplementedException();
        }
    }
}
