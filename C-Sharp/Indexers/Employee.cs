using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    public class Employee
    {
        private int[] Age = new int[3];
        public int this[int index]
        {
            set 
            {
                Age[index] = value;
            
            }
            get { 
            return Age[index];
            
            }
        }
    }
}
