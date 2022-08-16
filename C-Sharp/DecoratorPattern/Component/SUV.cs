using DecoratorPattern.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Component
{
    public class SUV : ICar
    {
        private AlloyWheelDecorator alloyWheelDecorator;

       

        public int GetPrice()
        {
            return 30000;
        }
    }
}
