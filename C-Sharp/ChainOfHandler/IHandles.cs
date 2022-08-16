using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfHandler
{
    public abstract class  IHandles
    {
        protected  IHandles _successers;

        public  void SetSuccessor(IHandles handles)
        {
            _successers = handles;
        }

        public abstract void HandleRequest(int request);
    }
}
