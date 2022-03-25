using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceFeature
{
    internal class Electronics:Product
    {
        public double num { get; set; }
        public int num2;
        
        public new  double CalculateDiscount(double persentage)
        {
            Console.WriteLine("From Electronics");
            if(persentage > 20)
                persentage = 20;
           Console.WriteLine(num = 100*persentage);


            return price*persentage/100;

        }
    }
}
