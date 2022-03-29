using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    internal class Apple : Fruit
    {
        public override string GetColor()
        {
            //  throw new NotImplementedException();
            return "Red";
        }
    }
}
