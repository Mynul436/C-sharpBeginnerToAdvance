using DecoratorPattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
    public class AlloyWheelDecorator : CarDecorator
    {
      

        public AlloyWheelDecorator(ICar car) : base(car)
        {
        }
        public override int GetPrice()
        {
            return car.GetPrice();
        }
    }
}
