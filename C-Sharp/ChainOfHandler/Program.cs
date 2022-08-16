using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfHandler
{
    public class Program
    {
        static void Main(string[] args)
        {
            IHandles h1 = new ConcreteHandler1();
            IHandles h2 = new ConcreteHandler2();
            IHandles h3 = new ConcreteHandler3();
            h1.SetSuccessor(h2);
            h2.SetSuccessor(h3);

            int[] abc = { 2, 5, 14, 22, 18, 3, 27, 20 };
            foreach (var item in abc)
            {
                h1.HandleRequest(item);
            }

        }
    }
}
