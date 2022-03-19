using System;

namespace Problem_1547A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int TestCase;
            TestCase = Convert.ToInt32(Console.ReadLine());
            while (TestCase-- > 0)
            {
                string[] x = Console.ReadLine().Split();
                int[] arr1 = new int[x.Length];
                for (int i = 0; i < x.Length; i++)
                {
                    arr1[i] = Convert.ToInt32(x[i]);
                }
                string[] x1 = Console.ReadLine().Split(' ');
                int[] arr2 = new int[x1.Length];
                for (int i = 0; i < x1.Length; i++)
                {
                    arr2[i] = Convert.ToInt32(x[i]);
                }
                string[] x3 = Console.ReadLine().Split(' ');
                int[] arr3 = new int[x3.Length];
                for (int i = 0; i < x3.Length; i++)
                {
                    arr3[i] = Convert.ToInt32(x[i]);
                }
                int ans = Math.Abs(arr1[0] - arr2[0]) + Math.Abs(arr1[1] - arr2[1]);
                if ((arr1[0] == arr2[0] && arr1[0] == arr3[0] && Math.Min(arr1[1], arr2[1]) < arr3[1] && arr3[1] < Math.Max(arr1[1], arr2[1]))
                        || (arr1[1] == arr2[1] && arr1[1] == arr3[1] && Math.Min(arr1[0], arr2[0]) < arr3[0] && arr3[0] < Math.Max(arr1[0], arr2[0])))
                    ans += 2;

                Console.WriteLine(ans);
            }
        }
    }
}
