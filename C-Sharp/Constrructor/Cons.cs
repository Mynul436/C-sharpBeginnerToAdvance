using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constrructor
{
    internal class Cons
    {
        Cons()
        {
            Console.WriteLine("Cons has called");
        }
        static void Main(string[] args)
        {
            // Cons cons = new Cons();
            
            consTructor abc =new consTructor();
        }
    }

    class consTructor
    {
        public consTructor()
        {
            Console.WriteLine("Constructor has called");
        }


    }
}
