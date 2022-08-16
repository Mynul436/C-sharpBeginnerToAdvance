using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceVsAbstract
{
    interface I1
    {

    }
    interface I2
    {
         void show();
    }
   abstract class Abc:I1, I2
    {
        public abstract void show();
        
        ~Abc()
        {
            Console.WriteLine("Abc Destructor Invoked!!");
        }
        public Abc()
        {
            Console.WriteLine("Abstract class invoked!!");
        }
    }
    class myClass : Abc
    {
        public override void show()
        {
            // throw new NotImplementedException();
            Console.WriteLine("This is implementation of Abstract Class");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
           myClass myClass = new myClass();
            List<string> list = new List<string> {"Mynul","Islam","Akash"};
            foreach (var item in list)
            {
                Console.WriteLine(item+" ");
            }
        }
    }
}
