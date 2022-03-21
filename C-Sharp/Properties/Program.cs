using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Pro
    {
        private string name = "Akash";
        private static int count;
       public Pro()
        {
            count++;
        }
        public static int ct {
            get { return count;
            }
}
        public string Name
        {
            
            get => name;
            set
            {
                name = value;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Pro pro = new Pro();
            Pro pro1 = new Pro();
            Pro pro2 = new Pro();
            Console.WriteLine(Pro.ct);
            pro.Name = "Mynul";
            Console.WriteLine($"The changed name will be : {pro.Name}");
           
            
        }
    }
}
