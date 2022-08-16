using DecoratorPattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
    public class CarDecorator : ICar
    {
        protected readonly ICar car;
        public CarDecorator(ICar car)
        {
            this.car = car; 
        }
        public virtual int GetPrice()
        {
           return car.GetPrice();
        }
    }
}
