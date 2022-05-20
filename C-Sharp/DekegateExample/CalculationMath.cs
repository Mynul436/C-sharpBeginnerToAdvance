using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    public  delegate void Calculation(int a, int b);
    public class CalculationMath
    {
        public static void Addition(int a,int b)
        {
            int result = a + b;
            Console.WriteLine("The result of Addition is :{0}",result);
        }
    }
}
