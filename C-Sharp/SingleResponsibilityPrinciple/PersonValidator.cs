using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    internal class PersonValidator
    {
        public static bool Validate(Person person)
        {
            if (string.IsNullOrWhiteSpace(person.FirstName))
            {
                Console.WriteLine("You did not give valid name!");
                StandardClass.EndApplication();
                return false;
            }
            if (string.IsNullOrWhiteSpace(person.LastName)) {
                Console.WriteLine("You did not give valid name!");
                StandardClass.EndApplication();
                return false;
            }
            return true;
        } 
    }  
}
