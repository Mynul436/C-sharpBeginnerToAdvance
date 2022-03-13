using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1529A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int TestCase=Convert.ToInt32(Console.ReadLine());
            while (TestCase-- > 0)
            {
                int avg ,ct=0;
                int sum = 0;
                int min;
                int num=Convert.ToInt32(Console.ReadLine());
               String[] str1 =Console.ReadLine().Split();
               int[] arr1 = new int[str1.Length];
             // int[]arr=new int[num];    
               for (int i = 0; i < str1.Length; i++)
                  //  for (int i = 0; i < num; i++)
                    {
                      arr1[i]=Convert.ToInt32(str1[i]);
                  //  arr[i] = Convert.ToInt32(arr[i]);
                }
              //  for (int i = 0; i < str1.Length; i++)
             //   {
              //      sum=sum+arr1[i];
                   // Console.WriteLine(sum / str1.Length);
            //    }
            min=arr1.Min();
               avg= sum/str1.Length;
                for (int i = 0; i < str1.Length; i++)
                {
                    if(min<arr1[i])
                        ct++;
                        
                }
                Console.WriteLine(ct);
            }
            //  Fun(arr,str.Length);
            

            }
        }
   /*    private static int Fun(int[] arr1,int l)

        {
            int avg=0;
            for (int i = 0; i < l; i++)
            {
                avg += arr1[i];
            }
            return avg/l;
        }*/
    }

