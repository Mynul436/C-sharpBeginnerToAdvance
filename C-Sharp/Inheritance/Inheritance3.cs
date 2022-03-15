using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Inheritance3
    {
        public string name;
        public string subject;
        public void readers(string name,string subject)
        {
            this.name = name;
            this.subject = subject;
            Console.WriteLine($"Your name is :{name} and subject is {subject}");
        }
    }
}
