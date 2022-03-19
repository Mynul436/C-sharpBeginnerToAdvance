using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Squre : Shape
    {
        private int side;

        public Squre(int x)
        {
            side = x;
        }
        
        public override int area()
        {
            int a=0;
            Console.WriteLine("The area of Squre is {0}",a=side*side)
            return a;
        }
    }
}
