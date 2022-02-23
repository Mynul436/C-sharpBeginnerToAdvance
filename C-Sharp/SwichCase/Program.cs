// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.WriteLine("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());
switch (num)
{
    case 10:
        Console.WriteLine("You entered 10!");
        break;
    case 11:
        Console.WriteLine("You entered 11");
        break;
    // default: Console.WriteLine("....");
  //  default:
       // Console.WriteLine("Default");
    default: Console.WriteLine("...");
        break;
}