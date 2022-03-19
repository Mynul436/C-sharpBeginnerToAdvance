using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Program 
    {
       

        static void Main(string[] args)
        {
            Shape sh = new Squre(4);
            sh.area();
        }
    }

}