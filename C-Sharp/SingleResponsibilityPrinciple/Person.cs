using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class Person
    {
       //public  string Firstname { get; set; }
        public string? FirstName { get; internal set; }
      //  public string Lastname { get; set; }
        public string? LastName { get; internal set; }
    }
}
