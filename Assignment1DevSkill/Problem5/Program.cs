// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Console.WriteLine();

Console.WriteLine("Printing the sum of numbers that are in the 2 diagonal positions in 2d Array.");
Console.WriteLine();

Console.WriteLine("Enter the size of diagonal array: ");

int num;
num =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the elements one by one:");

int[,] array = new int[num, num];
int sum = 0;

for (int i = 0; i < num; i++)
{
    for (int j = 0; j < num; j++)
    {
        array[i,j] = Convert.ToInt32(Console.ReadLine());
        if ((i + j) == num - 1)
        {
            sum+=array[i,j];
        }
    }
}
Console.WriteLine();

Console.WriteLine("Here is the 2D array you have entered!!!");
for (int i = 0; i < num; i++)
{
    Console.WriteLine();

    for (int j = 0; j < num; j++)
    {
        Console.Write(array[i,j]+" ");
    }
}
Console.WriteLine();
Console.WriteLine($"And the sum of Second Diagonal numbers is: {sum}");
Console.WriteLine();
