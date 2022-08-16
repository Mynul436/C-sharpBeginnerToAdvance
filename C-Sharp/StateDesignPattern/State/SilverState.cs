using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern.IState
{
    public class SilverState : IState
    {
        public void GetInterest()
        {
            Console.WriteLine("You are in Silver State");
        }
    }
}
