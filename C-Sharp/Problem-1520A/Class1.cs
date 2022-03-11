using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1520A
{
    internal class Class1
    {
       static void Main(String[] args)
        {

            int TestCase = Convert.ToInt32(Console.ReadLine());
            while(TestCase-- >0)
            {
                Problem();
              // TestCase--;
            }

        }
         static void Problem()
        {
            int num = Convert.ToInt32(Console.ReadLine());

            // String[] str=new String[num];
            //  str = Console.ReadLine().Split();
            String str = Console.ReadLine();

            for (int i = 0; i < num; i++)
            {
                for (int j = i + 1; j < num; j++)
                {
                    if (str[i] == str[j])
                    {

                    }
                    if (str[i] != str[j])
                    {
                        for (int k = j + 1; k < str.Length; k++)
                        {
                            if (str[i] == str[k])
                            {
                                Console.WriteLine("NO");
                                 return ;
                                //break;
                            }
                        }
                    }
                }
                // Console.WriteLine("YES");
            }
            Console.WriteLine("YES");
        }


    }
}
