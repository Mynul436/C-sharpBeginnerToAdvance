using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Class1
    {
        private int salary = 100000;
        private string name = "Mynul";
        Class1()
        {
            salary = 20000;
            Console.WriteLine(salary);  
            name = "Akash";
            Console.WriteLine(name);
        }
        static void Main(string[] arg)
        {
            Class1 c1 = new Class1();
            

        }
    }
    
       
    
}
