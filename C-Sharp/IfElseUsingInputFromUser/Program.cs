// See https://aka.ms/new-console-template for more information
///Console.WriteLine("Hello, World!");
while (true)
{
    Console.WriteLine("ENTER A NUMBER:");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num % 2 == 0)
    {
        Console.WriteLine("The given number is even");

    }
    else
    {
        Console.WriteLine("The given number is odd!!!");
    }
 
}