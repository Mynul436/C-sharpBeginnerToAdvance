using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    internal class StandardClass
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome To my application");
        }
        public static void EndApplication()
        {
            Console.ReadLine();
        }
    }
}
