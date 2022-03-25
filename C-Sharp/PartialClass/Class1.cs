using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    internal partial class Product
    {
        public int id { get; set; }
        public double price { get; set; }
        public double CalculateDiscount(double persetage)
        {
            Console.WriteLine("From Product");
            return persetage * price / 100;
        }
    }
}
