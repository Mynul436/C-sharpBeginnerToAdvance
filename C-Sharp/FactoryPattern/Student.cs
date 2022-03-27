using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Student:Interface1
    {
        public string getName()
        {
            return "Student name";
        }
        public string getFatherName()
        {
            return "Student Father Name";
        }
    }
}
