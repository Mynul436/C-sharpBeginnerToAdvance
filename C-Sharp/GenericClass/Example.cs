using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    internal class Example<T>
    {
        private T box;
        //public Example(T b)
        //{
        //    this.box = b;
        //}
        //public T GetBox()
        //{
        //    return this.box;
        //}
        public T Box
        {
            set
            {
                this.box = value;
            }
            get
            {
                return this.box;
            }

        }

    }
}