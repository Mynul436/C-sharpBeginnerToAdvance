using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    internal class PersonDtaCapture
    {
        public static Person Capture()
        {
            Person Output = new Person();
            Console.WriteLine("What is your first naame?");
            Output.FirstName = Console.ReadLine();
            Console.WriteLine("What is your ;ast name?");
            Output.LastName = Console.ReadLine();
            return Output;

        }
    }
}
