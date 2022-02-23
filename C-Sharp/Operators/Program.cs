// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine(13.33f * 13.33f);//here f for float data type
Console.WriteLine(18.88d * 18.66d);//Here d for double data type
Console.WriteLine(18.88m * 18.88m);//here m is for decimal

uint t = 0b0000_1111_0000_1111_0000_1111_0000_1100;
Console.WriteLine("Before "+t);
uint u = ~t;
Console.WriteLine(Convert.ToString(u,toBase:2));
uint p = 0b_1111_1000;
uint q = 0b_1001_1101;

uint r = p | q;
Console.WriteLine("after "+Convert.ToString(r,toBase:2));

uint w = 0b_1111_1000;
uint v = 0b_0001_1100;
uint x = w ^ v;
Console.WriteLine($"after : {Convert.ToString(x,toBase:2)}");
uint y = 0xfff;
Console.WriteLine(Convert.ToString(y,toBase:2));

