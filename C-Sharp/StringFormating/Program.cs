// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Decimal p = 17.3m;
string s = string.Format("The curent price is {0}", p);
Console.WriteLine(s);
string s1 = String.Format("At {0}, the temperature is {1}°C.",
                         DateTime.Now, 20.4);
Console.WriteLine(s1);
DateTime dat =DateTime.Now;
string city = "Chicago";
int temp = -16;
string output = String.Format($"At {dat} in {1}, the temperature was {2} degrees.",
                               city, temp);
Console.WriteLine(output);