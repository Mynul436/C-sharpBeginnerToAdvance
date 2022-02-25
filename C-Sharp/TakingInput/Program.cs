// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//string input = Console.ReadLine();
//Console.WriteLine(input);
//string[] parts=input.Split(' ');
//Console.WriteLine(input);
/*for(int i=0; i<parts.Length; i++)
{
    Console.WriteLine(parts[i]);    
}*/
/*foreach (var part in parts)
{
    Console.WriteLine(part.Trim());
}*/

int size = 0;

string sizeInput=Console.ReadLine();

size=int.Parse(sizeInput);

//Console.WriteLine(size);
if(int.TryParse(sizeInput, out size))
{

}

