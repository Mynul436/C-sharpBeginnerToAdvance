using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class CreateObject
    {
        public static Interface1 getObject(string typeOfObject)
        {
            Interface1 ? obj= null;
            if (typeOfObject.ToLower() == "student")
            {
                obj = new Student();
            }
            else
                obj = new Teacher();
            return obj;
        }
    }
}
