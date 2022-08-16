using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.RealWorld
{
    public interface IStrategy
    {
         void Sort(List<string> list);
    }
}
