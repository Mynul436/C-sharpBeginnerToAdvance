using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1367B
{
    internal class Class1
    {
        public static void Main(String[] args)
        {
            int TestCase;
            TestCase = Convert.ToInt32(Console.ReadLine());
            while (TestCase-- > 0)
            {
                int even = 0;
                int odd = 0;   
                int count = 0;
                int num = Convert.ToInt32(Console.ReadLine());
                String[] str = Console.ReadLine().Split();
                int[] arr = new int[str.Length];
                for (int i = 0; i < str.Length; i++)
                {
                    arr[i] = Convert.ToInt32(str[i]);
                }

                for (int i = 0; i < str.Length; i++)
                {
                    // Console.Write(arr[i]+" ");

                    if (arr[i] % 2 != i % 2)
                    {
                        if (i % 2 == 0)
                        {
                            even++;
                        }
                        else
                        {
                            odd++;
                        }
                    }

                    //  Console.WriteLine();

                    /*        if ((str.Length / 2) <= even && even!=0)
                           // if (Math.Ceiling((decimal)(str.Length / 2)) <= even && even!=0)

                            {

                                for (int i = 0; i < str.Length; i+=2)
                                {
                                    if(arr[i]%2==0 && arr[i + 2] % 2 != 0)
                                    {
                                        Console.WriteLine(0);
                                    }

                                    for(int j = i+1; j < str.Length; j++)
                                    {
                                        if (arr[i]%2!=0 && arr[j]%2==0)
                                        {
                                           arr[i]=arr[i]+arr[j];
                                            arr[j]=arr[i]-arr[j];
                                            arr[i] = arr[i] - arr[j];
                                            count++;
                                            break;
                                        }
                                    }
                                    Console.WriteLine(count);
                                }
                                Console.WriteLine(count);
                            }*/
                    
                }
                if ((even != odd))
                    Console.WriteLine(-1);
                else
                    Console.WriteLine(even);

            }
        }
    }

 }

        
    

