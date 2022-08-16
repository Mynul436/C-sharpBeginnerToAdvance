using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public  class Program
    {
        static void Main(string[] args)
        {
            SingletonClass s1 = SingletonClass.GetInstance();
            SingletonClass s2 = SingletonClass.GetInstance();
            if (s1 == s2)
            {
                Console.WriteLine("Done!!");

            }
            else {
                Console.WriteLine("Nope!!!");
            
            }

        }
    }
}
