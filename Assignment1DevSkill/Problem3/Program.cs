// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


int[][,] jaggedArray4 = new int[][,]
            {
                new int[,] { {1,3}, {5,7} },
                new int[,] { {0,2}, {4,6}, {8,10} },
                new int[,] { {11,22}, {99,88}, {0,9} }
            };

for (int i = 0; i < jaggedArray4.Length; i++)
{

    int count = 0;

    
    for (int j = 0; j < jaggedArray4[i].GetLength(count); j++)
    {

        for (int k = 0; k < jaggedArray4[j].Rank; k++)
            Console.Write("Jagged_Array4[" + i + "][" + j + ", " + k + "]: "
                                        + jaggedArray4[i][j, k] + " ");
        Console.WriteLine();
    }
        count++;
    Console.WriteLine();
}