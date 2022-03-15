using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfStaticClass
{
    static internal class Program
    {
        public static string f_name = "Mynul";
        public static string l_name = "Akash";
         static Program()
        {

        }
        public static void details()
        {
            Console.WriteLine("hi....");
        }
        static void Main(string[] args)
        {
           Program.details();
            Console.WriteLine("Authors first name is :{0}", Program.f_name);
            Console.WriteLine(Program.l_name);

        }
    }
}
