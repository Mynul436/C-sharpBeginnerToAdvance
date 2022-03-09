using System;

class Problem7
{
    static int N ;

   
    static void rotateClockwise(int[,] arr)
    {

        
        for (int i = 0; i <N/ 2; i++)
        {
            for (int j = i; j <N - i - 1; j++)
            {

                int temp = arr[i, j];
                arr[i, j] = arr[N - 1 - j, i];
                arr[N - 1 - j, i] = arr[N - 1 - i, N - 1 - j];
                arr[N - 1 - i, N - 1 - j] = arr[j, N - 1 - i];
                arr[j, N - 1 - i] = temp;
            }
        }
    }

    
    static void printMatrix(int[,] arr)
    {
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
                Console.Write(arr[i, j] + " ");
            Console.Write("\n");
        }
    }

  
    public static void Main()
    {
      //  
        Console.WriteLine("Please enter how many row and colum  should have  (row and col must be same): ");
        N=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input only integer 2d array :");
        int[,] arr = new int[N,N];
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                arr[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        rotateClockwise(arr);
        printMatrix(arr);
    }
}