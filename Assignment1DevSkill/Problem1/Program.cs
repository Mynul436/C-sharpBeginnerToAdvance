Console.WriteLine("Please,Enter a integer number:");
int inputNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"You have entered {inputNumber}");
int y = inputNumber;
Console.WriteLine("Please, Enter how many times you want to rotate: ");
int rotationTime = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"You have entered {rotationTime}");
Console.WriteLine();

if (rotationTime > 30 || rotationTime < -1)
{
    Console.WriteLine("Sorry you input a out of bound rotation time!!!");
}
else
{
    Console.WriteLine("Here we go!!!");
    Console.WriteLine();
    int x = 0b1;
    for (int i = 0; i < rotationTime; ++i)
    {
       
        int num = i + 1;
        if (num % 4 == 0)
        {
            

            Console.WriteLine(Convert.ToString(y | x, toBase: 2).PadLeft(32, '0'));
            Console.WriteLine($"The number of rotation :{i + 1}");         
            inputNumber = y | x;
        }
        else
        {
            Console.WriteLine(Convert.ToString(y, toBase: 2).PadLeft(32, '0'));
            Console.WriteLine($"The number of rotation :{i + 1}");
            inputNumber = y;
        }
        y = inputNumber << 1;

    }
}




