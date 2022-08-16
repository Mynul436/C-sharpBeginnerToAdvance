using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassNew
{
    public class Abc<T>
    {
        T box;
        //public Abc(T b)
        //{
        //    this.box = b;
        //}
        //public T Box { get { return box; } }
        public T Box {
            set { 
            this.box = value;
            }
            get
            {
                return this.box;
            }
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            //Abc<int> t1 = new Abc<int>(30);
            Abc<int >t1=new Abc<int>();
            t1.Box = 1000;
            Console.WriteLine(t1.Box);
        }
    }
}
