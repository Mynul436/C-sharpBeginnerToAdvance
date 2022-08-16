﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorPattern
{
    public class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee){
            _adaptee=adaptee;
            }
        public string Abc()
        {
            return _adaptee.GetSpecificationRequest();
        }
    }
}
