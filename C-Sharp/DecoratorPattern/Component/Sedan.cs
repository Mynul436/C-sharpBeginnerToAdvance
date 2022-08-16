using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Component
{
    public class Sedan : ICar
    {
        public int GetPrice()
        {
            return 20000;
        }
    }
}
