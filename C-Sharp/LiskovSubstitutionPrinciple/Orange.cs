using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    internal class Orange : Fruit
    {
        public override string GetColor()
        {
            return "Orange";

            throw new NotImplementedException();
        }
    }
}
