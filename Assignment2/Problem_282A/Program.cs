using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_282A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int TestCas=Convert.ToInt32(Console.ReadLine());
            string str;
            int ct = 0;
            while(TestCas-- > 0)
            {
                str = Console.ReadLine();
                if (str[1] == '+')
                    ++ct;
                else
                    --ct;
            }
            Console.WriteLine(ct);
        }
    }
}
