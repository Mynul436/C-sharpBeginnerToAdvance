using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethod
{
    public static class Func1 { 
        public static void Fab(this TestExtention original)
        {
            Console.WriteLine("This is fun1....");
        }
    

    }
}
