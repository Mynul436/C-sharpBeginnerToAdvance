using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inportantinterface
{
    public class Box:IEnumerable<object>
    {
        private object[] _item;

        public IEnumerator<object> GetEnumerator()
        {
            return new BoxEnumerator();
        }

        
         
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
