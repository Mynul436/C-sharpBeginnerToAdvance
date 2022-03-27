using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Teacher:Interface1
    {
        public string getName()
        {
            return "Teacher name";
        }
        public string getFatherName()
        {
            return "Teacher father name";
        }
    }
}
