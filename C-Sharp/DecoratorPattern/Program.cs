using DecoratorPattern.Component;
using DecoratorPattern.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            ICar abc =new SUV();
            abc=new AlloyWheelDecorator(abc);
            Console.WriteLine(abc.GetPrice());
            
        }
    }
}
